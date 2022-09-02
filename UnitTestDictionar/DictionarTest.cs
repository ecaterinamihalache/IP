/******************************************************************************************/
/* 
 * Autor: Ichim Ioana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/
using Dict;
using DictionarProiect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestDictionar
{
    /* ! \class DictionarTest
     *   \brief Clasă pentru testarea metodelor din DefinitionList.cs
     */
    [TestClass]
    public class DictionarTest
    {
        private DefinitionList _definitii;

        [TestInitialize]
        public void TestSetup()
        {
            Explanation explicatie1 = new Explanation("part1", "definition1");
            Explanation explicatie2 = new Explanation("part2", "definition2");
            _definitii = new DefinitionList(new List<Explanation> { explicatie1, explicatie2 });

        }
        [TestCleanup]
        public void TestCleanup()
        {
            int i = _definitii.Definitii.Count - 1;
            while (i >= 0)
            {
                _definitii.RemoveDefinition(i);
                i--;
            }

        }
        [TestMethod]
        public void ModificaDefinitie_ListaDefinitii()
        {
            _definitii.UpdateDefinition(1, "part1", "definition1_modified");
            Explanation rezultatAsteptat = new Explanation("part1", "definition1_modified");

            Assert.AreEqual(rezultatAsteptat.Parte, _definitii.Definitii[1].Parte);
            Assert.AreEqual(rezultatAsteptat.Explicatie, _definitii.Definitii[1].Explicatie);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModificaDefinitie_ListaInitiala_IndexGresit()
        {
            _definitii.UpdateDefinition(2, "part1", "definition1_modified");
        }
        [TestMethod]
        public void ExtrageDefinitie_ListaInitiala_PrimaDefinitie()
        {
            Assert.AreEqual("part1", _definitii.GetExplanation(0).Parte);
            Assert.AreEqual("definition1", _definitii.GetExplanation(0).Explicatie);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExtrageDefinitie_ListaInitiala_IndexGresit()
        {
            _definitii.GetExplanation(2);
        }
        [TestMethod]
        public void AdaugaDefinitie_ListaInitiala()
        {
            _definitii.AddDefinition(new Explanation("part_add", "definition_add"));
            //verific daca numarul de definitii s-a modificat
            Assert.AreEqual(3, _definitii.Definitii.Count);
            Assert.AreEqual("part_add", _definitii.Definitii[2].Parte);
            Assert.AreEqual("definition_add", _definitii.Definitii[2].Explicatie);
        }
        [TestMethod]
        public void StergeDefinitie_ListaInitiala_PrimaDefinitie()
        {
            _definitii.RemoveDefinition(0);
            //verific daca numarul de definitii s-a modificat
            Assert.AreEqual(1, _definitii.Definitii.Count);
            //acim si prima definitie s-a modificat
            Assert.AreEqual("part2", _definitii.Definitii[0].Parte);
            Assert.AreEqual("definition2", _definitii.Definitii[0].Explicatie);
        }
        [TestMethod]
        public void StergeDefinitie_ListaInitiala_IndexGresit()
        {
            _definitii.RemoveDefinition(2);
            //verific daca numarul de definitii s-a modificat
            Assert.AreEqual(2, _definitii.Definitii.Count);
        }
    }
}
