namespace WPFinalPlease
{
    partial class ucSmallNoti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSmallNoti));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxAvatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnName = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(30, 21);
            this.lblMessage.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(382, 32);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Hello there, I want to (Take this job)/ (Recruit You). Would you like to discuss " +
    "with me?";
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 35;
            this.bunifuShadowPanel1.BorderThickness = 0;
            this.bunifuShadowPanel1.Controls.Add(this.lblMessage);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(120, 10);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.RoyalBlue;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.RoyalBlue;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 0;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(435, 75);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.AllowFocused = false;
            this.pBoxAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBoxAvatar.AutoSizeHeight = true;
            this.pBoxAvatar.BorderRadius = 30;
            this.pBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxAvatar.Image")));
            this.pBoxAvatar.IsCircle = true;
            this.pBoxAvatar.Location = new System.Drawing.Point(38, 3);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(61, 61);
            this.pBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAvatar.TabIndex = 13;
            this.pBoxAvatar.TabStop = false;
            this.pBoxAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnName
            // 
            this.btnName.AllowAnimations = true;
            this.btnName.AllowMouseEffects = true;
            this.btnName.AllowToggling = false;
            this.btnName.AnimationSpeed = 200;
            this.btnName.AutoGenerateColors = false;
            this.btnName.AutoRoundBorders = false;
            this.btnName.AutoSizeLeftIcon = true;
            this.btnName.AutoSizeRightIcon = true;
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnName.BackgroundImage")));
            this.btnName.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnName.ButtonText = "Name";
            this.btnName.ButtonTextMarginLeft = 0;
            this.btnName.ColorContrastOnClick = 45;
            this.btnName.ColorContrastOnHover = 45;
            this.btnName.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnName.CustomizableEdges = borderEdges1;
            this.btnName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnName.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnName.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnName.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnName.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnName.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnName.IconMarginLeft = 11;
            this.btnName.IconPadding = 10;
            this.btnName.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnName.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnName.IconSize = 25;
            this.btnName.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnName.IdleBorderRadius = 30;
            this.btnName.IdleBorderThickness = 1;
            this.btnName.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnName.IdleIconLeftImage = null;
            this.btnName.IdleIconRightImage = null;
            this.btnName.IndicateFocus = false;
            this.btnName.Location = new System.Drawing.Point(18, 63);
            this.btnName.Name = "btnName";
            this.btnName.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnName.OnDisabledState.BorderRadius = 30;
            this.btnName.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnName.OnDisabledState.BorderThickness = 1;
            this.btnName.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnName.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnName.OnDisabledState.IconLeftImage = null;
            this.btnName.OnDisabledState.IconRightImage = null;
            this.btnName.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnName.onHoverState.BorderRadius = 30;
            this.btnName.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnName.onHoverState.BorderThickness = 1;
            this.btnName.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnName.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnName.onHoverState.IconLeftImage = null;
            this.btnName.onHoverState.IconRightImage = null;
            this.btnName.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnName.OnIdleState.BorderRadius = 30;
            this.btnName.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnName.OnIdleState.BorderThickness = 1;
            this.btnName.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnName.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnName.OnIdleState.IconLeftImage = null;
            this.btnName.OnIdleState.IconRightImage = null;
            this.btnName.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnName.OnPressedState.BorderRadius = 30;
            this.btnName.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnName.OnPressedState.BorderThickness = 1;
            this.btnName.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnName.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnName.OnPressedState.IconLeftImage = null;
            this.btnName.OnPressedState.IconRightImage = null;
            this.btnName.Size = new System.Drawing.Size(102, 39);
            this.btnName.TabIndex = 14;
            this.btnName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnName.TextMarginLeft = 0;
            this.btnName.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnName.UseDefaultRadiusAndThickness = true;
            // 
            // ucSmallNoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBoxAvatar);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "ucSmallNoti";
            this.Size = new System.Drawing.Size(570, 105);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        public System.Windows.Forms.Label lblMessage;
        public Bunifu.UI.WinForms.BunifuPictureBox pBoxAvatar;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnName;
    }
}
