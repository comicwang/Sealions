using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealion.Model
{
    public sealed class ProjectInfo : ModelBase
    {
        public string prjSystem { get; set; }

        public string Publisher { get; set; }

        public string Version { get; set; }

        public DateTime PublishDate { get; set; }

        public override ModelType ModelType { get { return ModelType.prj; } }

        public override string VirturePath { get { return base.Name; } }
    }
}
