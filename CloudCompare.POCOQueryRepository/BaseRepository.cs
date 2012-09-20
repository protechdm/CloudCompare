using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Castle.Core.Logging;

namespace CloudCompare.POCOQueryRepository
{
    public class BaseRepository
    {
        private readonly CloudCompareContext _requestLifeTimeContext;
        //private static readonly log4net.ILog Log =
        //    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ILogger Logger { get; set; }


        public BaseRepository(CloudCompareContext casesContext)
        {
            this._requestLifeTimeContext = casesContext;
        }

        public bool Update<T>(string userId, T model) where T : class
        {

            Logger.DebugFormat("Update({0}):{1}", userId, model.GetType());
            bool insertStatus = false;

            try
            {
                //db.Entry(model).State = EntityState.Modified;
                _requestLifeTimeContext.SaveChanges();
                insertStatus = true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return insertStatus;
        }
        public bool Insert<T>(string userId, T model) where T : class
        {
            Logger.DebugFormat("Insert({0}):{1}", userId, model.GetType());
            bool insertStatus = false;

            try
            {
                using (var db = new CloudCompareContext())
                {
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();
                    insertStatus = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return insertStatus;
        }

    }
}



