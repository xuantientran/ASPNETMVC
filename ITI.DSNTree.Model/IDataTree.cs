using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	public interface IDataTree
	{
		IDataBlock Root { set; get; }
		int Count { get; }
		/// <summary>
		/// On a besoin le DsnTree pour:
		/// - construire le IDataTree
		/// - trouver les données dans le IDataTree
		/// en référenciant les éléments du DsnTree
		/// </summary>
		IDsnTree DsnTree { get; }
		/// <summary>
		/// Recherche les IDataBlocks qui a le id
		/// à partir de block
		/// ou à partir de la racine si ce block est null
		/// </summary>
		/// <param name="id">Exemple S30.G01.00</param>
		/// <param name="block">Exemple un block avec l'id S20.G01.00</param>
		/// <returns></returns>
		List<IDataBlock> FindBlock(string id, IDataBlock block = null);
	}
}