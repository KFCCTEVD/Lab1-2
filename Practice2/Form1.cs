using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestLibrary;
using QuestLibrary.AbsrtractClasses;
using QuestLibrary.QuestFactories;

namespace Practice2
{
    public partial class Form1 : Form
    {
		private int currentRoom = 1;

		IQuest quest = null;
		IQuestRoom room = null;

		IQuestItem questItem = null;
		List<IDecoyItem> decoyItems = null;

		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			ProceedQuests();
        }

		private void ProceedQuests()
		{
			IQuestFactory questFactory = null;

			if (currentRoom == 1)
				questFactory = new VillageQuestFactory();

			else if (currentRoom == 2)
				questFactory = new ForestQuestFactory();

			else if (currentRoom == 3)
				questFactory = new CastleQuestFactory();

			else
			{
				MessageBox.Show("You have completed all quests!");
				Close();
			}

			if (questFactory != null)
				LoadQuestRoom(questFactory);
		}

        private void LoadQuestRoom(IQuestFactory factory)
        {
			quest = factory.CreateQuest();
			room = factory.CreateQuestRoom();

			questItem = factory.CreateQuestItem();
			decoyItems = factory.CreateDecoyItems();

			questNameLabel.Text = quest.GetName();
			questDescriptionLabel.Text = quest.GetDescription();

			roomPictureBox.BackgroundImage = room.GetImage();

			guiPictureBox.BackgroundImage = Image.FromFile("resources/images/GUI.png");

			decoyPicture1.BackgroundImage = decoyItems[0].GetImage();
			decoyPicture1.Location = decoyItems[0].GetLocation();
			decoyPicture1.Size = decoyItems[0].GetSize();

			decoyPicture2.BackgroundImage = decoyItems[1].GetImage();
			decoyPicture2.Location = decoyItems[1].GetLocation();
			decoyPicture2.Size = decoyItems[1].GetSize();

			decoyPicture3.BackgroundImage = decoyItems[2].GetImage();
			decoyPicture3.Location = decoyItems[2].GetLocation();
			decoyPicture3.Size = decoyItems[2].GetSize();

			questItemPicture.BackgroundImage = questItem.GetImage();
			questItemPicture.Location = questItem.GetLocation();
			questItemPicture.Size = questItem.GetSize();

			guiPictureBox.Parent = roomPictureBox;
			questNameLabel.Parent = guiPictureBox;
			questDescriptionLabel.Parent = guiPictureBox;
		}

		private void decoyPictureClick(object sender, EventArgs e)
		{
			MessageBox.Show("This is not an item you are searching for...");
		}

		private void questItemPictureClick(object sender, EventArgs e)
		{
			MessageBox.Show($"Congratulations! You have found quest item!\n{questItem.GetName()}\n{questItem.GetDescription()}");
			currentRoom++;
			ProceedQuests();
		}
	}
}
