using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealion.Model
{
	/*===================================================
	 * 类名称: ModelSimple
	 * 类描述:
	 * 创建人: wangchong
	 * 创建时间: 2020/12/25 17:50:54
	 * 修改人:
	 * 修改时间:
	 * 版本： @version 1.0
	 =====================================================*/
	public class ModelSimple : ModelBase
	{
		public override string VirturePath { get { return string.Empty; } }

		public override ModelType ModelType { get { return ModelType.prj; } }

		private static ModelSimple simple = new ModelSimple();

		public static ModelSimple Instance { get { return simple; } }
	}
}
