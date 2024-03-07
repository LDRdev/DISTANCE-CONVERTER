namespace Conversor_de_Km_e_milhas
{
    partial class lbConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbConversor));
            label1 = new Label();
            lbDigiteValor = new Label();
            txtValor = new TextBox();
            txtValorConvertido = new TextBox();
            lbValorConvertido = new Label();
            rbK = new RadioButton();
            rbM = new RadioButton();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkCyan;
            label1.Name = "label1";
            // 
            // lbDigiteValor
            // 
            resources.ApplyResources(lbDigiteValor, "lbDigiteValor");
            lbDigiteValor.Name = "lbDigiteValor";
            // 
            // txtValor
            // 
            resources.ApplyResources(txtValor, "txtValor");
            txtValor.BackColor = Color.White;
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Name = "txtValor";
            // 
            // txtValorConvertido
            // 
            resources.ApplyResources(txtValorConvertido, "txtValorConvertido");
            txtValorConvertido.BackColor = Color.White;
            txtValorConvertido.BorderStyle = BorderStyle.None;
            txtValorConvertido.Name = "txtValorConvertido";
            txtValorConvertido.TextChanged += txtValorConvertido_TextChanged;
            // 
            // lbValorConvertido
            // 
            resources.ApplyResources(lbValorConvertido, "lbValorConvertido");
            lbValorConvertido.Name = "lbValorConvertido";
            // 
            // rbK
            // 
            resources.ApplyResources(rbK, "rbK");
            rbK.Name = "rbK";
            rbK.TabStop = true;
            rbK.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            resources.ApplyResources(rbM, "rbM");
            rbM.Name = "rbM";
            rbM.TabStop = true;
            rbM.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            resources.ApplyResources(btnConverter, "btnConverter");
            btnConverter.BackColor = SystemColors.ControlText;
            btnConverter.Cursor = Cursors.Hand;
            btnConverter.ForeColor = SystemColors.ButtonFace;
            btnConverter.Name = "btnConverter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // lbConversor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            Controls.Add(btnConverter);
            Controls.Add(rbM);
            Controls.Add(rbK);
            Controls.Add(lbValorConvertido);
            Controls.Add(txtValorConvertido);
            Controls.Add(txtValor);
            Controls.Add(lbDigiteValor);
            Controls.Add(label1);
            Name = "lbConversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbDigiteValor;
        private TextBox txtValor;
        private TextBox txtValorConvertido;
        private Label lbValorConvertido;
        private RadioButton rbK;
        private RadioButton rbM;
        private Button btnConverter;
    }
}