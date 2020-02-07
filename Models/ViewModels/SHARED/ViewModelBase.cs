using System;

namespace eLearningService.Models.ViewModels.SHARED
{
    public class ViewModelBase
    {        
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