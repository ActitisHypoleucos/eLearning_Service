using System;
using System.Data;
using eLearningService.Models;

namespace eLearning_Service_MK1.Models.ViewModels
{
    public class MaterialiViewModel
    {
        public int IDMateriali { get; set; }
        public byte[] Materiale { get; set; }
        public string Estensione { get; set; }
        //public int IDLezione { get; set; }

        public static MaterialiViewModel FromDataRow(DataRow itemRow)
        {
            CLS_DB dibbi = new CLS_DB();
            try
            {
                var item = new MaterialiViewModel()
                {
                    IDMateriali = Convert.ToInt32(itemRow["Id_Materiale_PK"]),
                    Materiale = dibbi.getFileDB(Convert.ToInt32(itemRow["Id_Materiale_PK"])),
                    Estensione = Convert.ToString(itemRow["Tipo"])
                    //IDLezione = Convert.ToInt32(itemRow[""])
                };
            return item;
            }            
            catch (System.Exception)
            {
                return null;
            }            
        }
    }
}