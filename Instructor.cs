using System.Windows.Media;

namespace WPF_DataBinding_DataGrid_Auto_Ex
{
	public enum Gender
	{
		man = 1,
		woman
	};
	public class Instructor
	{
		public String Name { get; set; }
		public Gender Gender { get; set; }
		public Boolean HasDegree { get; set; }
		public Uri Homepage { get; set; }
		public ImageSource ProfilePicture { get; set; } 
	}
}
