using SingleLinkedList.CLinkedLists;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            SLinkedList slinkedList = new SLinkedList();
            
            List<String> nodesList = new List<String>();
            
            slinkedList.appendNode("When she was just a girl she expected the world");
            slinkedList.appendNode("But it flew away from her reach");
            slinkedList.appendNode("So she ran away in her sleep");
            slinkedList.appendNode("Dreamed of para - para - paradise");
            slinkedList.appendNode("Para - para - paradise, para - para - paradise");
            slinkedList.appendNode("Every time she closed her eyes");
            slinkedList.appendNode("When she was just a girl she expected the world");
            slinkedList.appendNode("But it flew away from her reach");
            slinkedList.appendNode("And the bullets catch in her teeth");
            slinkedList.appendNode("Life goes on, it gets so heavy");
            slinkedList.appendNode("The wheel breaks the butterfly");
            slinkedList.appendNode("Every tear a waterfall");
            slinkedList.appendNode("In the night the stormy night she'll close her eyes");
            slinkedList.appendNode("In the night the stormy night away she'd fly");
            slinkedList.appendNode("Dream of para-para-paradise");
            slinkedList.appendNode("Para-para-paradise");
            slinkedList.appendNode("Para-para-paradise");
            slinkedList.appendNode("Sing, la la la la la la la la la");
            slinkedList.appendNode("La la la la la la la");
            slinkedList.appendNode("And so lying underneath those stormy skies");
            slinkedList.appendNode("She'd say, oh, oh, oh, oh, oh, oh");
            slinkedList.appendNode("I know the sun must set to rise");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("Para - para - paradise");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("(Oh oh oh oh oh, oh oh oh)");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("Para - para - paradise");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("Oh oh oh oh oh oh, oh, oh");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("Para - para - paradise");
            slinkedList.appendNode("This could be para-para - paradise");
            slinkedList.appendNode("(Oh oh oh oh oh, oh oh oh)");
            slinkedList.appendNode("This could be para, be paradise");
            slinkedList.appendNode("Para - paradise");
            slinkedList.appendNode("Para - paradise");
            slinkedList.appendNode("This could be para, be paradise");
            slinkedList.appendNode("Para - paradise");
            slinkedList.appendNode("Para - paradise");

            slinkedList.prepend("I am the new head");
            slinkedList.prepend("Mwhahaha I am the new head now");
            slinkedList.prepend("Look at me, I am the Captain now");

            slinkedList.deteleWithData("I am the Second Node");
            
            slinkedList.applyProfanityFilter("am");
            
            slinkedList.insertAfter("I have been inserted After", "Look at me, I am the Captain now");
            
            nodesList = slinkedList.showNext();

            foreach (string item in nodesList)
            {
                MessageBox.Show(item);
            }
        }
    }
}