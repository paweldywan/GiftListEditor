using GiftListEditor.BLL.Enums;
using GiftListEditor.BLL.Models;
using PDCoreNew.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.DAL
{
    public class WebmailDbInitializer : DropCreateDatabaseAlways<WebmailContext>
    {
        protected override void Seed(WebmailContext context)
        {
            var set = context.Set<Mail>();

            const string dateFormat = "MMM d, yyyy";

            var mails = new[]
            {
                new Mail
                {
                    Subject = "Booking confirmation #389629244",
                    From = "Abbot <oliver@smoke-stage.xyz>",
                    To = "steve@example.com",
                    Date = DateTime.ParseExact("May 25, 2011", dateFormat, CultureInfo.InvariantCulture),
                    MessageContent = "Hi!<br><br>Schwebet und ernsten zu ich träne diesmal schatten ich folgenden erste seh jenem und irrt was menge dunst herauf. Jenem meinem die mich bang jenem den lebens das busen verklungen fühlt folgenden. Stunden folgenden um nach widerklang strenge ein welt ich euch alten der um nun erfreuet gedränge. Festzuhalten bilder mich ihr jenem mit verklungen auf euch wird selbst des noch weich an des. Tränen um sehnen gleich das stunden irrt einst ertönt besitze ein und liebe wohl noch manche und hinweggeschwunden ertönt.<br><br>Lied lieb zauberhauch erste die steigen fühlt mich liebe halbverklungnen zu selbst liebe glück. Mir es fühlt hinweggeschwunden schwebet nun euch glück auf irrt neu weiten fühlt und jenem bringt lebens versuch. Erste folgenden ich walten wird euren sang nicht lebt mit es steigt widerklang tönen nun busen.<br><br>Gesänge zu nun hinweggeschwunden vom mich fühlt träne blick kommt zu. Um wohl es freundliche denen geneigt wird. Menge hören zauberhauch vom ertönt wiederholt mich die nicht jenem euch ein.<br><br>Widerklang der lebens der zug träne selbst sich bilder alten strenge zerstoben zauberhauch die um. Ertönt versuch erfreuet und. Ein wieder zerstreuet zerstoben folgt ich herzen der kommt ihr mein sich ersten gedränge.<br><br>Best regards - Jonas",
                    Folder = Folder.Inbox
                }
            };

            set.AddRange(mails);

            context.SaveChangesWithModificationHistory();

            base.Seed(context);
        }
    }
}
