namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumerationTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TryParsingLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreMovieLabel = new System.Windows.Forms.Label();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.NameMovieLabel = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingMovieLabel = new System.Windows.Forms.Label();
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.DurationMinutesMovieLabel = new System.Windows.Forms.Label();
            this.YearReleaseMovieTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseMovieLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleLabel = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleLabel = new System.Windows.Forms.Label();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.MainTabControl.SuspendLayout();
            this.EnumerationTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumerationTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(734, 401);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumerationTabPage
            // 
            this.EnumerationTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumerationTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumerationTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumerationTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumerationTabPage.Name = "EnumerationTabPage";
            this.EnumerationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumerationTabPage.Size = new System.Drawing.Size(726, 375);
            this.EnumerationTabPage.TabIndex = 1;
            this.EnumerationTabPage.Text = "Enums";
            this.EnumerationTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonNamesComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(366, 255);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(357, 117);
            this.SeasonHandleGroupBox.TabIndex = 8;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(133, 36);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(6, 38);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonNamesComboBox.TabIndex = 10;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(3, 23);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 9;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TryParsingLabel);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 255);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(357, 117);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(25, 77);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 20);
            this.OutputWeekdayLabel.TabIndex = 8;
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(231, 37);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(75, 23);
            this.ParseWeekdayButton.TabIndex = 7;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(6, 39);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(219, 20);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // TryParsingLabel
            // 
            this.TryParsingLabel.AutoSize = true;
            this.TryParsingLabel.Location = new System.Drawing.Point(3, 23);
            this.TryParsingLabel.Name = "TryParsingLabel";
            this.TryParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.TryParsingLabel.TabIndex = 6;
            this.TryParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.ChooseEnumLabel);
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.EnumListBox);
            this.EnumGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox.Controls.Add(this.ValueListBox);
            this.EnumGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(720, 252);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumeration";
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(3, 16);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumLabel.TabIndex = 1;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(315, 16);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(6, 32);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(150, 199);
            this.EnumListBox.TabIndex = 0;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(318, 32);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(185, 20);
            this.IntValueTextBox.TabIndex = 4;
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(162, 32);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(150, 199);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(159, 16);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(726, 375);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.GenreMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.NameMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.NameMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.FindMovieButton);
            this.MoviesGroupBox.Controls.Add(this.RatingMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.RatingMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationMinutesMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationMinutesMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.YearReleaseMovieTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearReleaseMovieLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoviesGroupBox.Location = new System.Drawing.Point(366, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(145, 75);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreMovieTextBox.TabIndex = 19;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // GenreMovieLabel
            // 
            this.GenreMovieLabel.AutoSize = true;
            this.GenreMovieLabel.Location = new System.Drawing.Point(142, 59);
            this.GenreMovieLabel.Name = "GenreMovieLabel";
            this.GenreMovieLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreMovieLabel.TabIndex = 18;
            this.GenreMovieLabel.Text = "Genre:";
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.Location = new System.Drawing.Point(145, 36);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameMovieTextBox.TabIndex = 17;
            this.NameMovieTextBox.TextChanged += new System.EventHandler(this.NameMovieTextBox_TextChanged);
            // 
            // NameMovieLabel
            // 
            this.NameMovieLabel.AutoSize = true;
            this.NameMovieLabel.Location = new System.Drawing.Point(142, 20);
            this.NameMovieLabel.Name = "NameMovieLabel";
            this.NameMovieLabel.Size = new System.Drawing.Size(38, 13);
            this.NameMovieLabel.TabIndex = 16;
            this.NameMovieLabel.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(145, 286);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(103, 23);
            this.FindMovieButton.TabIndex = 15;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(145, 192);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingMovieTextBox.TabIndex = 14;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // RatingMovieLabel
            // 
            this.RatingMovieLabel.AutoSize = true;
            this.RatingMovieLabel.Location = new System.Drawing.Point(142, 176);
            this.RatingMovieLabel.Name = "RatingMovieLabel";
            this.RatingMovieLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingMovieLabel.TabIndex = 13;
            this.RatingMovieLabel.Text = "Rating:";
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(145, 153);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 12;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // DurationMinutesMovieLabel
            // 
            this.DurationMinutesMovieLabel.AutoSize = true;
            this.DurationMinutesMovieLabel.Location = new System.Drawing.Point(142, 137);
            this.DurationMinutesMovieLabel.Name = "DurationMinutesMovieLabel";
            this.DurationMinutesMovieLabel.Size = new System.Drawing.Size(100, 13);
            this.DurationMinutesMovieLabel.TabIndex = 11;
            this.DurationMinutesMovieLabel.Text = "Duration in minutes:";
            // 
            // YearReleaseMovieTextBox
            // 
            this.YearReleaseMovieTextBox.Location = new System.Drawing.Point(145, 114);
            this.YearReleaseMovieTextBox.Name = "YearReleaseMovieTextBox";
            this.YearReleaseMovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearReleaseMovieTextBox.TabIndex = 10;
            this.YearReleaseMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseMovieTextBox_TextChanged);
            // 
            // YearReleaseMovieLabel
            // 
            this.YearReleaseMovieLabel.AutoSize = true;
            this.YearReleaseMovieLabel.Location = new System.Drawing.Point(142, 98);
            this.YearReleaseMovieLabel.Name = "YearReleaseMovieLabel";
            this.YearReleaseMovieLabel.Size = new System.Drawing.Size(81, 13);
            this.YearReleaseMovieLabel.TabIndex = 9;
            this.YearReleaseMovieLabel.Text = "Year of release:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(6, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(133, 290);
            this.MovieListBox.TabIndex = 8;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.YRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.YRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.XRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.XRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(357, 369);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(145, 230);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdRectangleTextBox.TabIndex = 19;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.Location = new System.Drawing.Point(145, 215);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(100, 23);
            this.IdRectangleLabel.TabIndex = 18;
            this.IdRectangleLabel.Text = "Id";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Enabled = false;
            this.YRectangleTextBox.Location = new System.Drawing.Point(145, 192);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.YRectangleTextBox.TabIndex = 17;
            // 
            // YRectangleLabel
            // 
            this.YRectangleLabel.Location = new System.Drawing.Point(145, 176);
            this.YRectangleLabel.Name = "YRectangleLabel";
            this.YRectangleLabel.Size = new System.Drawing.Size(100, 23);
            this.YRectangleLabel.TabIndex = 16;
            this.YRectangleLabel.Text = "Y";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Enabled = false;
            this.XRectangleTextBox.Location = new System.Drawing.Point(145, 153);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.XRectangleTextBox.TabIndex = 15;
            // 
            // XRectangleLabel
            // 
            this.XRectangleLabel.Location = new System.Drawing.Point(145, 137);
            this.XRectangleLabel.Name = "XRectangleLabel";
            this.XRectangleLabel.Size = new System.Drawing.Size(100, 23);
            this.XRectangleLabel.TabIndex = 14;
            this.XRectangleLabel.Text = "X";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(145, 286);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(103, 23);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(145, 114);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorRectangleTextBox.TabIndex = 6;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // ColorRectangleLabel
            // 
            this.ColorRectangleLabel.AutoSize = true;
            this.ColorRectangleLabel.Location = new System.Drawing.Point(142, 98);
            this.ColorRectangleLabel.Name = "ColorRectangleLabel";
            this.ColorRectangleLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorRectangleLabel.TabIndex = 5;
            this.ColorRectangleLabel.Text = "Color:";
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(145, 75);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthRectangleTextBox.TabIndex = 4;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.AutoSize = true;
            this.WidthRectangleLabel.Location = new System.Drawing.Point(142, 59);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthRectangleLabel.TabIndex = 3;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(145, 36);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthRectangleTextBox.TabIndex = 2;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // LengthRectangleLabel
            // 
            this.LengthRectangleLabel.AutoSize = true;
            this.LengthRectangleLabel.Location = new System.Drawing.Point(142, 20);
            this.LengthRectangleLabel.Name = "LengthRectangleLabel";
            this.LengthRectangleLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthRectangleLabel.TabIndex = 1;
            this.LengthRectangleLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(6, 19);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(133, 290);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.EnumerationTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox XRectangleTextBox;

        private System.Windows.Forms.TextBox IdRectangleTextBox;

        private System.Windows.Forms.Label IdRectangleLabel;

        private System.Windows.Forms.Label YRectangleLabel;

        private System.Windows.Forms.TextBox YRectangleTextBox;

        private System.Windows.Forms.Label XRectangleLabel;

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EnumerationTabPage;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label ChooseEnumLabel;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label TryParsingLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.Label ColorRectangleLabel;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.Label WidthRectangleLabel;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.Label LengthRectangleLabel;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.TextBox RatingMovieTextBox;
        private System.Windows.Forms.Label RatingMovieLabel;
        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;
        private System.Windows.Forms.Label DurationMinutesMovieLabel;
        private System.Windows.Forms.TextBox YearReleaseMovieTextBox;
        private System.Windows.Forms.Label YearReleaseMovieLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.TextBox NameMovieTextBox;
        private System.Windows.Forms.Label NameMovieLabel;
        private System.Windows.Forms.TextBox GenreMovieTextBox;
        private System.Windows.Forms.Label GenreMovieLabel;
    }
}

