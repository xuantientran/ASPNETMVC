using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	/// <summary>
	/// IDsnData contient plusieurs IEstablishments
	/// </summary>
	public interface IEstablishment
	{
		/// <summary>
		/// Les clés pour trouver Nic, Enseigne
		/// dans data1.txt, data2.txt
		/// sont respectivement S80.G01.00.001.002, S80.G01.00.002
		/// </summary>
		string Nic { get; }
		string Enseigne { get; }
		/// <summary>
		/// La clé pour trouver EstablishmentBlock
		/// dans data1.txt, data2.txt
		/// est S80.G01.00
		/// </summary>
		IDataBlock EstablishmentBlock { get; }
	}
}
