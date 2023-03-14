namespace Comparar
{
    partial class CargarPool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelect = new Button();
            btnLoad = new Button();
            btnexecute = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(197, 47);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(285, 63);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Selecciona Pool";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(197, 139);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(285, 59);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Inicar Carga pool";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnexecute
            // 
            btnexecute.Location = new Point(197, 232);
            btnexecute.Name = "btnexecute";
            btnexecute.Size = new Size(285, 60);
            btnexecute.TabIndex = 2;
            btnexecute.Text = "Inica comparacion";
            btnexecute.UseVisualStyleBackColor = true;
            btnexecute.Click += btnexecute_Click;
            // 
            // button1
            // 
            button1.Location = new Point(641, 394);
            button1.Name = "button1";
            button1.Size = new Size(147, 44);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CargarPool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnexecute);
            Controls.Add(btnLoad);
            Controls.Add(btnSelect);
            Name = "CargarPool";
            Text = "Compara Archivos";
            Load += CargarPool_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnLoad;
        private Button btnexecute;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}