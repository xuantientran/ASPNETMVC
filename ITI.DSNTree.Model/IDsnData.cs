using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	/// <summary>
	/// IDsnData est un conteneur qui encapsule
	/// les IEmployees et les IEstablishments
	/// IDsnData exploite le DataTree pour créer:
	/// - IEmployees identifiés par la combinaison de Matricule + "-" + Nir
	/// - IEstablishments identifiés par Nic
	/// </summary>
	public interface IDsnData
	{
		IDataTree DataTree { get; }
		Dictionary<string, IEmployee> Employees { get; }
		Dictionary<string, IEstablishment> Establishments { get; }
	}
}
