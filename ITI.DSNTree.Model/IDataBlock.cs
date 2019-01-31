using System;
using System.Collections.Generic;

namespace ITI.DSNTree
{
	/// <summary>
	/// C'est le noeud de l'arbre de données
	/// </summary>
	public interface IDataBlock
	{
		/// <summary>
		/// l'Id correspond à celui du noeud IDsnNode
		/// </summary>
		string Id { set; get; }
		IDataBlock Parent { set; get; }
		List<IDataBlock> Children { set; get; }
		/// <summary>
		/// IDataBlock contients plusieurs feuilles de données
		/// </summary>
		List<IDataLeaf> Leaves { set; get; }
	}
}