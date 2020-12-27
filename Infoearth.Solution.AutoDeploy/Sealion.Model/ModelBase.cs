using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealion.Model
{
    /*===================================================
	 * 类名称: ModelBase
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/25 15:47:47
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
    public abstract class ModelBase
    {
		public string Id { get; set; }

		public string Name { get; set; }

		public abstract string VirturePath { get; }

		public abstract ModelType ModelType { get; }
    }

	public enum ModelType
    {
		prj=1,
		pck=2,
		cnf=3
    }
}
