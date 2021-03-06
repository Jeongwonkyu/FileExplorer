using Windows.Storage;

namespace FileExplorer.Models
{
	public class MenuFolderItem
	{
		public StorageFolder Folder { get; set; }
		public string DisplayName { get => this.Folder.DisplayName; }
		public string Icon { get => this.Folder.Path.Length <= 3 ? "\xEDA2" : "\xE8B7"; }

		public MenuFolderItem(StorageFolder folder)
		{
			this.Folder = folder;
		}
	}
}
