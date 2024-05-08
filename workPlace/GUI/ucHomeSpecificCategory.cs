﻿using DAO;
using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucHomeSpecificCategory : UserControl
    {
        Person currentUsingHirer = null;
        CategorySkill category = null;
        List<Worker> currentDisplayingWorkerList = null;
        DbConnection dbConn = new DbConnection();

        public ucHomeSpecificCategory()
        {
            InitializeComponent();
        }

        public ucHomeSpecificCategory(Person hirer, CategorySkill category)
        {
            InitializeComponent();
            this.currentUsingHirer = hirer;
            this.category = category;
            this.lblCategory.Text = category.Type.ToString();
            GetWorkerList();
            GenerateDynamicUserControl(currentDisplayingWorkerList);
        }

        private void GetWorkerList()
        {
            // Get the worker list from database
            currentDisplayingWorkerList = dbConn.FetchWorkerList(category);
            currentDisplayingWorkerList = currentDisplayingWorkerList.Where(x => x.IsActive == true).ToList();
        }

        private void GenerateDynamicUserControl(List<Worker> workerList)
        {
            fpnlContainer.Controls.Clear();   

            // Generate user control
            for (int i = 0; i < workerList.Count; i++) 
            {
                ucWorker workerPreview = new ucWorker(workerList[i], currentUsingHirer);
                fpnlContainer.Controls.Add(workerPreview);
            }
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl(SummarizeData.RelatedWorker(currentDisplayingWorkerList, txtSearch.Text));
        }

        /// <summary>
        /// Rearrange the list by user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbArrangeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}