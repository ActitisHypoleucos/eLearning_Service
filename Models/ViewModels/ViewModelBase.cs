using System;

namespace eLearningService.Models.ViewModels
{
    public class ViewModelBase
    {
        public int ID { get; set; }
        
        #region CheckFor DBNULL
        public object CheckDBNULL(object campo)
        {
                if (campo == DBNull.Value)
                {
                     return null;
                }
                else
                {
                    return campo;
                }
        }
        #endregion
    
    }
}