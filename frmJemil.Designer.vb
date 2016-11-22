<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJemil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMensaje
        '
        Me.btnMensaje.Location = New System.Drawing.Point(144, 123)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(112, 42)
        Me.btnMensaje.TabIndex = 0
        Me.btnMensaje.Text = "Mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'frmJemil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 295)
        Me.Controls.Add(Me.btnMensaje)
        Me.Name = "frmJemil"
        Me.Text = "Formulario de Jemil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMensaje As Button
End Class
