using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Explorer
{
	public partial class Form1 : Form
	{
		View view;
		string currentNode = "";
		readonly string[] archive_formats = { "iso", "7z", "rar", "zip" };
		readonly string[] sizes = { "B", "KB", "MB", "GB", "TB" };
		readonly string[] imageNames = { "Drive", "Folder_Closed", "Folder_Opened", "Archive", "File", "Application" };

		public Form1()
		{
			InitializeComponent();
		}

		#region Events

		private void Form1_Load(object sender, EventArgs e)
		{
			GetImageFormResource();
			PopulateTreeView();
			SetStatusBar();
			view = lvExplorer.View;
			foreach (ToolStripItem item in viewToolStripMenuItem.DropDownItems)
				item.MouseHover += Item_MouseHover;
			AddNotifyIcon();
		}

		private void Item_MouseHover(object sender, EventArgs e)
		{
			SubMenuItem_MouseHover(sender.ToString());
		}

		private void TvExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			LoadFromTreeViewToListView(e.Node);
		}

		/// <summary>
		/// Display closed folder icon
		/// </summary>
		private void TvExplorer_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			if (e.Node != tvExplorer.Nodes[0])
				e.Node.ImageIndex = 1;
		}

		/// <summary>
		/// Display opened folder icon
		/// </summary>
		private void TvExplorer_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node != tvExplorer.Nodes[0])
				e.Node.ImageIndex = 2;
		}

		private void SmallIcon_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.SmallIcon;
			view = lvExplorer.View;
		}

		private void LargeIcon_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.LargeIcon;
			view = lvExplorer.View;
		}

		private void Details_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = true;
			lvExplorer.FullRowSelect = true;
			lvExplorer.View = View.Details;
			view = lvExplorer.View;
		}

		private void List_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.List;
			view = lvExplorer.View;
		}

		private void Tile_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.Tile;
			view = lvExplorer.View;
		}

		private void ViewToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			lvExplorer.View = view;
		}

		private void ViewToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
		{
			lvExplorer.View = view;
		}

		private void SubMenuItem_MouseHover(string item)
		{
			switch (item)
			{
				case "Details":
					lvExplorer.View = View.Details;
					break;
				case "List":
					lvExplorer.View = View.List;
					break;
				case "Tile":
					lvExplorer.View = View.Tile;
					break;
				case "Large Icon":
					lvExplorer.View = View.LargeIcon;
					break;
				case "Small Icon":
					lvExplorer.View = View.SmallIcon;
					break;
				default:
					break;
			}
		}

		private async void LvExplorer_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
		{
			ListViewItem item = e.Item;
			string info = string.Empty, currentPath;
			currentPath = currentNode + "\\" + item.Text;
			if (item.SubItems[1].Text == "File")
			{
				await Task.Run(() =>
				{
					FileInfo file = new FileInfo(currentPath);
					info = string.Format("Type: {0}\r\nAuthors: {1}\r\nSize: {2}\r\nDate Modified: {3}", GetType(file.Extension), GetOwnerFile(file.FullName), ConvertFileLength(file.Length), file.LastWriteTime.ToShortDateString());
				});
			}
			else
			{
				await Task.Run(async () =>
				{
					DirectoryInfo dir = new DirectoryInfo(currentPath);
					info = string.Format("Date created: {0}\r\nSize: {1}\r\nFiles: {2}\r\nFolders: {3}", dir.CreationTime.ToShortDateString() + " " + dir.CreationTime.ToShortTimeString(), ConvertFileLength(await GetDirectorySize(dir.FullName)), await GetListFiles(dir.FullName), await GetListDirectories(dir.FullName));
				});
			}
			item.ToolTipText = info;
		}

		private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string currentPath = currentNode + "\\" + lvExplorer.SelectedItems[0].Text;
			Process.Start(currentPath);
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var list = new StringCollection();
			foreach (ListViewItem item in lvExplorer.SelectedItems)
				list.Add(currentNode + "\\" + item.Text);
			Clipboard.SetFileDropList(list);
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var list = Clipboard.GetFileDropList();
			if (list.Count > 0)
			{
				foreach (var path in list)
				{
					if (path.Contains("."))
					{
						FileInfo file = new FileInfo(path);
						lvExplorer.Items.Add(CreateNewListItem(file));
						string fileName = Path.GetFileName(path);
						File.Copy(path, Path.Combine(currentNode, fileName));
					}
					else
					{
						DirectoryInfo dir = new DirectoryInfo(path);
						lvExplorer.Items.Add(CreateNewListItem(dir));
						Directory.CreateDirectory(currentNode + "\\" + Path.GetFileName(path));
						foreach (string dirPath in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
							Directory.CreateDirectory(dirPath.Replace(path, currentNode + "\\" + Path.GetFileName(path)));
						foreach (string newPath in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
							File.Copy(newPath, newPath.Replace(path, currentNode), true);
					}
				}
				SetStatusBar();
			}
		}

		private void lvExplorer_Click(object sender, EventArgs e)
		{
			SetStatusBar();
		}

		#endregion

		#region Methods
		void AddNotifyIcon()
		{
			notifyIcon.Icon = SystemIcons.Application;
			notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon.BalloonTipTitle = "Thông báo!";
			notifyIcon.BalloonTipText = "Chương trình đang chạy";
			notifyIcon.ShowBalloonTip(2000);
		}

		void GetImageFormResource()
		{
			largeImageList.ImageSize = new Size(75, 75);
			smallImageList.ImageSize = new Size(20, 20);
			foreach (var item in imageNames)
			{
				smallImageList.Images.Add(item, File_Explorer.Properties.Resources.ResourceManager.GetObject(item) as Image);
				largeImageList.Images.Add(item, File_Explorer.Properties.Resources.ResourceManager.GetObject(item) as Image);
			}
			lvExplorer.LargeImageList = largeImageList;
			lvExplorer.SmallImageList = smallImageList;
		}

		void PopulateTreeView()
		{
			TreeNode rootNode;
			DirectoryInfo info = new DirectoryInfo(@"D:\");
			if (info.Exists)
			{
				rootNode = new TreeNode(info.Name)
				{
					Tag = info,
					ImageIndex = 0
				};
				Task.Run(() =>
				{
					GetDirectories(info.GetDirectories(), rootNode);
				});
				tvExplorer.Nodes.Add(rootNode);
			}
		}

		/// <summary>
		/// Find all files and folders recursively
		/// </summary>
		/// <param name="subDirs"></param>
		/// <param name="rootNode"></param>
		void GetDirectories(DirectoryInfo[] subDirs, TreeNode rootNode)
		{
			TreeNode aNode;
			DirectoryInfo[] subSubDirs; //Thư mục con của thư mục gốc
										//Với mỗi thư mục gốc hay thư mục trong subDirs
			this.BeginInvoke(new MethodInvoker(() =>
			{
				subDirs = subDirs.Where(f => !f.Attributes.HasFlag(FileAttributes.System)).ToArray();
				foreach (DirectoryInfo subDir in subDirs)
				{
					//Tạo một node mới
					aNode = new TreeNode(subDir.Name, 1, 2)
					{
						Tag = subDir
					};
					subSubDirs = subDir.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.System)).ToArray();   //Tìm các subSubDirs có trong subDirs
					if (subSubDirs.Length != 0)
						GetDirectories(subSubDirs, aNode);  //Thêm vào node đó
					rootNode.Nodes.Add(aNode);  //Thêm vào node gốc
				}
			}));
		}

		string ConvertFileLength(double len)
		{
			int order = 0;
			while (len >= 1024 && order < sizes.Length - 1)
			{
				order++;
				len /= 1024;
			}
			return string.Format("{0:0.##} {1}", len, sizes[order]);
		}

		async Task<double> GetDirectorySize(string folderPath)
		{
			double size = 0;
			DirectoryInfo info = new DirectoryInfo(folderPath);
			DirectoryInfo[] subDirs = info.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.System)).ToArray();
			await Task.Run(() =>
			{
				if (subDirs.Length > 0)
					foreach (var dir in subDirs)
					{
						size += GetDirectorySize(dir.FullName).Result;
					}
				FileInfo[] subFiles = info.GetFiles();
				size += subFiles.Sum(f => f.Length);
			});
			return size;
		}

		async Task<string> GetListDirectories(string path)
		{
			string result = "";
			DirectoryInfo info = new DirectoryInfo(path);
			await Task.Run(() =>
			{
				DirectoryInfo[] subDirs = info.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.System)).ToArray();
				if (subDirs.Length > 0)
					foreach (var dir in subDirs)
					{
						result += dir.Name + ", ";
						if (result.Length > 50)
						{
							result += "...";
							break;
						}
					}
			});
			return result;
		}

		async Task<string> GetListFiles(string path)
		{
			string result = "";
			DirectoryInfo info = new DirectoryInfo(path);
			await Task.Run(() =>
			{
				FileInfo[] subFiles = info.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.System)).ToArray();
				if (subFiles.Length > 0)
					foreach (var file in subFiles)
					{
						result += file.Name + ", ";
						if (result.Length > 50)
						{
							result += "...";
							break;
						}
					}
			});
			return result;
		}

		string GetOwnerFile(string filePath)
		{
			FileInfo info = new FileInfo(filePath);
			return info.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
		}

		string GetType(string fileNameOrExtension)
		{
			string mimeType = "application/unknown";
			string ext = (fileNameOrExtension.Contains(".")) ? System.IO.Path.GetExtension(fileNameOrExtension).ToLower() : "." + fileNameOrExtension;
			Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
			if (regKey != null && regKey.GetValue("Content Type") != null) mimeType = regKey.GetValue("Content Type").ToString();
			return mimeType;
		}

		ListViewItem CreateNewListItem(Object _object)
		{
			ListViewItem item = null;
			ListViewItem.ListViewSubItem[] subItems;
			if (_object is DirectoryInfo info)
			{
				item = new ListViewItem(info.Name, 1);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, info.LastAccessTime.ToShortDateString()) };
				item.SubItems.AddRange(subItems);
				item.ImageKey = "Folder_Closed";
			}
			else if (_object is FileInfo info1)
			{
				item = new ListViewItem(info1.Name);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, info1.LastAccessTime.ToShortDateString()) };
				item.SubItems.AddRange(subItems);
				string[] temp = item.Text.Split('.');
				if (temp[temp.Length - 1] == "exe")
					item.ImageIndex = 5;
				else if (Array.Exists(archive_formats, t => t == temp[temp.Length - 1]))
					item.ImageIndex = 3;
				else
					item.ImageIndex = 4;
			}
			return item;
		}

		void SetStatusBar()
		{
			status1.Text = lvExplorer.Items.Count.ToString() + " item(s)";
			status2.Text = lvExplorer.SelectedItems.Count.ToString() + " item(s) selected";
		}

		void LoadFromTreeViewToListView(TreeNode newSelected)
		{
			lvExplorer.Items.Clear();
			DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
			var dir_filtered = nodeDirInfo.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.System));
			foreach (DirectoryInfo dir in dir_filtered)
				lvExplorer.Items.Add(CreateNewListItem(dir));
			var file_filtered = nodeDirInfo.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.System));
			foreach (FileInfo file in file_filtered)
				lvExplorer.Items.Add(CreateNewListItem(file));
			currentNode = nodeDirInfo.FullName;
			lvExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			SetStatusBar();
		}

		#endregion

	}
}
