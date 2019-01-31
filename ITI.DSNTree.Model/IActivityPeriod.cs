using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	/// <summary>
	/// Chaque salarié effectue plusieurs période d'activités
	/// </summary>
	public interface IActivityPeriod
	{
		/// <summary>
		/// La clé pour trouver BeginDate dans les fichiers data1.txt et data2.txt
		/// est S40.G01.00.001
		/// </summary>
		string BeginDate { get; }
		/// <summary>
		/// La clé pour trouver le IDataBlock
		/// dans ces fichiers
		/// est S40.G01.00
		/// </summary>
		IDataBlock ActivityPeriodDataBlock { get; }
	}
}
