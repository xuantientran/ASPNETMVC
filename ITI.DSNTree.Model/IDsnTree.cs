using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.DSNTree
{
	public interface IDsnTree
	{
		/// <summary>
		/// Gets the total number of nodes.
		/// 
		/// En lisant le fichier dsnTree1.txt ou dsnTree2.txt,
		/// on crée l'arbre IDsnTree.
		/// 
		/// Le structure du fichier est hiérachique.
		/// Chaque ligne contient les informations suivants:
		/// - S10.G01.00: identifant du noeud,
		/// - Emetteur: le libellé (label) du noeud,
		/// - (1,1) : (nombre d'instances min, nombre d'instances max)
		/// 
		/// Le but de cette l'arbre est de guider
		/// la construction de IDataTree qui a des données réelles.
		/// 
		/// Donc les instances précédamment citées
		/// ne sont pas celles du IDsnTree
		/// mais celles du IDataTree.
		/// 
		/// Chaque noeud de l'arbre IDsnTree est unique
		/// identifé par son identifant (S10.G01.00)
		/// 
		/// La logique de la lecture du fichier:
		/// 
		/// - Le nombre + 1 de caractère \t au début de chaque ligne
		/// désigne le niveau (Level) du noeud.
		/// Exemple S10.G01.00 est niveau 1 (car 0 caractère \t + 1 = 1)
		/// 
		/// - On crée artificiellemnt une racine :
		/// new DsnNode("S00.G00.00", null, Racine, 0, new DsnCardinality(1,1));
		/// 
		/// - le dernier noeud (en haut) ayant le niveau = niveau courent + 1
		/// est le parent du noeud courant.
		/// 
		/// - Les noeuds, ayant le niveau = niveau courant -1,
		/// qui suivent immédiatement le noeud courant
		/// est les enfants du noeud courant.
		/// 
		/// </summary>
		int Count { get; }

		/// <summary>
		/// On a besoin d'une racine pour prendre arbre
		/// </summary>
		IDsnNode Root { get; }

		/// <summary>
		/// On récupère un noeud par son id
		/// </summary>
		/// <param name="id">exemple S30.G01.00 (Identification du Salarié)</param>
		/// <returns></returns>
		IDsnNode Find(string id);
	}
}
