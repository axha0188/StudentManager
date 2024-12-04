using StudentManager.DataAccess.Connection;
using StudentManager.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManager.Presentation.Student
{
    public partial class StudentForm : Form
    {
        private AppDbContext? dbContext;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void LoadInitial() 
        {
            var data = this.dbContext.Students.ToList();

            DgvStudentsList.DataSource = data;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new AppDbContext();

            this.dbContext.Database.EnsureCreated();

            var data = this.dbContext.Students.ToList();

            DgvStudentsList.DataSource = data;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "Editar";
            editButton.Text = "Editar";
            editButton.UseColumnTextForButtonValue = true;
            DgvStudentsList.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Eliminar";
            deleteButton.Text = "Eliminar";
            deleteButton.UseColumnTextForButtonValue = true;
            DgvStudentsList.Columns.Add(deleteButton);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = TxtFullName.Text;
                DateTime dateOfBirth = DtpDateOfBirth.Value;
                string email = TxtEmail.Text;

                if (string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Los nombre completos son requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtFullName.Focus();

                    return;
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("El correo es requerido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtEmail.Focus();

                    return;
                }

                var data = new StudentModel
                {
                    FullName = fullName,
                    DateOfBirth = dateOfBirth,
                    Email = email
                };

                this.dbContext.Add(data);
                this.dbContext.SaveChanges();

                MessageBox.Show("Estudiante Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.Clear();
                TxtFullName.Clear();
                LoadInitial();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al momento de guardar Estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvStudentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no sea el encabezado
            {
                if (DgvStudentsList.Columns[e.ColumnIndex].Name == "Edit")
                {
                    try
                    {
                        var selectedRow = DgvStudentsList.Rows[e.RowIndex];
                        string id = selectedRow.Cells["Id"].Value.ToString();
                        string fullName = selectedRow.Cells["FullName"].Value.ToString();
                        DateTime dateOfBirth = DateTime.Parse(selectedRow.Cells["DateOfBirth"].Value.ToString());
                        string email = selectedRow.Cells["Email"].Value.ToString();

                        var record = dbContext.Students.FirstOrDefault(x => x.Id == int.Parse(id));

                        if (record != null)
                        {
                            //Modificamos el tipo de telefono, podriamos modificar cualquier campo...
                            record.FullName = fullName;
                            record.DateOfBirth = dateOfBirth;
                            record.Email = email;

                            // Guardamos los cambios en la BD
                            dbContext.SaveChanges();
                            MessageBox.Show("Estudiante editado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // No se encontro en la BD
                        }
;
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Error al momento de editar Estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (DgvStudentsList.Columns[e.ColumnIndex].Name == "Delete")
                {
                    try
                    {
                        var selectedRow = DgvStudentsList.Rows[e.RowIndex];
                        string id = selectedRow.Cells["Id"].Value.ToString();

                        var record = dbContext.Students.FirstOrDefault(x => x.Id == int.Parse(id));

                        if (record != null)
                        {
                            // Guardamos los cambios en la BD
                            dbContext.Students.Remove(record);
                            dbContext.SaveChanges();
                            MessageBox.Show("Estudiante Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // No se encontro en la BD
                        }

                        LoadInitial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al momento de eliminar Estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
