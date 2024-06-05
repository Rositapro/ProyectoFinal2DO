using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Drawing;
using System.Diagnostics;


namespace ProyectoFinal2DO
{
    public partial class Form1 : Form
    {
        private string[,] matrixEmployees;
        public Form1()
        {
            InitializeComponent();
            ConfigureComboBox();
            ConfigureListView();
            AttachKeyPressEvents();
            Persona.ShowMessage();
            DateandTime();

            matrixEmployees = new string[0, 0];
        }

        private void ConfigureComboBox()
        {
            cmbTipoTrabajador.Items.Add("Engineer");
            cmbTipoTrabajador.Items.Add("Worker");
            cmbTipoTrabajador.SelectedIndex = 0;
        }

        private void ConfigureListView()
        {
            lvDatos.View = View.Details;
            lvDatos.Columns.Add("Name", 100);
            lvDatos.Columns.Add("Paternal last name", 100);
            lvDatos.Columns.Add("Maternal last name", 100);
            lvDatos.Columns.Add("CURP", 100);
            lvDatos.Columns.Add("Age", 50);
            lvDatos.Columns.Add("Workstation", 100);
            lvDatos.Columns.Add("Hours Worked", 100);
            lvDatos.Columns.Add("Salary", 100);
        }

        private void AttachKeyPressEvents()
        {
            txtName.KeyPress += TextBox_KeyPress;
            txtPaternal.KeyPress += TextBox_KeyPress;
            txtMaternal.KeyPress += TextBox_KeyPress;
            txtAge.KeyPress += NumericTextBox_KeyPress;
            txtHoursWorked.KeyPress += NumericTextBox_KeyPress;
        }
        //Metodo que recibe parametros pero no regresa nada
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool ValidateCURP(string curp)
        {
            string pattern = @"^[A-Z]{4}\d{6}[HM][A-Z]{6}\d{1}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(curp);
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPaternal.Text) ||
                string.IsNullOrWhiteSpace(txtMaternal.Text) ||
                string.IsNullOrWhiteSpace(txtCurp.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtHoursWorked.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("All fields must be completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateCURP(txtCurp.Text))
            {
                MessageBox.Show("The entered CURP is not valid. Please verify and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado empleado = new Empleado(txtName.Text, txtPaternal.Text, txtMaternal.Text, txtCurp.Text, int.Parse(txtAge.Text), int.Parse(txtHoursWorked.Text), cmbTipoTrabajador.SelectedItem.ToString());
            empleado.Salary = txtSalary.Text;

            MessageBox.Show(empleado.Saludate());

            string[] datos = new string[8];
            datos[0] = txtName.Text;
            datos[1] = txtPaternal.Text;
            datos[2] = txtMaternal.Text;
            datos[3] = txtCurp.Text;
            datos[4] = txtAge.Text;
            datos[5] = cmbTipoTrabajador.SelectedItem.ToString();
            datos[6] = txtHoursWorked.Text;
            datos[7] = txtSalary.Text;

            ListViewItem item = new ListViewItem(datos[0]);
            for (int i = 1; i < datos.Length; i++)
            {
                item.SubItems.Add(datos[i]);
            }

            lvDatos.Items.Add(item);

            ClearTextBoxesAndComboBox();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            try
            {
                int hoursWorked = Convert.ToInt32(txtHoursWorked.Text);
                string workstation = cmbTipoTrabajador.SelectedItem.ToString();

                // Crear un objeto Empleado con los datos actuales
                Empleado empleado = new Empleado(txtName.Text, txtPaternal.Text, txtMaternal.Text, txtCurp.Text, int.Parse(txtAge.Text), hoursWorked, workstation);

                // Obtener el salario calculado del objeto Empleado
                double salary = empleado.CalculatedSalary;

                // Mostrar el salario en el cuadro de texto
                txtSalary.Text = salary.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Enter valid number of hours worked.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ClearTextBoxesAndComboBox()
        {
            txtName.Clear();
            txtPaternal.Clear();
            txtMaternal.Clear();
            txtCurp.Clear();
            txtAge.Clear();
            txtHoursWorked.Clear();
            txtSalary.Clear();
            cmbTipoTrabajador.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtName.Clear();
            txtPaternal.Clear();
            txtMaternal.Clear();
            txtCurp.Clear();
            txtAge.Clear();
            txtHoursWorked.Clear();
            txtSalary.Clear();
            cmbTipoTrabajador.SelectedIndex = 0;
        }

        private void btnFillMatrix_Click(object sender, EventArgs e)
        {
            FillMatrixWithData();
            MessageBox.Show("Data loaded in the matrix.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowMatriz_Click(object sender, EventArgs e)
        {
            ShowDataMatriz();
        }

        private void FillMatrixWithData()
        {
            int filas = lvDatos.Items.Count;
            int columnas = lvDatos.Columns.Count;
            matrixEmployees = new string[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrixEmployees[i, j] = lvDatos.Items[i].SubItems[j].Text;
                }
            }
        }

        private void ShowDataMatriz()
        {
            if (matrixEmployees == null)
            {
                MessageBox.Show("No data in the matrix.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string datos = "";
            for (int i = 0; i < matrixEmployees.GetLength(0); i++)
            {
                for (int j = 0; j < matrixEmployees.GetLength(1); j++)
                {
                    datos += matrixEmployees[i, j] + " ";
                }
                datos += Environment.NewLine;
            }

            MessageBox.Show(datos, "Matrix Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Word|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Word.Document();
                    Word.Body body = new Word.Body();

                    Word.Table table = new Word.Table();

                    Word.TableRow headerRow = new Word.TableRow();
                    foreach (ColumnHeader column in lvDatos.Columns)
                    {
                        Word.TableCell headerCell = new Word.TableCell(new Word.Paragraph(new Word.Run(new Word.Text(column.Text))));
                        headerRow.Append(headerCell);
                    }
                    table.Append(headerRow);

                    // Crear una fila para cada elemento en el ListView
                    foreach (ListViewItem item in lvDatos.Items)
                    {
                        Word.TableRow dataRow = new Word.TableRow();
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            Word.TableCell dataCell = new Word.TableCell(new Word.Paragraph(new Word.Run(new Word.Text(subItem.Text))));
                            dataRow.Append(dataCell);
                        }
                        table.Append(dataRow);
                    }

                    // Agregar bordes a la tabla
                    table.AppendChild(new Word.TableProperties(
                        new Word.TableBorders(
                            new Word.TopBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 },
                            new Word.BottomBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 },
                            new Word.LeftBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 },
                            new Word.RightBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 },
                            new Word.InsideHorizontalBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 },
                            new Word.InsideVerticalBorder { Val = new EnumValue<Word.BorderValues>(Word.BorderValues.Single), Size = 6 }
                        )
                    ));

                    body.Append(table);
                    mainPart.Document.Append(body);
                    mainPart.Document.Save();

                    MessageBox.Show("Data successfully saved WORD file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
        }
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            // Guardar los datos en un archivo XML
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo XML|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Empleados");
                xmlDoc.AppendChild(root);

                foreach (ListViewItem item in lvDatos.Items)
                {
                    XmlElement empleadoElement = xmlDoc.CreateElement("Empleado");

                    for (int i = 0; i < lvDatos.Columns.Count; i++)
                    {
                        // Reemplazar espacios en blanco y otros caracteres no permitidos en los nombres de las columnas
                        string columnName = lvDatos.Columns[i].Text.Replace(" ", "_");

                        XmlElement element = xmlDoc.CreateElement(columnName);
                        element.InnerText = item.SubItems[i].Text;
                        empleadoElement.AppendChild(element);
                    }

                    root.AppendChild(empleadoElement);
                }

                xmlDoc.Save(filePath);
                MessageBox.Show("Data successfully saved to XML file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el archivo XML guardado con la aplicación predeterminada del sistema
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath("Archivo de Excel|*.xlsx");
            if (filePath != null)
            {
                try
                {
                   
                    using (SpreadsheetDocument spreadsheetDoc = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                    {
                        WorkbookPart workbookPart = spreadsheetDoc.AddWorkbookPart();
                        workbookPart.Workbook = new Workbook();

                        WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                        worksheetPart.Worksheet = new Worksheet(new SheetData());

                        Sheets sheets = spreadsheetDoc.WorkbookPart.Workbook.AppendChild(new Sheets());
                        Sheet sheet = new Sheet() { Id = spreadsheetDoc.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                        sheets.Append(sheet);

                        SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                        Row headerRow = new Row();
                        foreach (ColumnHeader column in lvDatos.Columns)
                        {
                            Cell cell = new Cell();
                            cell.DataType = CellValues.String;
                            cell.CellValue = new CellValue(column.Text);
                            headerRow.AppendChild(cell);
                        }
                        sheetData.AppendChild(headerRow);

                        // Escribir los datos en el resto de filas
                        foreach (ListViewItem item in lvDatos.Items)
                        {
                            Row row = new Row();
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                Cell cell = new Cell();
                                cell.DataType = CellValues.String;
                                cell.CellValue = new CellValue(subItem.Text);
                                row.AppendChild(cell);
                            }
                            sheetData.AppendChild(row);
                        }
                    }

                    MessageBox.Show("Data successfully saved to EXCEL file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el archivo Excel guardado con la aplicación predeterminada del sistema
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private string GetFilePath(string filter)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }
        private void btnSavetxt_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Texto|*.txt";

            string filePath = string.Empty; 

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                   
                    foreach (ColumnHeader column in lvDatos.Columns)
                    {
                        writer.Write(column.Text);
                        writer.Write(", ");
                    }
                    writer.WriteLine();

                    foreach (ListViewItem item in lvDatos.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            writer.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Data successfully saved to TXT file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            // Obtener la ruta de destino para guardar el archivo JSON
            string filePath = GetFilePath("Archivo JSON|*.json");
            if (filePath != null)
            {
                try
                {
                    // Crear una lista para almacenar los datos del ListView
                    List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();

                    // Recorrer los elementos del ListView y agregarlos a la lista
                    foreach (ListViewItem item in lvDatos.Items)
                    {
                        Dictionary<string, string> dataItem = new Dictionary<string, string>();
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            dataItem[lvDatos.Columns[item.SubItems.IndexOf(subItem)].Text] = subItem.Text;
                        }
                        dataList.Add(dataItem);
                    }

                    // Serializar la lista a formato JSON y guardarla en el archivo
                    string jsonData = JsonConvert.SerializeObject(dataList);
                    File.WriteAllText(filePath, jsonData);

                    MessageBox.Show("Data successfully saved to JSON file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to open the PDF file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Guardar los datos en un archivo PDF
        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            // Guardar los datos en un archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Crear una tabla PDF
                    PdfPTable table = new PdfPTable(lvDatos.Columns.Count);
                    table.WidthPercentage = 100;

                    // Añadir las cabeceras de la tabla
                    foreach (ColumnHeader column in lvDatos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    // Añadir las filas de datos
                    foreach (ListViewItem item in lvDatos.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            table.AddCell(new Phrase(subItem.Text));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Data successfully saved to PDF file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while trying to open the PDF file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Limpiar el contenido existente del TextBox
                        txtContent.Clear();

                        // Leer y mostrar cada línea del archivo en el TextBox
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            txtContent.AppendText(line + Environment.NewLine);
                        }
                    }
                    MessageBox.Show("Text file read correctly.", "Successful Reading", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveNewTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (File.Exists(filePath))
                {
                    DialogResult result = MessageBox.Show("The file already exists, do you want to overwrite it?", "Existing File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return; // Salir si el usuario no desea sobrescribir el archivo
                    }
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(txtContent.Text);
                    }
                    MessageBox.Show("Text file saved correctly.", "Successful Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving the file: {ex.Message}", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        // Método que no recibe parámetros ni regresa nada
        private void DateandTime()
        {
            MessageBox.Show("The date and time is " + DateTime.Now.ToString(), "Date and time", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
