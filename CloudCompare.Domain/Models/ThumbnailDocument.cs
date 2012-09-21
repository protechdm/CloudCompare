using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region ThumbnailDocument
    public class ThumbnailDocument
    {
        public virtual int ThumbnailDocumentID { get; set; }
        public virtual string ThumbnailDocumentTitle { get; set; }
        public virtual string ThumbnailDocumentURL { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual ThumbnailDocumentType ThumbnailDocumentType { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
