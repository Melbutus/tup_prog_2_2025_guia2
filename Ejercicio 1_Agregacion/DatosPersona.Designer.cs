namespace Ejercicio_1_Agregacion
{
    partial class DatosPersona
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.tbx_dni = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.btn_cancelar_datos_persona = new System.Windows.Forms.Button();
            this.btn_aceptar_datos_persona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(52, 31);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(52, 71);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // tbx_dni
            // 
            this.tbx_dni.Location = new System.Drawing.Point(122, 28);
            this.tbx_dni.Name = "tbx_dni";
            this.tbx_dni.Size = new System.Drawing.Size(136, 20);
            this.tbx_dni.TabIndex = 2;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(122, 68);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(136, 20);
            this.tbx_nombre.TabIndex = 3;
            // 
            // btn_cancelar_datos_persona
            // 
            this.btn_cancelar_datos_persona.Location = new System.Drawing.Point(225, 115);
            this.btn_cancelar_datos_persona.Name = "btn_cancelar_datos_persona";
            this.btn_cancelar_datos_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_datos_persona.TabIndex = 4;
            this.btn_cancelar_datos_persona.Text = "Cancelar";
            this.btn_cancelar_datos_persona.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar_datos_persona
            // 
            this.btn_aceptar_datos_persona.Location = new System.Drawing.Point(68, 115);
            this.btn_aceptar_datos_persona.Name = "btn_aceptar_datos_persona";
            this.btn_aceptar_datos_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_datos_persona.TabIndex = 5;
            this.btn_aceptar_datos_persona.Text = "Aceptar";
            this.btn_aceptar_datos_persona.UseVisualStyleBackColor = true;
            // 
            // DatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 165);
            this.Controls.Add(this.btn_aceptar_datos_persona);
            this.Controls.Add(this.btn_cancelar_datos_persona);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.tbx_dni);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_dni);
            this.Name = "DatosPersona";
            this.Text = "DatosPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox tbx_dni;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Button btn_cancelar_datos_persona;
        private System.Windows.Forms.Button btn_aceptar_datos_persona;
    }
}