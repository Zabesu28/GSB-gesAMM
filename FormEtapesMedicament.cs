﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETgesAMM
{
    public partial class FormEtapesMedicament : Form
    {
        public FormEtapesMedicament()
        {
            InitializeComponent();
        }

        /* fonction qui charge la liste des etapes d'un medicament quand celui-ci est sélectionné */
        private void chargerListeWorkflow() 
        {
            

            if (Globale.lesMedicaments.ContainsKey(cbMedicament.Text)) 
            {
                lvEtapes.Items.Clear();
                Globale.lesEtapes.Clear();
                Globale.lesDecisions.Clear();
                Globale.lesMedicaments[cbMedicament.Text].getLesEtapes().Clear();

<<<<<<< HEAD

                bd.etapesWorkflow(cbMedicament.Text); // appelle la fonction etapes workflow de bd permettant de remplir la collection des medicaments
=======
                bd.etapesWorkflowNormees(cbMedicament.Text);
                bd.etapesWorkflow(cbMedicament.Text);
                
>>>>>>> feature_clement

                foreach (Workflow leWorkflow in Globale.lesMedicaments[cbMedicament.Text].getLesEtapes())
                {
                    bool trouve = false;


                    foreach (Etape lEtape in Globale.lesEtapes)
                {
                        
                        
                        if (lEtape.getNum() == leWorkflow.getNumEtape()) 
                    {
                            
                           
                        foreach (Decision laDecision in Globale.lesDecisions)
                        {
                                

                                if (laDecision.getId() == leWorkflow.getIdDecision() && trouve == false)  
                            {
                                 
                                    trouve = true;
                                    ListViewItem MonEtape = new ListViewItem();

<<<<<<< HEAD
                                    /* Conversion date */

                                    DateTime laDate = (lEtape as EtapeNormee).getDateNorme();
                                    string uneDate = (laDate.Day +"/"+ laDate.Month +"/"+ laDate.Year).ToString();
=======
>>>>>>> feature_clement
                                    DateTime laDateDecision = leWorkflow.getDateDecision();
                                    string uneDateDecision = (laDateDecision.Day + "/" + laDateDecision.Month + "/" + laDateDecision.Year).ToString();

                                    MonEtape.Text = lEtape.getNum().ToString();
                                    MonEtape.SubItems.Add(lEtape.getLibelle());
                                    MonEtape.SubItems.Add(uneDateDecision.ToString());
                                    MonEtape.SubItems.Add(laDecision.getLibelle());

                                    if (Globale.lesEtapes.Contains((lEtape as EtapeNormee)))
                                    {
                                        DateTime laDate = (lEtape as EtapeNormee).getDateNorme();
                                        string uneDate = (laDate.Day + "/" + laDate.Month + "/" + laDate.Year).ToString();
                                        MonEtape.SubItems.Add((lEtape as EtapeNormee).getNorme());
                                        MonEtape.SubItems.Add(uneDate.ToString());
                                    }
                                    else
                                    {
                                        MonEtape.SubItems.Add("");
                                        MonEtape.SubItems.Add("");
                                    } 
                                    
                                    
                                            
                                    

                                    /* Ajout de l'etape et autre info dans la liste view */
                                    lvEtapes.Items.Add(MonEtape);

                            }
                        }

                    }
                }

            }

            }
            else
            {
                MessageBox.Show("Aucune étape n'a été traité sur ce médicament");
            }

        }

        /* Affiche les medicaments dans la comboBox */
        private void FormEtapesMedicament_Load(object sender, EventArgs e)
        {
            bd.lireLesMedicaments(); // fonction venant de bd qui remplit la collection des medicaments  
            foreach (string leCodeMedicament in Globale.lesMedicaments.Keys)
            {
                Medicament leMedicament = Globale.lesMedicaments[leCodeMedicament];
                cbMedicament.Items.Add(leMedicament.getDepotLegal());

            }
            
        }

        /* Charge les infos des etapes du medicament sélectionné dans la listView après la sélection de celle-ci */
        private void cbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {         
            chargerListeWorkflow();

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
