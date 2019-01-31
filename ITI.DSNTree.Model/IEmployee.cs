using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	/// <summary>
	/// IDsnData contient plusieurs IEmployees
	/// </summary>
	public interface IEmployee
	{
		/// <summary>
		/// Les clés pour trouver Nir, LastName,  FirstName, Matricule
		/// dans data1.txt, data2.txt
		/// sont respectivement S30.G01.00.001, S30.G01.00.002, S30.G01.00.003, S30.G01.00.019
		/// </summary>
		string Nir { get; }
		string LastName { get; }
		string FirstName { get; }
		string Matricule { get; }

		/// <summary>
		/// La clé pour trouver EmployeeDataBlock
		/// dans data1.txt, data2.txt
		/// est S30.G01.00
		/// </summary>
		IDataBlock EmployeeDataBlock { get; }
		/// <summary>
		/// Un IEmployee effectue plusieurs périodes d'activités
		/// </summary>
		List<IActivityPeriod> ActivityPeriods { get; }
	}
}
