namespace WPFinalPlease
{
    partial class ucWorkerList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWorkerList));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dropOccupation = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropPrice = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropExprience = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropRate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tbSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.checkBRate = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkBExperience = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkBPrice = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.checkBOccupation = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dropOccupation
            // 
            this.dropOccupation.BackColor = System.Drawing.Color.Transparent;
            this.dropOccupation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dropOccupation.BorderColor = System.Drawing.Color.Silver;
            this.dropOccupation.BorderRadius = 17;
            this.dropOccupation.Color = System.Drawing.Color.Silver;
            this.dropOccupation.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropOccupation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropOccupation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropOccupation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropOccupation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropOccupation.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropOccupation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropOccupation.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropOccupation.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropOccupation.FillDropDown = true;
            this.dropOccupation.FillIndicator = false;
            this.dropOccupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropOccupation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropOccupation.ForeColor = System.Drawing.Color.Black;
            this.dropOccupation.FormattingEnabled = true;
            this.dropOccupation.Icon = null;
            this.dropOccupation.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropOccupation.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropOccupation.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropOccupation.ItemBackColor = System.Drawing.Color.White;
            this.dropOccupation.ItemBorderColor = System.Drawing.Color.White;
            this.dropOccupation.ItemForeColor = System.Drawing.Color.Black;
            this.dropOccupation.ItemHeight = 26;
            this.dropOccupation.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropOccupation.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropOccupation.Items.AddRange(new object[] {
            "Accountant",
            "Architect",
            "Builder",
            "Carpenter",
            "Construction Manager",
            "Delivery",
            "Dentist",
            "Doctor",
            "Driver",
            "Electrician",
            "Fashion Designer",
            "Information Analyst",
            "Mechanic",
            "Plumber",
            "Psychologyst",
            "Security Guard",
            "Software Developer",
            "Tutor",
            "Veterinarian",
            "Web Developer"});
            this.dropOccupation.ItemTopMargin = 3;
            this.dropOccupation.Location = new System.Drawing.Point(378, 36);
            this.dropOccupation.Name = "dropOccupation";
            this.dropOccupation.Size = new System.Drawing.Size(109, 32);
            this.dropOccupation.TabIndex = 1;
            this.dropOccupation.Text = "Occupation";
            this.dropOccupation.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropOccupation.TextLeftMargin = 5;
            // 
            // dropPrice
            // 
            this.dropPrice.BackColor = System.Drawing.Color.Transparent;
            this.dropPrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dropPrice.BorderColor = System.Drawing.Color.Silver;
            this.dropPrice.BorderRadius = 17;
            this.dropPrice.Color = System.Drawing.Color.Silver;
            this.dropPrice.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropPrice.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropPrice.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropPrice.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropPrice.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropPrice.FillDropDown = true;
            this.dropPrice.FillIndicator = false;
            this.dropPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropPrice.ForeColor = System.Drawing.Color.Black;
            this.dropPrice.FormattingEnabled = true;
            this.dropPrice.Icon = null;
            this.dropPrice.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropPrice.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropPrice.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropPrice.ItemBackColor = System.Drawing.Color.White;
            this.dropPrice.ItemBorderColor = System.Drawing.Color.White;
            this.dropPrice.ItemForeColor = System.Drawing.Color.Black;
            this.dropPrice.ItemHeight = 26;
            this.dropPrice.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropPrice.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropPrice.Items.AddRange(new object[] {
            "Highest",
            "Lowest"});
            this.dropPrice.ItemTopMargin = 3;
            this.dropPrice.Location = new System.Drawing.Point(512, 37);
            this.dropPrice.Name = "dropPrice";
            this.dropPrice.Size = new System.Drawing.Size(109, 32);
            this.dropPrice.TabIndex = 3;
            this.dropPrice.Text = "Price";
            this.dropPrice.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropPrice.TextLeftMargin = 5;
            // 
            // dropExprience
            // 
            this.dropExprience.BackColor = System.Drawing.Color.Transparent;
            this.dropExprience.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dropExprience.BorderColor = System.Drawing.Color.Silver;
            this.dropExprience.BorderRadius = 17;
            this.dropExprience.Color = System.Drawing.Color.Silver;
            this.dropExprience.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropExprience.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropExprience.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropExprience.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropExprience.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropExprience.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropExprience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropExprience.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropExprience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropExprience.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropExprience.FillDropDown = true;
            this.dropExprience.FillIndicator = false;
            this.dropExprience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropExprience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropExprience.ForeColor = System.Drawing.Color.Black;
            this.dropExprience.FormattingEnabled = true;
            this.dropExprience.Icon = null;
            this.dropExprience.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropExprience.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropExprience.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropExprience.ItemBackColor = System.Drawing.Color.White;
            this.dropExprience.ItemBorderColor = System.Drawing.Color.White;
            this.dropExprience.ItemForeColor = System.Drawing.Color.Black;
            this.dropExprience.ItemHeight = 26;
            this.dropExprience.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropExprience.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropExprience.Items.AddRange(new object[] {
            "Highest"});
            this.dropExprience.ItemTopMargin = 3;
            this.dropExprience.Location = new System.Drawing.Point(644, 38);
            this.dropExprience.Name = "dropExprience";
            this.dropExprience.Size = new System.Drawing.Size(109, 32);
            this.dropExprience.TabIndex = 5;
            this.dropExprience.Text = "Experience years";
            this.dropExprience.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropExprience.TextLeftMargin = 5;
            // 
            // dropRate
            // 
            this.dropRate.BackColor = System.Drawing.Color.Transparent;
            this.dropRate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dropRate.BorderColor = System.Drawing.Color.Silver;
            this.dropRate.BorderRadius = 17;
            this.dropRate.Color = System.Drawing.Color.Silver;
            this.dropRate.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropRate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropRate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropRate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropRate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropRate.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropRate.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropRate.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropRate.FillDropDown = true;
            this.dropRate.FillIndicator = false;
            this.dropRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropRate.ForeColor = System.Drawing.Color.Black;
            this.dropRate.FormattingEnabled = true;
            this.dropRate.Icon = null;
            this.dropRate.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropRate.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropRate.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropRate.ItemBackColor = System.Drawing.Color.White;
            this.dropRate.ItemBorderColor = System.Drawing.Color.White;
            this.dropRate.ItemForeColor = System.Drawing.Color.Black;
            this.dropRate.ItemHeight = 26;
            this.dropRate.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropRate.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropRate.Items.AddRange(new object[] {
            "Highest"});
            this.dropRate.ItemTopMargin = 3;
            this.dropRate.Location = new System.Drawing.Point(781, 39);
            this.dropRate.Name = "dropRate";
            this.dropRate.Size = new System.Drawing.Size(109, 32);
            this.dropRate.TabIndex = 7;
            this.dropRate.Text = "Rate";
            this.dropRate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropRate.TextLeftMargin = 5;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(223)))), ((int)(((byte)(212)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 93);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(980, 14);
            this.bunifuSeparator1.TabIndex = 11;
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = false;
            this.tbSearch.AcceptsTab = false;
            this.tbSearch.AnimationSpeed = 200;
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 20;
            this.tbSearch.BorderThickness = 3;
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbSearch.DefaultText = "";
            this.tbSearch.FillColor = System.Drawing.Color.White;
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.tbSearch.HideSelection = true;
            this.tbSearch.IconLeft = global::WPFinalPlease.Properties.Resources.icons8_search_480px;
            this.tbSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.IconPadding = 10;
            this.tbSearch.IconRight = null;
            this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(12, 26);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Modified = false;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnIdleState = stateProperties4;
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.tbSearch.PlaceholderText = "Enter text";
            this.tbSearch.ReadOnly = false;
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(328, 45);
            this.tbSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextMarginBottom = 0;
            this.tbSearch.TextMarginLeft = 3;
            this.tbSearch.TextMarginTop = 0;
            this.tbSearch.TextPlaceholder = "Enter text";
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(124)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 25;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleBorderRadius = 40;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(124)))));
            this.btnSearch.IdleIconLeftImage = global::WPFinalPlease.Properties.Resources.icons8_search_480px_1;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(907, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.OnDisabledState.BorderRadius = 40;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.BorderRadius = 40;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.OnIdleState.BorderRadius = 40;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(124)))));
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = global::WPFinalPlease.Properties.Resources.icons8_search_480px_1;
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.BorderRadius = 40;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(57, 42);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            // 
            // checkBRate
            // 
            this.checkBRate.AllowBindingControlAnimation = true;
            this.checkBRate.AllowBindingControlColorChanges = false;
            this.checkBRate.AllowBindingControlLocation = true;
            this.checkBRate.AllowCheckBoxAnimation = false;
            this.checkBRate.AllowCheckmarkAnimation = true;
            this.checkBRate.AllowOnHoverStates = true;
            this.checkBRate.AutoCheck = true;
            this.checkBRate.BackColor = System.Drawing.Color.Transparent;
            this.checkBRate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBRate.BackgroundImage")));
            this.checkBRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBRate.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBRate.BorderRadius = 12;
            this.checkBRate.Checked = true;
            this.checkBRate.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBRate.CustomCheckmarkImage = null;
            this.checkBRate.Location = new System.Drawing.Point(762, 44);
            this.checkBRate.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBRate.Name = "checkBRate";
            this.checkBRate.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkBRate.OnCheck.BorderRadius = 12;
            this.checkBRate.OnCheck.BorderThickness = 2;
            this.checkBRate.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkBRate.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBRate.OnCheck.CheckmarkThickness = 2;
            this.checkBRate.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBRate.OnDisable.BorderRadius = 12;
            this.checkBRate.OnDisable.BorderThickness = 2;
            this.checkBRate.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBRate.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBRate.OnDisable.CheckmarkThickness = 2;
            this.checkBRate.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBRate.OnHoverChecked.BorderRadius = 12;
            this.checkBRate.OnHoverChecked.BorderThickness = 2;
            this.checkBRate.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBRate.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBRate.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBRate.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBRate.OnHoverUnchecked.BorderRadius = 12;
            this.checkBRate.OnHoverUnchecked.BorderThickness = 1;
            this.checkBRate.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBRate.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBRate.OnUncheck.BorderRadius = 12;
            this.checkBRate.OnUncheck.BorderThickness = 1;
            this.checkBRate.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBRate.Size = new System.Drawing.Size(21, 21);
            this.checkBRate.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBRate.TabIndex = 8;
            this.checkBRate.ThreeState = false;
            this.checkBRate.ToolTipText = null;
            // 
            // checkBExperience
            // 
            this.checkBExperience.AllowBindingControlAnimation = true;
            this.checkBExperience.AllowBindingControlColorChanges = false;
            this.checkBExperience.AllowBindingControlLocation = true;
            this.checkBExperience.AllowCheckBoxAnimation = false;
            this.checkBExperience.AllowCheckmarkAnimation = true;
            this.checkBExperience.AllowOnHoverStates = true;
            this.checkBExperience.AutoCheck = true;
            this.checkBExperience.BackColor = System.Drawing.Color.Transparent;
            this.checkBExperience.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBExperience.BackgroundImage")));
            this.checkBExperience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBExperience.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBExperience.BorderRadius = 12;
            this.checkBExperience.Checked = true;
            this.checkBExperience.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBExperience.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBExperience.CustomCheckmarkImage = null;
            this.checkBExperience.Location = new System.Drawing.Point(625, 43);
            this.checkBExperience.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBExperience.Name = "checkBExperience";
            this.checkBExperience.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkBExperience.OnCheck.BorderRadius = 12;
            this.checkBExperience.OnCheck.BorderThickness = 2;
            this.checkBExperience.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkBExperience.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBExperience.OnCheck.CheckmarkThickness = 2;
            this.checkBExperience.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBExperience.OnDisable.BorderRadius = 12;
            this.checkBExperience.OnDisable.BorderThickness = 2;
            this.checkBExperience.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBExperience.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBExperience.OnDisable.CheckmarkThickness = 2;
            this.checkBExperience.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBExperience.OnHoverChecked.BorderRadius = 12;
            this.checkBExperience.OnHoverChecked.BorderThickness = 2;
            this.checkBExperience.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBExperience.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBExperience.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBExperience.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBExperience.OnHoverUnchecked.BorderRadius = 12;
            this.checkBExperience.OnHoverUnchecked.BorderThickness = 1;
            this.checkBExperience.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBExperience.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBExperience.OnUncheck.BorderRadius = 12;
            this.checkBExperience.OnUncheck.BorderThickness = 1;
            this.checkBExperience.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBExperience.Size = new System.Drawing.Size(21, 21);
            this.checkBExperience.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBExperience.TabIndex = 6;
            this.checkBExperience.ThreeState = false;
            this.checkBExperience.ToolTipText = null;
            // 
            // checkBPrice
            // 
            this.checkBPrice.AllowBindingControlAnimation = true;
            this.checkBPrice.AllowBindingControlColorChanges = false;
            this.checkBPrice.AllowBindingControlLocation = true;
            this.checkBPrice.AllowCheckBoxAnimation = false;
            this.checkBPrice.AllowCheckmarkAnimation = true;
            this.checkBPrice.AllowOnHoverStates = true;
            this.checkBPrice.AutoCheck = true;
            this.checkBPrice.BackColor = System.Drawing.Color.Transparent;
            this.checkBPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBPrice.BackgroundImage")));
            this.checkBPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBPrice.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBPrice.BorderRadius = 12;
            this.checkBPrice.Checked = true;
            this.checkBPrice.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBPrice.CustomCheckmarkImage = null;
            this.checkBPrice.Location = new System.Drawing.Point(493, 42);
            this.checkBPrice.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBPrice.Name = "checkBPrice";
            this.checkBPrice.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkBPrice.OnCheck.BorderRadius = 12;
            this.checkBPrice.OnCheck.BorderThickness = 2;
            this.checkBPrice.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkBPrice.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBPrice.OnCheck.CheckmarkThickness = 2;
            this.checkBPrice.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBPrice.OnDisable.BorderRadius = 12;
            this.checkBPrice.OnDisable.BorderThickness = 2;
            this.checkBPrice.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBPrice.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBPrice.OnDisable.CheckmarkThickness = 2;
            this.checkBPrice.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBPrice.OnHoverChecked.BorderRadius = 12;
            this.checkBPrice.OnHoverChecked.BorderThickness = 2;
            this.checkBPrice.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBPrice.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBPrice.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBPrice.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBPrice.OnHoverUnchecked.BorderRadius = 12;
            this.checkBPrice.OnHoverUnchecked.BorderThickness = 1;
            this.checkBPrice.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBPrice.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBPrice.OnUncheck.BorderRadius = 12;
            this.checkBPrice.OnUncheck.BorderThickness = 1;
            this.checkBPrice.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBPrice.Size = new System.Drawing.Size(21, 21);
            this.checkBPrice.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBPrice.TabIndex = 4;
            this.checkBPrice.ThreeState = false;
            this.checkBPrice.ToolTipText = null;
            // 
            // checkBOccupation
            // 
            this.checkBOccupation.AllowBindingControlAnimation = true;
            this.checkBOccupation.AllowBindingControlColorChanges = false;
            this.checkBOccupation.AllowBindingControlLocation = true;
            this.checkBOccupation.AllowCheckBoxAnimation = false;
            this.checkBOccupation.AllowCheckmarkAnimation = true;
            this.checkBOccupation.AllowOnHoverStates = true;
            this.checkBOccupation.AutoCheck = true;
            this.checkBOccupation.BackColor = System.Drawing.Color.Transparent;
            this.checkBOccupation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBOccupation.BackgroundImage")));
            this.checkBOccupation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBOccupation.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBOccupation.BorderRadius = 12;
            this.checkBOccupation.Checked = true;
            this.checkBOccupation.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBOccupation.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBOccupation.CustomCheckmarkImage = null;
            this.checkBOccupation.Location = new System.Drawing.Point(359, 41);
            this.checkBOccupation.MinimumSize = new System.Drawing.Size(17, 17);
            this.checkBOccupation.Name = "checkBOccupation";
            this.checkBOccupation.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.checkBOccupation.OnCheck.BorderRadius = 12;
            this.checkBOccupation.OnCheck.BorderThickness = 2;
            this.checkBOccupation.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.checkBOccupation.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBOccupation.OnCheck.CheckmarkThickness = 2;
            this.checkBOccupation.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBOccupation.OnDisable.BorderRadius = 12;
            this.checkBOccupation.OnDisable.BorderThickness = 2;
            this.checkBOccupation.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBOccupation.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBOccupation.OnDisable.CheckmarkThickness = 2;
            this.checkBOccupation.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBOccupation.OnHoverChecked.BorderRadius = 12;
            this.checkBOccupation.OnHoverChecked.BorderThickness = 2;
            this.checkBOccupation.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBOccupation.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBOccupation.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBOccupation.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBOccupation.OnHoverUnchecked.BorderRadius = 12;
            this.checkBOccupation.OnHoverUnchecked.BorderThickness = 1;
            this.checkBOccupation.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBOccupation.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBOccupation.OnUncheck.BorderRadius = 12;
            this.checkBOccupation.OnUncheck.BorderThickness = 1;
            this.checkBOccupation.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBOccupation.Size = new System.Drawing.Size(21, 21);
            this.checkBOccupation.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBOccupation.TabIndex = 2;
            this.checkBOccupation.ThreeState = false;
            this.checkBOccupation.ToolTipText = null;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(3, 104);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(961, 675);
            this.flowPanel.TabIndex = 5;
            // 
            // ucWorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.checkBRate);
            this.Controls.Add(this.dropRate);
            this.Controls.Add(this.checkBExperience);
            this.Controls.Add(this.dropExprience);
            this.Controls.Add(this.checkBPrice);
            this.Controls.Add(this.dropPrice);
            this.Controls.Add(this.checkBOccupation);
            this.Controls.Add(this.dropOccupation);
            this.Name = "ucWorkerList";
            this.Size = new System.Drawing.Size(980, 800);
            this.Load += new System.EventHandler(this.ucWorkerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuDropdown dropOccupation;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBOccupation;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBPrice;
        private Bunifu.UI.WinForms.BunifuDropdown dropPrice;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBExperience;
        private Bunifu.UI.WinForms.BunifuDropdown dropExprience;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBRate;
        private Bunifu.UI.WinForms.BunifuDropdown dropRate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearch;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
