namespace DgNotification.Presentation
{
    partial class FormMainPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPanel));
            pnlSideMenu = new Panel();
            cbtnConfiguraciones = new DgNotification.Shared.CustomControls.CustomButton();
            cLblNotificaciones = new DgNotification.Shared.CustomControls.CustomRoundLabel();
            cbtnReportes = new DgNotification.Shared.CustomControls.CustomButton();
            cbtnClientes = new DgNotification.Shared.CustomControls.CustomButton();
            cbtnNotificaciones = new DgNotification.Shared.CustomControls.CustomButton();
            cbtnDashboard = new DgNotification.Shared.CustomControls.CustomButton();
            pnlLogo = new Panel();
            pnlSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.White;
            pnlSideMenu.Controls.Add(cbtnConfiguraciones);
            pnlSideMenu.Controls.Add(cLblNotificaciones);
            pnlSideMenu.Controls.Add(cbtnReportes);
            pnlSideMenu.Controls.Add(cbtnClientes);
            pnlSideMenu.Controls.Add(cbtnNotificaciones);
            pnlSideMenu.Controls.Add(cbtnDashboard);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.ForeColor = SystemColors.Control;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(250, 1279);
            pnlSideMenu.TabIndex = 0;
            // 
            // cbtnConfiguraciones
            // 
            cbtnConfiguraciones.BackColor = Color.FromArgb(250, 250, 250);
            cbtnConfiguraciones.BackgroundColor = Color.FromArgb(250, 250, 250);
            cbtnConfiguraciones.BorderColor = Color.PaleVioletRed;
            cbtnConfiguraciones.BorderRadius = 0;
            cbtnConfiguraciones.BorderSize = 0;
            cbtnConfiguraciones.Dock = DockStyle.Top;
            cbtnConfiguraciones.FlatAppearance.BorderSize = 0;
            cbtnConfiguraciones.FlatStyle = FlatStyle.Flat;
            cbtnConfiguraciones.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cbtnConfiguraciones.ForeColor = Color.DimGray;
            cbtnConfiguraciones.Image = Properties.Resources.calendarDark;
            cbtnConfiguraciones.ImageAlign = ContentAlignment.MiddleLeft;
            cbtnConfiguraciones.Location = new Point(0, 210);
            cbtnConfiguraciones.Name = "cbtnConfiguraciones";
            cbtnConfiguraciones.Size = new Size(250, 40);
            cbtnConfiguraciones.TabIndex = 5;
            cbtnConfiguraciones.Text = "     Configuraciones";
            cbtnConfiguraciones.TextAlign = ContentAlignment.MiddleLeft;
            cbtnConfiguraciones.TextColor = Color.DimGray;
            cbtnConfiguraciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbtnConfiguraciones.UseVisualStyleBackColor = false;
            // 
            // cLblNotificaciones
            // 
            cLblNotificaciones.Font = new Font("Inter Black", 500F, FontStyle.Bold);
            cLblNotificaciones.Location = new Point(206, 96);
            cLblNotificaciones.Name = "cLblNotificaciones";
            cLblNotificaciones.Size = new Size(30, 28);
            cLblNotificaciones.TabIndex = 1;
            cLblNotificaciones.Text = "5";
            // 
            // cbtnReportes
            // 
            cbtnReportes.BackColor = Color.FromArgb(250, 250, 250);
            cbtnReportes.BackgroundColor = Color.FromArgb(250, 250, 250);
            cbtnReportes.BorderColor = Color.PaleVioletRed;
            cbtnReportes.BorderRadius = 0;
            cbtnReportes.BorderSize = 0;
            cbtnReportes.Dock = DockStyle.Top;
            cbtnReportes.FlatAppearance.BorderSize = 0;
            cbtnReportes.FlatStyle = FlatStyle.Flat;
            cbtnReportes.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cbtnReportes.ForeColor = Color.DimGray;
            cbtnReportes.Image = Properties.Resources.calendarDark;
            cbtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            cbtnReportes.Location = new Point(0, 170);
            cbtnReportes.Name = "cbtnReportes";
            cbtnReportes.Size = new Size(250, 40);
            cbtnReportes.TabIndex = 4;
            cbtnReportes.Text = "     Reportes";
            cbtnReportes.TextAlign = ContentAlignment.MiddleLeft;
            cbtnReportes.TextColor = Color.DimGray;
            cbtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbtnReportes.UseVisualStyleBackColor = false;
            // 
            // cbtnClientes
            // 
            cbtnClientes.BackColor = Color.FromArgb(250, 250, 250);
            cbtnClientes.BackgroundColor = Color.FromArgb(250, 250, 250);
            cbtnClientes.BorderColor = Color.PaleVioletRed;
            cbtnClientes.BorderRadius = 0;
            cbtnClientes.BorderSize = 0;
            cbtnClientes.Dock = DockStyle.Top;
            cbtnClientes.FlatAppearance.BorderSize = 0;
            cbtnClientes.FlatStyle = FlatStyle.Flat;
            cbtnClientes.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cbtnClientes.ForeColor = Color.DimGray;
            cbtnClientes.Image = Properties.Resources.calendarDark;
            cbtnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            cbtnClientes.Location = new Point(0, 130);
            cbtnClientes.Name = "cbtnClientes";
            cbtnClientes.Size = new Size(250, 40);
            cbtnClientes.TabIndex = 3;
            cbtnClientes.Text = "     Clientes";
            cbtnClientes.TextAlign = ContentAlignment.MiddleLeft;
            cbtnClientes.TextColor = Color.DimGray;
            cbtnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbtnClientes.UseVisualStyleBackColor = false;
            // 
            // cbtnNotificaciones
            // 
            cbtnNotificaciones.BackColor = Color.FromArgb(250, 250, 250);
            cbtnNotificaciones.BackgroundColor = Color.FromArgb(250, 250, 250);
            cbtnNotificaciones.BorderColor = Color.PaleVioletRed;
            cbtnNotificaciones.BorderRadius = 0;
            cbtnNotificaciones.BorderSize = 0;
            cbtnNotificaciones.Dock = DockStyle.Top;
            cbtnNotificaciones.FlatAppearance.BorderSize = 0;
            cbtnNotificaciones.FlatStyle = FlatStyle.Flat;
            cbtnNotificaciones.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cbtnNotificaciones.ForeColor = Color.DimGray;
            cbtnNotificaciones.Image = Properties.Resources.calendarDark;
            cbtnNotificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            cbtnNotificaciones.Location = new Point(0, 90);
            cbtnNotificaciones.Name = "cbtnNotificaciones";
            cbtnNotificaciones.Size = new Size(250, 40);
            cbtnNotificaciones.TabIndex = 2;
            cbtnNotificaciones.Text = "     Notificaciones";
            cbtnNotificaciones.TextAlign = ContentAlignment.MiddleLeft;
            cbtnNotificaciones.TextColor = Color.DimGray;
            cbtnNotificaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbtnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // cbtnDashboard
            // 
            cbtnDashboard.BackColor = Color.FromArgb(250, 250, 250);
            cbtnDashboard.BackgroundColor = Color.FromArgb(250, 250, 250);
            cbtnDashboard.BorderColor = Color.PaleVioletRed;
            cbtnDashboard.BorderRadius = 0;
            cbtnDashboard.BorderSize = 0;
            cbtnDashboard.Dock = DockStyle.Top;
            cbtnDashboard.FlatAppearance.BorderSize = 0;
            cbtnDashboard.FlatStyle = FlatStyle.Flat;
            cbtnDashboard.Font = new Font("Inter Medium", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cbtnDashboard.ForeColor = Color.DimGray;
            cbtnDashboard.Image = (Image)resources.GetObject("cbtnDashboard.Image");
            cbtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            cbtnDashboard.Location = new Point(0, 50);
            cbtnDashboard.Name = "cbtnDashboard";
            cbtnDashboard.Size = new Size(250, 40);
            cbtnDashboard.TabIndex = 1;
            cbtnDashboard.Text = "     Dashboard";
            cbtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            cbtnDashboard.TextColor = Color.DimGray;
            cbtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbtnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 50);
            pnlLogo.TabIndex = 1;
            // 
            // FormMainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1279);
            Controls.Add(pnlSideMenu);
            Name = "FormMainPanel";
            Text = "FormMainPanel";
            pnlSideMenu.ResumeLayout(false);
            pnlSideMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlLogo;
        private Shared.CustomControls.CustomButton customButton5;
        private Shared.CustomControls.CustomButton customButton4;
        private Shared.CustomControls.CustomButton cbtnDashboard;
        private Shared.CustomControls.CustomRoundLabel cLblNotificaciones;
        private Shared.CustomControls.CustomButton cbtnReportes;
        private Shared.CustomControls.CustomButton cbtnClientes;
        private Shared.CustomControls.CustomButton cbtnNotificaciones;
        private Shared.CustomControls.CustomButton cbtnConfiguraciones;
    }
}