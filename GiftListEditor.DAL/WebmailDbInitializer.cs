using GiftListEditor.BLL.Enums;
using GiftListEditor.BLL.Models;
using PDCoreNew.Extensions;
using System;
using System.Data.Entity;
using System.Globalization;

namespace GiftListEditor.DAL
{
    public class WebmailDbInitializer : DropCreateDatabaseIfModelChanges<WebmailContext>
    {
        protected override void Seed(WebmailContext context)
        {
            const string dateFormat = "MMM d, yyyy";

            var mails = new[]
            {
                new Mail
                {
                    Subject = "Booking confirmation #389629244",
                    From = "Abbot <oliver@smoke-stage.xyz>",
                    To = "steve@example.com",
                    Date = DateTimeOffset.ParseExact("May 25, 2011", dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                    MessageContent = "Hi!<br><br>Schwebet und ernsten zu ich träne diesmal schatten ich folgenden erste seh jenem und irrt was menge dunst herauf. Jenem meinem die mich bang jenem den lebens das busen verklungen fühlt folgenden. Stunden folgenden um nach widerklang strenge ein welt ich euch alten der um nun erfreuet gedränge. Festzuhalten bilder mich ihr jenem mit verklungen auf euch wird selbst des noch weich an des. Tränen um sehnen gleich das stunden irrt einst ertönt besitze ein und liebe wohl noch manche und hinweggeschwunden ertönt.<br><br>Lied lieb zauberhauch erste die steigen fühlt mich liebe halbverklungnen zu selbst liebe glück. Mir es fühlt hinweggeschwunden schwebet nun euch glück auf irrt neu weiten fühlt und jenem bringt lebens versuch. Erste folgenden ich walten wird euren sang nicht lebt mit es steigt widerklang tönen nun busen.<br><br>Gesänge zu nun hinweggeschwunden vom mich fühlt träne blick kommt zu. Um wohl es freundliche denen geneigt wird. Menge hören zauberhauch vom ertönt wiederholt mich die nicht jenem euch ein.<br><br>Widerklang der lebens der zug träne selbst sich bilder alten strenge zerstoben zauberhauch die um. Ertönt versuch erfreuet und. Ein wieder zerstreuet zerstoben folgt ich herzen der kommt ihr mein sich ersten gedränge.<br><br>Best regards - Jonas",
                    Folder = Folder.Inbox
                },
                new Mail
                {
                    Subject = "RE: Reservation confirmation #999331516",
                    From = "adele.guyuson@hat-chicken6.xyz",
                    To = "steve@example.com",
                    Date = DateTimeOffset.ParseExact("May 2, 2011", dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                    MessageContent = "Hi Laith,<br>At et eros.<br><br>Eu no dolore et ea vero dolore luptatum tempor sit ipsum labore dolor elitr. Eirmod clita facilisis et velit justo eos eos. Dolor gubergren vero rebum elitr sit sit ipsum ut no rebum et.<br><br>Exerci diam ut vel ut. Dolor stet amet volutpat autem invidunt duis et enim vel ipsum eirmod sadipscing dolore sadipscing.<br><br>Cheers - Ori Hupe",
                    Folder = Folder.Archive
                },
                new Mail
                {
                    Subject = "FW: Associate advice",
                    From = "Addison Begoat <upton.oprdrusson@pear-income.xyz>",
                    To = "steve@example.com",
                    Date = DateTimeOffset.ParseExact("May 7, 2011", dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                    MessageContent = "Yo...<br>Augue enim zzril vulputate amet suscipit suscipit ut. Dolor velit eos sit eleifend duo no soluta. Eos sit magna.<br><br>Sadipscing molestie voluptua clita kasd sadipscing dolor accusam quis accusam consetetur invidunt erat dolore. Dolor consetetur sed ea lorem et et suscipit magna ipsum magna sit eu sed sea vel.<br><br>Ut nonumy no stet congue nonumy amet luptatum et dolor enim eirmod erat kasd accusam diam eirmod. Dolor et vel diam qui sadipscing et erat ut erat nonummy dolor ea accusam sit eirmod illum eos accusam. Invidunt vulputate diam dolore est voluptua dolores et dolor iriure tincidunt consetetur elitr vero kasd clita sed.<br><br>Thanks,<br>Ali",
                    Folder = Folder.Inbox
                }
            };

            context.Set<Mail>().AddRange(mails);


            var tasks = new[]
            {
                new Task { Title = "Wire the money to Panama", IsDone = true },
                new Task { Title = "Get hair dye, beard trimmer, dark glasses and \"passport\"", IsDone = false },
                new Task { Title = "Book taxi to airport", IsDone = false },
                new Task { Title = "Arrange for someone to look after the cat", IsDone = false },
            };

            context.Set<Task>().AddRange(tasks);


            context.SaveChangesWithModificationHistory();


            base.Seed(context);
        }
    }
}
