using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_DataBinding_DataGrid_Group;

public partial class MainWindow : Window
{
	private List<Instructor> Instructors;
	public MainWindow()
	{
		InitializeComponent();
		Instructors = new List<Instructor>();
		InitializeInstructors();
		// A csoportosításhoz nézet (CollectionView) kell a lista fölé: a nézet
		// GroupDescriptions gyűjteménye adja meg, mi szerint csoportosítunk.
		// Csoportleírás nélkül a DataGrid GroupStyle-ja (és így az Expander)
		// egyáltalán nem jelenik meg.
		var view = new ListCollectionView(Instructors);
		view.GroupDescriptions.Add(
			new PropertyGroupDescription(nameof(Instructor.HasDegree)));
		dgData.ItemsSource = view;

	}
	private void InitializeInstructors()
	{
		var ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Pictures/pacman-145855_640.png") as ImageSource;

		Instructors.Add(new Instructor
		{
			Name = "Kutató József",
			Gender = Gender.man,
			HasDegree = false,
			Homepage = new Uri("http://kutatojozsef.hu"),
			ProfilePicture = ims
		});
		ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Pictures/pacman-145859_640.png") as ImageSource;
		Instructors.Add(new Instructor
		{
			Name = "Kutató Jolán",
			Gender = Gender.woman,
			HasDegree = true,
			Homepage = new Uri("http://kutatojolan.hu"),
			ProfilePicture = ims
		});
		ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Pictures/viking-149113_640.png") as ImageSource;
		Instructors.Add(new Instructor
		{
			Name = "Kutató Gerzson",
			Gender = Gender.man,
			HasDegree = true,
			Homepage = new Uri("http://kutatogerzson.hu"),
			ProfilePicture = ims
		});
	}
}