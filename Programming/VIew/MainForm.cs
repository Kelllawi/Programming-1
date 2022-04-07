using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;
        
        private Color ErrorColor = Color.Pink;
        
        private Color CorrectColor = Color.White;
        
        private Rectangle[] _rectangles;
        
        private Rectangle _currentRectangle;
        
        private Movie[] _movies;
        
        private Movie _currentMovie;
        
        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();
            Array allEnums = Enum.GetValues(typeof(Enums));
            foreach (Enums value in allEnums)
            {
                EnumListBox.Items.Add(value);
            }
            
            _random = new Random();

            EnumListBox.SelectedIndex = 0;

            Array seasonValues = Enum.GetValues(typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            } 
            CreateRectangles();
            CreateMovies();
        }

        private void CreateRectangles()
        {
            _rectangles = new Rectangle[ElementsCount];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _random.Next(1, 1001) / 10.0;
                _currentRectangle.Length = _random.Next(1, 1001) / 10.0;
                _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
                _currentRectangle.Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100));
                _rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            
            RectangleListBox.SelectedIndex = 0;
        }
        
        private void CreateMovies()
        {
            _movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, DateTime.Now.Year);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(151);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            
            MovieListBox.SelectedIndex = 0;
        }
        
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = rectangles[0].Width;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
        }
        
        private int FindMovieWithMaxRating(Movie[] Movies)
        {
            int maxRatingIndex = 0;
            double maxValue = Movies[0].Rating;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (Movies[i].Rating > maxValue)
                {
                    maxValue = Movies[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            Array enumValues;
            switch (EnumListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Season:
                    enumValues = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Manufacture:
                    enumValues = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in enumValues)
            {
                ValueListBox.Items.Add(value);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int) (ValueListBox.SelectedItem)).ToString();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday value;
            if (Enum.TryParse(textWeekdayTextBox, out value))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({value} - {(int) value})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
        
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LengthRectangleTextBox.Text = _currentRectangle.Length.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            ColorRectangleTextBox.Text = _currentRectangle.Color;
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLengthLength = LengthRectangleTextBox.Text;
                double lengthRectangleValue = double.Parse(currentLengthLength);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = ErrorColor;
                return;
            }

            LengthRectangleTextBox.BackColor = CorrectColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidthRectangle = WidthRectangleTextBox.Text;
                double widthRectangleValue = double.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = ErrorColor;
                return;
            }

            WidthRectangleTextBox.BackColor = CorrectColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorRectangleTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }
        
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            NameMovieTextBox.Text = _currentMovie.Name;
            GenreMovieTextBox.Text = _currentMovie.Genre;
            YearReleaseMovieTextBox.Text = _currentMovie.ReleaseYear.ToString();
            DurationMinutesMovieTextBox.Text = _currentMovie.DurationMinutes.ToString();
            RatingMovieTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void NameMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameMovieValue = NameMovieTextBox.Text;
            _currentMovie.Name = nameMovieValue;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreMovieTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }

        private void YearReleaseMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = YearReleaseMovieTextBox.Text;
                int yearReleaseMovieValue = int.Parse(currentYearRelease);
                _currentMovie.ReleaseYear = yearReleaseMovieValue;
            }
            catch
            {
                YearReleaseMovieTextBox.BackColor = ErrorColor;
                return;
            }

            YearReleaseMovieTextBox.BackColor = CorrectColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = DurationMinutesMovieTextBox.Text;
                int durationMinutesMovieValue = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovieValue;
            }
            catch
            {
                DurationMinutesMovieTextBox.BackColor = ErrorColor;
                return;
            }

            DurationMinutesMovieTextBox.BackColor = CorrectColor;
        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingMovieTextBox.Text;
                double ratingMovieValue = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovieValue;
            }
            catch
            {
                RatingMovieTextBox.BackColor = ErrorColor;
                return;
            }
            RatingMovieTextBox.BackColor = CorrectColor;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}