using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        const int CountElements = 5;
        
        private Color __errorColor = Color.Pink;
        
        private Color _correctColor = Color.White;
        
        private Rectangle[] _rectangles;
        
        private Rectangle _currentRectangle;
        
        private Movie[] _movies;
        
        private Movie _currentMovie;
        
        private Random _randomValues;

        public MainForm()
        {
            InitializeComponent();
            Array allEnums = Enum.GetValues(typeof(Enums));
            foreach (Enums value in allEnums)
            {
                EnumListBox.Items.Add(value);
            }
            
            _randomValues = new Random();

            EnumListBox.SelectedIndex = 0;

            Array seasonValues = Enum.GetValues(typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            }
            _rectangles = CreateRectangles();
            RectangleListBox.SelectedIndex = 0;
            
            _movies = CreateMovies();
            MovieListBox.SelectedIndex = 0;
        }

        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(1, 1001) / 10.0;
                _currentRectangle.Length = _randomValues.Next(1, 1001) / 10.0;
                _currentRectangle.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
            return rectangles;
        }
        
        private Movie[] CreateMovies()
        {
            Movie[] movies = new Movie[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _randomValues.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _randomValues.Next(1900, 2023);
                _currentMovie.Genre = genres.GetValue(_randomValues.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _randomValues.Next(151);
                movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            return movies;
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
                LengthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            LengthRectangleTextBox.BackColor = _correctColor;
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
                WidthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            WidthRectangleTextBox.BackColor = _correctColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorRectangleTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = rectangles[0].Width;
            for (int i = 0; i < CountElements; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
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
                YearReleaseMovieTextBox.BackColor = _errorColor;
                return;
            }

            YearReleaseMovieTextBox.BackColor = _correctColor;
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
                DurationMinutesMovieTextBox.BackColor = _errorColor;
                return;
            }

            DurationMinutesMovieTextBox.BackColor = _correctColor;
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
                RatingMovieTextBox.BackColor = _errorColor;
                return;
            }
            RatingMovieTextBox.BackColor = _correctColor;
        }

        private int FindMovieWithMaxRating(Movie[] Movies)
        {
            int maxRatingIndex = 0;
            double maxValue = Movies[0].Rating;
            for (int i = 0; i < CountElements; i++)
            {
                if (Movies[i].Rating > maxValue)
                {
                    maxValue = Movies[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}