using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	/// <summary>
	/// Un IDataBlock a plusieurs IDataLeaf
	/// </summary>
	public interface IDataLeaf
	{
		/// <summary>
		/// Dictionaire qui a des couple clé, valeur
		/// par exemple S30.G01.00.008.001,'Paris'
		/// </summary>
		Dictionary<string, string> Data { set; get; }
		/// <summary>
		/// La IDataLeaf appartient toujours à un IDataBlock
		/// </summary>
		IDataBlock Block { set; get; }
	}
}