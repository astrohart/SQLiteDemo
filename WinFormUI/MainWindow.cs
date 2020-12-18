using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;
using DemoLibrary;

namespace WinFormUI
{
    /// <summary>
    ///     Functionality for the main window of this application.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        ///     Collection of people.
        /// </summary>
        private readonly ObservableCollection<PersonModel> _people =
            new ObservableCollection<PersonModel>();

        /// <summary>
        ///     Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static MainWindow() { }

        /// <summary>
        ///     Constructs a new instance of <see cref="T:WinFormUI.MainWindow" /> and
        ///     returns a reference to it.
        /// </summary>
        /// <remarks>
        ///     Empty, protected constructor to prohibit direct allocation of this class.
        /// </remarks>
        protected MainWindow()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        /// <summary>
        ///     Gets a reference to the one and only instance of
        ///     <see cref="T:WinFormUI.MainWindow" />.
        /// </summary>
        public static MainWindow Instance { get; } = new MainWindow();

        /// <summary>
        ///     Creates a list of people and then populates the GridView with it.
        /// </summary>
        private void LoadPeopleList()
        {
            Trace.WriteLine(
                "Creating fake people in order to populate the list..."
            );

            _people.Add(
                new PersonModel { FirstName = "Tim", LastName = "Corey" }
            );
            _people.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
            _people.Add(
                new PersonModel { FirstName = "Mary", LastName = "Smith" }
            );

            Trace.WriteLine(
                "3 people created and added to in-memory data store.  Attaching data store to binding source..."
            );

            WireupPeopleList();

            Trace.WriteLine("MainWindow.LoadPeopleList: Done.");
        }

        /// <summary>
        ///     Connects the in-memory data store of people to the GridView control.
        /// </summary>
        private void WireupPeopleList()
        {
            Trace.WriteLine("Connecting the grid view to the data source...");

            personModelBindingSource.DataSource = null;
            personModelBindingSource.DataSource = _people;

            Trace.WriteLine("MainWindow.WireupPeopleList: Done.");
        }
    }
}