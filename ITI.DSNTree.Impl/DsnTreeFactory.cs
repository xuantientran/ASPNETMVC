using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	public class DsnTreeFactory
	{
		//path est le chemin au fichier de l'arbre dsnTree1.txt ou dsnTree2.txt
		public static IDsnTree LoadTree(string path)
		{
			throw new NotImplementedException();
		}

		//dataPath est chemin au fichier de données data1.txt ou data2.txt
		public static IDataTree LoadDataTree(IDsnTree dsnTree, string dataPath)
		{
			throw new NotImplementedException();
		}

		public static IDsnData LoadData(IDataTree dataTree)
		{
			throw new NotImplementedException();
		}
	}
}
