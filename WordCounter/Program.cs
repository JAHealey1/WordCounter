﻿using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;
using WordCounter.Service;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            IWordCountingService wordCounterService = new WordCountingService();

            List<WordCount> topTenWords = wordCounterService.GetTopTenWords(allText).ToList();
            if (topTenWords.Count == 0)
            {
                Console.WriteLine("No words were found in the given text.");
            }
            else
            {
                Console.WriteLine("Top 10 words in the given text:");
                foreach (WordCount word in topTenWords)
                {
                    Console.WriteLine($"{word.Word} appears {word.Count} times");
                }
            }
        }

        //For the purposes of this excersise - no point in wasting time/resources reading the text from a file
        private const string allText = @"
* if *



EA.BUCCHIANERI




LoRd op rhe Rings: 
ApocAtypric pRophecies



E.A.BUCCHIANERI


Lord of the Rings: Apocalyptic Prophecies


Published at: 


Scribd


Scrihd.com


© Copyright 2014, 2015 E.A.Bucchianeri


Work published gratis by the author: you may freely share this work, download it, print
copies, etc., without seeking the author’s permission. However, if quoting any material for personal
or research purposes, please include the proper credit / citations, credits, bibliography, etc.Artwork
used is either in the public domain, or issued under Creative Common Licences.


Other Works by the Author: 


Fiction: 


Brushstrokes of a Gadfly

Phantom Phantasia: Poetry for the Phantom of the Opera Phan


Non-fiction: 

We Are Warned: The Prophecies of Marie-Julie Jahenny (Translation)

Faust: My Soul be Damned for the World, 2 Volumes
Handel’s Path to Covent Garden

A Compendium of Essays: Purcell, Hogarth and Handel, Beethoven, Liszt, Debussy, and
Andrew Lloyd Webber




Table of Contents: 


In the End Times: the Great Monarch and the Angelic Pontiff 5 

A Hidden King ~Descendant of a Great Lineage 6 

Absolute Monarchies ~Approved by Heaven 7 

The Bible and Prophecies: Inspiration for Tolkien’s Great Epic? 11 

Aragorn and the Prophecies of the Great Monarch 19 

The Angelic Pontiff 40 

Lord Sauron ~Veiled Malice 54 

The Great Period of Peace 90 

Bibliography 96 


Illustration Credits 


98 



“ ‘These are indeed strange days,’ he muttered.
‘Dreams and legends spring to life out of the grass.’ ” 


~J.R.R.Tolkien, The Two Towers



Darkness covers the land, war and rumours of war threaten the lands of
Middle Earth, the powers of evil are rising, the earth itself is convulsed, yet there is 
hope; a small band of courageous souls enter upon a nigh impossible quest to quell
a diabolical enemy, while a hidden king comes to claim his rightful throne through
the turmoil of battle as foretold by prophets of old and rebuilds his kingdom laid
waste by his enemies.

The plot of J.R.R.Tolkien’s classic High Fantasy epic, Lord of the Rings, is it
not? However, the above narrative may be more than a fantastic story. Is it
possible Tolkien was inspired by astounding Roman Catholic prophecies yet to be
fulfilled? In fact, not many Catholics are aware of these prophecies, and for those
who have read them do not believe, for they indeed sound surreal as though penned
by a fiction author despite having been imparted by approved saints and mystics of
the Church. 

Why, the reader may ask? These little known prophecies may sound
fantastic, but in truth are downright frightening, condemning the sinful corruption
of both the Church and the secular world alike.One may dare to suggest these
foretellings have been suppressed from the majority of the faithful due to the
damning nature of the warnings from Heaven despite receiving Church approval. 
Yet, the prophecies are available for those who seek, and Tolkien being a devout
Catholic may have woven threads of these revelations into his famous epic, which
we shall now explore.


In the End Times: the Great Monarch and the Angelic Pontiff


For centuries, saints and mystics of the Church foretold that near the End
Times, Satan would be given a period to test mankind, also foretold in the Book of
the Apocalypse: “And after that, he must be loosed a little time.” (Apoc. 20, 2)
Pope Leo XIII(pontificate 1878-1903) experienced a vision displaying the liberty
that would be granted to Satan, and was shown that the devil and his followers
would be given the time he demanded to tempt the world: about seventy-five to one
hundred years.The mystic and stigmatist Blessed Anne Catherine Emmerich
(1774-1824) has even provided the faithful with a date for when this horrific ‘Age of
Satan’ would commence. According to her revelations,* the devil and his minions
would be allowed this period of freedom fifty or sixty years before the year 2000 
AD and they would begin to prepare the earth for this age long before the year ever
arrived. 


Ominous, is it not? 


Other mystics fill in considerable details about this dark time: corruption
would cover the earth, sin would be so great that the land will rebel against man
and the seasons would no longer be discernible. Morals would become non¬ 
existent, impurity would be so terrible that there would be hardly any virgin souls
left on earth. Hedonism would grow more rapid than in the pagan times.The


Bl. Catherine Emmerich’s revelations were recorded by the author Clemens Brentano, and
unfortunately it is noted he introduced several of his own embellishments to her testimony making it
impossible to discern her prophecies from his additions.That being said, Catholics continue to read
her revelations as recorded by Brentano and Tolkien may have also been influenced by what was
attributed to her, hence her prophecies are also included in this study.


5 




Church itself would become corrupt from within and would abandon its holy
traditions as they had been practised for centuries, (often perceived to be the
revolutionary reformations of the Vatican II Council), and that Heaven would be
forced to send cataclysmic misfortunes to the earth in an attempt to bring mankind
back to its senses such as previously unknown plagues, famines, catastrophic
earthquakes, three World Wars, the threat of Muslim invasions in the western
world and the complete destruction of Paris to name a few. When these fail, the
last and greatest punishment would be the Three Days of Darkness when all Hell
would literally and physically be let loose, destruction would come in a rain of fire, 
and those not properly prepared for these chastisements would be struck dead. 
Two-thirds, or in some prophecies, three-quarters of the human race would be
annihilated, those remaining would be left to repopulate and rebuild the earth. 

After these horrific days have passed, there would be a great period of
peace the like of which was never witnessed before in history. Heresies will be
wiped out, world wide conversions will take place. All Christian churches
separated by heresy or schism would come back to the Roman Catholic fold, which
would be completely reformed back to its former Latin traditions under the
guidance of a great pope, an ‘Angelic Pontiff. In union with the Angelic Pontiff, 
the secular world would be ruled by a Great Monarch who will be chosen by
Heaven to restore all the absolute monarchies of Europe that would then rule under
his sceptre as in the days of the Holy Roman Empire. This great period of peace
would last for about thirty years until the death of the Great Monarch, after which
the Antichrist will reveal himself and attempt to corrupt the faithful once more
before Christ shall appear from Heaven with His Angels on the Last Day and
commence the General Judgement. This appears to be the general outline of the
various prophecies. 

Concerning the Great Monarch, who is he? From whence shall he appear? 
From the numerous prophecies, the time of his appearance is difficult to discern— 
he will be a man of war, driving back enemies that will have invaded Europe. The
miracles that will appear at his coming and his own personal holiness will be so
great he will convert many and his enemies will be quickly defeated. From this we
can assume he might come during a great war before the harrowing Three Days of
Darkness with its Rain of Fire, although it is still possible he might come after. 
However, there is no doubt from what country he will take his throne: he will be a
descendant of the Merovinginan dynasty, Charlemagne and the slaughtered
Bourbons. He will be the last and greatest of the Kings of France. 


A Hidden King ~Descendant of a Great Lineage


Arguably, the most detailed and astounding number of prophecies
concerning the return of the Monarch to France were revealed by the Church- 
approved French stigmatist, Marie-Julie Jahenny(1850-1941), a peasant from 


6 



Brittany, yet few outside of France have heard of her until now despite the
numerous visions and prophecies she received. 1 

According to her, the Great Monarch would be a hidden descendant of the 
“King and Queen martyrs”, apparently Louis XVI and Marie-Antoinette that were
murdered during the republican French Revolution.He would be the last and
greatest of the Bourbon line, yet would remain 'hidden’ for his own safety as the 
powers ruling France and the world at the time will stop at nothing to ensure that
an absolute monarchy will never be restored.However, despite their venomous
malice, he would come forth out of hiding when the time was right accompanied by
great miracles in the sky that would declare his coming.The miracles that will
appear will be so great that the like of them will not be seen again until the Last
Days, these wonders will even include resurrections of the dead.Weary of civil and
world wars, in addition to corrupt democracies ruled by demonic elements that do 
nothing but secure their own party interests to the detriment of the citizens, the
people of the earth will at last recognise they have no true freedoms under their
republics and cry out for the absolute monarchies to be re-established.

At first, three aristocratic contenders will come forward in an attempt to
claim the French throne, including the Orleans branch, but they will all fail.The
true king will come out of hiding and will be ridiculed in the beginning, but will
succeed in claiming the throne after the various miracles will appear proving his
royal claim.After purging France of its enemies, he will come to the aid of Europe
still gripped in the ravages of war. The new king will first come to the rescue of the
Angelic Pontiff, who will be held captive in Rome, and after freeing him, this great
king will be crowned Holy Roman Emperor by the Angelic Pontiff and rule over
the other kings of Europe for a time.All countries of the earth will be influenced by
his just and holy rule.

For centuries saints prophesied that France is destined to reform a corrupt
world near the end of time, but why is the monarchy of France chosen for this great
mission? To find the answer, we must look back to the coronation of King Clovis I
(c.466-511 AD), the first King of the Franks(France), and his miraculous
conversion.


Absolute Monarchies ~Approved by Heaven


Before the time Clovis came to power in the latter half of the 5 th Century,
Europe consisted of multiple tribal kingdoms and principalities, which included the
land of the Franks(the future France). A number of these tribal kingdoms were still
under pagan rule, while the majority of them were converting to Arianism, a
heretical doctrine denounced centuries earlier at the first ever Ecumenical Council
of the Church at Nicea 325 AD.The Arians believed that while Christ was the
appointed saviour of mankind, they denied that He was of the same nature as God, 
declaring He was created.According to the Arians, Christ was nothing more than


1 For a detailed account of her revelations and those of other approved saints and mystics of the
Catholic Church concerning the Days of Darkness, the Angelic Pontiff, and the Great Monarch, see
We Are Warned: The Prophecies of Marie-Julie Jahenny

(December 2011: www.scribd, com/doc/74402052 )


7 





tehi bemiflnhrf / js=MA


biccenc fltniwdg




(Above) Medieval manuscript illumination of King Clovis I Baptised by St.Remi with The Holy
Spirit bringing the Sacred Ampulla (1325-1335) by Jacob vanMaetant.

(Below) Artwork from the 15 th Century depicting the baptism of Clovis I(top left), and his gift of
healing as he touches a subject inflicted with scrofula, (middle). 









































a highly favoured mortal man and was not divine.This reinterpretation of the
Saviour was completely against the Traditional teaching of the Church upon which
the Christian Faith rested, and was in fact considered an Antichrist doctrine, for 
according to the teachings of the Apostle St.John, those who attempted to deny the
divine or the human nature of Christ were forerunners of the Antichrist, hence the
condemnation of Arian doctrines by the Church.However, while the Council of
Nicea declared that the divinity of Christ was an article of faith, the Arian heresy
continued to spread rapidly as mentioned.

Returning to Clovis I, although not an Arian, he was still a pagan who was
married to the Roman Catholic princess of Burgundy, St.Clotilde.Despite her
attempts to convert him, Clovis remained sceptical of the Christian faith until
threatened with war and the loss of his kingdom to the Alemanni tribes near
Cologne.As tradition states, he made a pact with Christ that if he won the battle,
he would become baptised. He defeated the Alemanni and fulfilled his oath to
become a Roman Catholic Christian. On his baptism Christmas Day 506 AD his
conversion was sealed by a miracle ~the Holy Spirit appeared in the form of a dove
bringing sacred chrism for Clovis’ coronation and a lily from Heaven, a symbolic
representation of the Trinity, the doctrine of which the Arians rejected.Henceforth
the sign of the French monarchy became the Fleur-de-Ly.

This miracle from Heaven was of paramount importance to the
establishment of the kingdom for this was no mere recurrence of the conversion of
the Emperor Constantine who only saw a cross in the sky.Clovis had received
heavenly-made oil, his anointing mirrored the anointing of kings as seen in the Old
Testament, such as King David’s anointing by the prophet Samuel and King
Solomon by Zadok the priest.Furthermore, with the appearance of the Holy Spirit,
Clovis’s miraculous anointing and ascension to the throne was seen to be a
metaphorical symbol of Christ’s anointing by the Holy Spirit. P.Christian Klieger
notes the tremendous impact Clovis’ conversion and anointing had on Western
Europe: 


“Rather than being a Roman emperor who was divine in his own
right, the new universal ruler served in Christ’s stead on earth, and ruled
by His right. (...) The oil brought forth by the dove was the new
Palladium, the source of all legitimacy.It was to serve as the model of
absolute monarchy in Western Europe until the Enlightenment. (...) 
While Constantine was consecrated by St.Sylvester, and later
Charlemagne by Pope Leo, throughout the history of the West, only
Christ and Clovis are witnessed as being anointed by a literal epiphany
of the Holy Spirit. The ‘Divine Right (of Kings)’ of all European
monarchies has its origin in the anointing of Clovis. More than any
other action, the baptism symbolised the fusion of Greco-Roman,
German, and Judeo-Christian worlds in a new concept of universal
empire.The Sacred Ampulla itself (the vessel of oil brought by the
Dove) became among the most holy relics of the French monarchy,
securing for the king the style, ‘Most Christian’ and ‘Eldest Son of the
Church’ until the very end of the Ancien Regime.The French monarchy
had become one of the great pillars of the Papacy. (...) Clovis’ 
embracing of orthodox Roman Catholicism was a severe blow to the
Arianism of Gaul(i.e.ancient France). The Frankish king’s profession 


9 



(of faith) helped establish the primacy of the Bishop of Rome in matters
Christian.” 2 


We may ask why Clovis was so favoured with an epiphany of the Holy
Spirit? Tradition also states his royal bloodline had descended from the Tribe of
Judah and the House of David, and thus the Kings of France were believed to be
distant descendants of Christ’s Royal House: a sign that Christ’s kingdom was
indeed visibly present on earth in both the Church and in a holy secular empire
established by Heaven itself. The miracles do not cease there: according to
tradition, from that day forward Clovis and his descendants were all empowered
with many mystical gifts, including the gift of healing.

Eventually, Clovis also defeated Alaric II, king of the Visigoths in 507 AD
near Poitiers, and established Paris as the capital of his kingdom, thus uniting the
lands that include most of present-day France and south-western Germany. 

In conclusion, the French monarchy, a blessed and divinely-favoured blood
line, had saved Europe from perilous heresy and was paramount in establishing
Roman Catholicism in Europe.According to the prophecies, the last of this
favoured royal line would also come forth out of hiding in a miraculous manner to
save Europe and the Church one last time before the appearance of the Antichrist. 



T n 

T5 AtlcJttfS OUhViCTUU! 

.'i <*)>«« iiwiiftyifaMtic 
£ mCtwYu liitt-ftKMWifa?' 
m croffttrtntcu uicix^ttv

cite rtjictw 


dcrtAiciifceiilhVetne^fhi Jicif
i\ Itoer litMcfofuc toM'frC 
41 ittHticn lx»en nMct^n devhc 
-p )C rttiflftflfius Vie lievfef(Viilt

V arljiCcr ftWlMt U’tfi-Juf tWttV 
' iMittna niMicynH 


cclii«-&ic<pmtirP4Viibrtrf

T° ilttiTroof no cvrtdrt- tnr\' 

Ji 4 fSuit Ttvi* a*i «aieirc (kit__

1 »£* cwrtptrt-ntcrlutvcii vottii 

- A CvAV-rtTClK(h* So it Cf- 


The battle between Clovis I and the Visigoths (Manuscript date c. 1325 -1335)


2 P.Christian Klieger, The Microstates of Europe: Designer Nations in a Post-Modern World. (United
Kingdom: Lexington Books, 2013), pp. 139-140. 


10 













The Bible and Prophecies: Inspiration for Tolkien’s Great Epic?


Tolkien did not write Lord of the Rings first, it originated as a sequel to his
famous fantasy work, The Hobbit, which he wrote for his children.At first, Tolkien
continued the tale of the magical ring introduced in The Hobbit mostly to indulge his
linguistic interests, inventing a history to explain the evolution of the Elvish
languages, never dreaming that people might be interested in his new project until
requests from readers wishing to find out more about hobbits and their adventures
become more prolific.From there, the story of the One Ring grew until it became
a mighty epic featuring the history of not just one fictional kingdom, but several
realms with various races, plus thousands of years of history, culture and lore.

Although the majority of his great epic was written during the ravages of
World War II, Tolkien insisted the fantasy battles he penned in Lord of the Rings
were not based on that terrible time, and indeed, he declared that he did not intend
to impart any hidden meaning or message in his text, that it was not even
allegorical or topical, rather, he solely wished as a tale-teller to “...try his hand at a
really long story that would hold the attention of readers, amuse them, delight
them, and at times maybe excite them or deeply move them.” 3 However, Tolkien
did admit that, “As a guide, I had only my own feelings for what is appealing or
moving.” 4 In other words ~he wrote about what interested him ~and despite his
protestation of including anything allegorical into his tale, Catholic history and
mystic prophecy obviously received its fair share of attention in addition to Norse
and Germanic myths featuring fabulous rings of power.

No doubt those already familiar with Tolkien’s tale that takes place in 
‘Middle Earth’ already see many of the links between the Catholic prophecies
stated above and his famous text.In fact, the term ‘Middle Earth’ is not Tolkien’s
original invention but a reference derived from Mediterranean, the inland sea that
marked the ‘Middle of the Earth’ according to ancient maps until the discovery of
the New World.

Needless to say, it is a daunting challenge to summarise the vast ‘history’ of
Tolkien’s fictional world complete with an interpretation of its possible symbolism
within a few pages, but for the sake of understanding the various plots and how
they link to Catholic prophecy, in particular, with divinely chosen kings of the past
and the Great Monarch of the Latter Days, we shall make the attempt.

In the Appendixes of Lord of the Rings, Tolkien provides vast time lines and
chronicles recounting the formation of his fictional kingdoms, and how the various
struggles of their inhabitants after many centuries leads to the decisive War of the
Ring.From the beginning, we can see Tolkien was not only inspired by medieval
history and Norse-Germanic mythology, but also by the Old Testament, namely
Genesis and its account of the first kingdoms of the ancient world in the Middle
East.Although not apparent at first, there are important links with the Old
Testament and the visions of Catholic mystics which Tolkien also seem to have
included in his narrative that we must examine first in order to understand the
framework on which the epic rests. 

Far beyond the borders of Tolkien’s fictional Middle Earth lies a land across
the sea known as the Blessed Realm ruled by the Valar, the Guardians of the
World, an immortal race with great mystical powers.Apparently, the land is also

3 J.R.R.Tolkien, The Lord of the Rings, Foreword, (Great Britain: HarperCollins, 1993), p. 10. 

4 Ibid.


11 



inhabited by the immortal Elves also known as the Eldar, although they do not
seem as powerful as the Valar.Commentators have often noticed this Blessed
Realm is symbolic of Heaven or Paradise, the Valar representing the angelic beings
of heaven, while the Eldar Elves may be a symbol of a race not yet touched by
original sin, similar to Adam and Eve. 5 Within this Blessed Realm are two mystical
trees called Telperion and Laurelin that give light to the land of the Valar, which
seem to bear a close resemblance to the Trees of Life and Knowledge in the Garden
of Eden. Feanor, one of the greatest and learned of the Eldar Elves makes three
fabulous jewels called the Silmarilli, in which he encased the light of the two trees.
These powerful jewels were coveted by an evil entity called Morgoth the Enemy,
and after destroying the two mystical trees, he steals the jewels from the Land of the
Blessed and brings them to his tower across the sea in the mortal lands of Middle
Earth. Despite this destruction, Telperion bore fruit before it was poisoned, and
from the seeds a likeness of this tree was preserved in Middle Earth through its
descendants from age to age, a detail which will become important later in Lord of
the Rings. 

Filled with anger and pride, Feonor defies the wishes of the great Valar and
leaves the Blessed Realm to hunt down Morgoth in an attempt to recover the jewels
by force, bringing a great number of the immortal Eldar with him into exile in
Middle Earth, perhaps based on the account of Adam and Eve thrust out of
Paradise. A race of mortal men on Middle Earth called the Edain become allies
with the newly arrived Eldar Elves and help Feonor in his quest, although it is a
hopeless war and they are defeated by Morgoth. 6 

However, a rare handful of mortal elves wedded with men during this
time, and their descendants continued to battle the evil Morgoth.One of the elven
race who married a mortal was the Princess Luthien.With her husband Beren of
the mortal Edain, she eventually succeeds in wresting back one of the stolen
Silmaril jewels from Morgoth’s crown. The one jewel is passed to their descendants
until it comes into the possession of Princess Elwing, who marries Earendil the
Mariner, another descendant of Elves and Men. Earendil succeeds in gathering the
two races of Elves and Men once more and together as allies they defeat the evil
Morgoth, yet despite their valiant efforts the other two Silmaril jewels are lost
forever.Although the reason is not mentioned in the Lord of the Rings chronicles,
Earendil was not permitted to return to the mortal lands of men, but his ship was
allowed to sail into the heavens bearing the light of the last Silmaril thereby
becoming a star, thus giving hope and light to those mortals still oppressed by the
Great Enemy and his evil servants on Middle Earth.

Through Earendil’s the Mariner’s sons, Elros and Elrond, a distinct race of
semi-immortals is bom called the Peredhil or Half-Elven, a remaining remnant of
the High Elven Kings that originally journeyed to Middle Earth. In recognition of


5 The one major departure from Sacred Scripture is that Tolkien has the ‘angelic’ Valar help finish
the creation of world instead of the ‘One’ Creator as we learn from his other writings. However,
since Tolkien was a traditional Catholic, it is highly unlikely he intended to support a theological
error.We have to keep in mind that as a creative writer Tolkien wished to create a great mythical
world in the tradition of the ancient epic-poets of the past, so of course not everything could follow
Scripture. Despite this, many Biblical themes exist throughout the text.At least his concept of the
Valar is not that much different from the traditional Catholic teaching of angels in that after God
created the world, He gave each and every angel of the lower Choirs a task to accomplish in the
material world, either to keep the heavenly bodies set in their course, or to be appointed as guides of
mankind.

6 Tolkien tells the full tale of the jewels in another work, The Silmarillion. 


12 




Mappa Mundi from the Chronologia Magna (1320) by Paulinus Venetus

In ancient European maps, east is situated on top in honour of Christ, the Light of the
World, represented by the rising sun.Therefore Asia is in top, Europe is to the left, Africa to
the right.The Y-shaped body of water in the middle is the Mediterranean Ocean and the

Black Sea.









their Elven heritage, the great Valar of the Undying Lands grant Elros and Elrond a
choice: they could remain immortal as the Elves, or choose to become mortal men. 
Elros chose to become mortal, although he and his descendants were granted thrice
the lifespan of other men due to their lineage with the Eldar and the great men of
old, thus setting them apart so to speak from the ‘lesser-men’ of Middle Earth, a
‘chosen’ race of mankind.In addition, the Valar wished to reward Elros and his
mortal race for their sufferings and valour in defeating the enemy Morgoth, and
grant them a new kingdom beyond the shores of Middle Earth, the Isle of Elenna
far removed from the pains and toils of other lands.On the Isle of Elenna stands a
magnificent mountain that affords a view of the immortal Eldar kingdom.After
following the Star of Earendil to the new land promised them, the Men of Edain
establish the Kingdom of Numenor with Elros as its first King.Despite the favours
received from the great Valar, once Elros had made his choice to accept mortality,
his descendants had to remain mortal and their fate could not be altered with the
exception they were given the grace to choose the time of their death.

In contrast to Elros, Lord Elrond, who we will see again in Lord of the Rings,
decided to remain immortal like the Elven Eldar, a choice which was also granted
to his immortal descendants.Lord Elrond and his descendants were also granted a
boon by the Valar as a reward for their bravery in defeating Morgoth: if during the
course of their immortal lives they grew weary of the pains of Middle Earth, they
would be allowed to sail once more back to the immortal Undying Lands of the
Blessed at a special time appointed and remain there forever. Yet there was also a
condition attached to the reward: if the descendants of Elrond did not wish to 
return with him when the appointed time came, they would become mortal and
eventually die on Middle Earth. The Valar also laid down one final condition on
the mortal race of King Elros known as the great ‘Ban of the Valar’ ~the mortal
Numenors were forbidden to sail past their own borders and seek the Undying
Lands for they had made their choice, and the Valar could not take back from
mortal men the Gift or the Doom of morality.Any attempt to sail to the Undying
Lands like Elrond and the Eldar would be an act of open rebellion and bring
disaster upon their kingdom.In all, we can see Tolkien’s development of ‘chosen’ 
people and the concept of a ‘promised land’ similar to Abraham and his
descendants in the Old Testament.From here Tolkien begins to construct the
history of the kings of Middle Earth and how they arrived on that land, the folly of
their descendants, and the promise of a faithful king who would return to restore all
that had been lost.

Continuing Tolkien’s tale, in the first days of their reign, a time of great
peace and prosperity existed between the two Kingdoms of the blessed immortal
Eldar and the mortal but great Numenoreans.However, a new evil power appears
on Middle Earth, Lord Sauron, the principal evil character in Lord of the Rings, who
begins to oppress and enslave the lesser races of men.Nevertheless, he fears the
new race of the Numenoreans and devises a plan to ensnare them, but he must first
seduce the wise and far-seeing Eldar if possible.Feigning friendship, he teaches
them the art of making empowered objects through smith work and they begin
forging the various Rings Power.Over time we learn that three of the Rings were 
for the Elven kings, seven for the dwarf lords, and nine for the kings of Men.Yet
unknown to them, Lord Sauron forges a new Ring that will control all the others.
The Eldar eventually discover his evil designs and the Elves make war upon
Sauron, he is defeated and the Three Rings made for the Elven kings are hidden
from him.The dwarfs also ensconce themselves in their underground kingdoms 


14 



with the result their rings are either stolen during wars or lost in the mists of time.
The Nine Kings of lesser-men are not so wise: they are enslaved by their nine rings
and become the feared Nazgul, or Ringwraiths, demonic witch-pawns of Lord
Sauron. 

Afterwards, Sauron continues to oppress the lesser men of Middle Earth,
and at first, the Numenoreans came to their aid, but they eventually grew greedy for 
power and wealth as their generations pass until they also become tyrants. As they
grow in discontent, the mortal descendants of Elros come to regret their ancestor’s
choice and yearn for immortality ~the magnificent view of the Eldar Kingdom
from the mountaintop no doubt makes them covet the Eldar’s immortality all the
more, (a borrowing from the account of the Tower of Babel and King Nimrod’s
challenge to God?) As time passes, the people of Numenor are divided: the
majority following the corrupt kings that envied the immortal Valar and Eldar, and
the few who continue to call themselves the Faithful and who adhere to the Ban
declared by the immortal races.In their envy and growing hatred for the Eldar, the
corrupt kings began to abandon their High Elven names and language, and even
persecute the remaining Faithful. The situation grows more dire as future
generations discover that their very fear of death is decreasing their gifted longevity
and this realisation fuels their desire to cross into the Undying Lands more than
ever before. Rebellion is rife.However, they continue to fear the warnings of the
Valar, Guardians of the World, and this alone prevents them from breaking the
Ban.

Eventually their fear is overcome by the deceitful wiles of Lord Sauron. 
Filled with pride and vainglory, the last king of the Numenoreans yearns for 
conquest and gatherers a great fleet to sail against Lord Sauron on Middle Earth in
an attempt to gain supremacy over the mortal kingdom.The power and splendour
of his army is so mighty that even Sauron’s servants grow fearful, they desert him
and the evil lord is captured.However, Lord Sauron is shrewd: he senses the king’s
pride and his people’s growing rebellion against the Valar and Eldar. Bewitching
the king, he convinces him that the Ban to cross the sea to the Undying Lands was
nothing more than a ploy to keep the mighty race of the Numenoreans from
surpassing the Valar. If he boldly went and conquered the Undying Lands,
immortality would be theirs. 

The king is swayed by his evil council and mustering the greatest army that
was ever gathered on Middle Earth, his mighty fleet sets sail to challenge the Ban
only to bring forth an unimaginable punishment ~ as soon as he sets foot on the
Lands of the Blessed, the Valar relinquish their Guardianship and call upon ‘the
One’, symbolical of God, whereupon the ancient world is punished through great
cataclysmic events.The island kingdom of Numenor with its great mountain is 
thrown down into the sea and the immortal Lands of the Blessed are removed from
the circles of the world so that only the Eldar may still set foot on them.The Evil
Lord Sauron does not escape the chastisements and is also punished: he is caught in 
the great shipwreck as the ocean consumes Numenor and his physical nature is 
destroyed.He survives as a malicious black spirit filled with hate and venom, 
unable to assume a shape that men may gaze upon and remains a shapeless form of
terror.Fleeing to his bleak realm of Mordor in Middle Earth, he hides for a time
until he discovers that a remnant of Numenoreans whom he hated the most
managed to survive the catastrophe ~a handful of the descendants of the Faithful
led by Elendil, who despite having suffered years of persecution from their own
corrupt kindred, had still held fast to the Ban of the Valar.They had escaped the


15 




destruction of Numenor on ships and now found themselves exiles on the mortal
lands of Middle Earth.

No doubt Tolkien derived his plot from the account of Noah and the
purification of the ancient world by water in addition to the fall of Babel. We may
even observe a link between the Numenoreans’ longevity, the shortening of their
lifespan, and the section of the Old Testament recording God’s decision to cut short
the years He first gave to men on earth such as Mathusala who lived up to the ripe
old age of nine hundred and sixty-nine before he died. (Gen. 5:27). Of interest,
Tolkien’s tale of the One ‘God’ removing the Lands of the Blessed from the circles
of the world also sounds surprisingly familiar to Bl.Anne Catherine Emmerich’s
other biblical revelations in that she was shown the fall of humanity and how Adam
and Eve were exiled from the place of their creation in the Garden of Paradise. 
According to her, they were driven downward to the lower realm of creation while 
Paradise appeared to be lifted up higher and higher like a cloud until it was
separated from the earth and floated above it, rising mystically with the rising sun
each morning far out of reach of fallen man. 7 The catastrophic fictional events of
Numenor also bear a resemblance to Catholic prophecies that state in the Latter
Days only a few faithful would remain true to Heaven’s commands while the rest of
mankind will perish amidst cataclysmic punishments that will end the ‘Age of
Satan’, bringing a Great Age of Peace, but only for a brief time.

Of course, we have yet to come to the chronicles in which the story of the
Lord of the Rings actually takes place, but the following history now sets the scene. 
Elendil the Faithful and his exiled descendants establish a new kingdom in Middle
Earth called Gondor and other allied realms near the very borders of Lord Sauron’s
dark realm in Mordor, which throws him into a rage.The evil lord devises war
upon the new kingdoms of his enemies who dare to challenge and thwart his rule in 
that circle of the world.We have already learned that Sauron had persuaded the
Elven Kings to forge the various rings of power, however, he deceives the various
races of Middle Earth, for in secret he brings forth from the fires of Mount Doom
the One Ring that controls them all.Confident of his success, he battles against
Elendil, his sons, the Faithful Numenorean Exiles and the immortal Eldar.Yet, 
despite his possession of the One Ring, the Dark Lord is overconfident and goes to
war before his evil power is fully recovered, while the might of the High Elf Gil- 
galad had increased as the years passed.Thus, in the last Great Alliance of Men
and Elves, Elendil and Gil-galad lead their armies to war and manage to overthrow
Sauron but are unable to kill him and are slain for their efforts, while Isildur, 
Elendil’s eldest son seizes the hilt of his father’s famed sword Narsil, which was
shattered as Elendil fell upon it, and attacks Sauron with the broken blade.Isildur
gains possession of the One Ring, but the famed royal sword of kings remains
broken, ending the Second Age of Middle Earth.In the end, Isildur’s victory is an
empty one, for the majority of Sauron’s power resides in the Ring and he is only
defeated not slain. The black lord escapes once more to his stronghold made
indestructible through the power of the Ring and bides his time, plotting vengeance
on Gondor and the complete subjugation of Middle Earth.All he needs is the
Ring, which Isildur had taken, but is soon lost. For centuries Sauron awaits its
return. 


7 Clemens Brentano, Carl E. Schmoger, ed., The Life of Jesus Christ and Biblical Revelations: From the
Visions of the Venerable Anne Catherine Emmerich as recorded in the journals of Clemens Brentano ~Volume
I(Illinois: Tan Books and Publishers, Inc., 1986), pp. 25-26. 


16 



We discover as the tale unfolds in Lord of the Rings that the Ring is not in 
inanimate object and possesses an evil attraction: it will answer to no one but its
master.While it will grant invisibility to anyone who wears it and unnaturally
prolong their life, it will eventually gain control of the bearer in an attempt to have
them relinquish it back to its rightful owner, often tormenting the wearer with an
unquenchable desire to possess it only to find themselves betrayed in the end, for 
after driving them to commit heinous deeds to keep it, the Ring will eventually play
the traitor and will abandon those it uses to find another host more capable of
bringing it back to its Master.The bearers often come to a terrible end as the
possession of the Ring marks them for life.In this manner, Isildur fails the test to
destroy the Ring when he has the opportunity and is eventually slain. The Ring is 
then lost to time, waiting for the right person that can be manipulated and thereby
find its way back to its master. 


At long last, we arrive at the main narrative of Tolkien’s epic Lord of the
Rings, the tale of the One Ring and the saving of Gondor, a plot that appears
derived from Catholic prophecies as mentioned earlier ~the return of a great
hidden King who will restore his royal house at a dark time in history when all
hope seems lost.

Centuries pass, Sauron continues to plague the descendants of Numenor and
their allies with war and pillaging ores, trolls, and other fell creatures of his own
diabolical breeding that he sends into the land.As if these troubles were not
enough, the kingdom suffers from time to time from the ravages of deadly
pestilence.

Eventually during one of the many battles recorded, the direct Southern
scion of the royal lineage of Gondor is extinguished.It appears from the context of
Tolkien’s chronicles that in such an event or emergency the Steward of the King
may assume the role of regent, for now we find that the Steward Pelendur has the
authority to speak to the people of Gondor and he manages to convince them to
reject the rightful claim of the Northern Line, declaring that according to the laws
of the south, they may only recognise the kingship passed through Elendil to his
eldest son Isildur, not his younger son from which the Northern line descends.
Pelendur advises the men of Gondor that they must seek another and sole surviving
but distant royal descendant of the southern kings, who then happens to be a
general of the army. The Steward’s cunning advice is followed, and as the people
of Gondor unanimously agree to accept the general as their new king, the
descendant of the Northern line refrains from pressing his claim further to prevent
civil war.However, after he is crowned king, the general leaves only one heir who
dies without issue, and by right the throne should return to the surviving Northern
Branch of Elendil, but Pelendur the Steward of Gondor remains resistant to the
legitimate Northern line and the throne of the South is practically usurped by him 
as he takes upon himself the rule of the kingdom.

From whence does this audacity arise? Before the line of the southern kings
died, it was their royal custom for the kings to choose for their stewards sons of the
previous stewards before them as they too had descended from the great
Numenorean race.However, the hereditary honour of becoming the King’s
Steward obviously made Pelendur thirst for the ultimate nobility of royal kingship,
for he continued the custom of hereditary ascension to the title. As a result, the
legitimate Northern line of Elendil is thrust into exile.As time passes, their
northern kingdom dwindles and the royal lineage is hidden from the knowledge of


17 



men until it is believed that the northern line has also died out, while the southern
Kingdom of Gondor continues to be ruled by the Stewards and their heirs for 
almost a thousand years. 

As the generations pass, the Stewards smirk at their title of regent and the
ritual oath to “hold rod and rule in the name of the king, until he shall return.” 8 
Their oath becomes mere ritual words, for in the longevity of their reign, they have
grown accustomed to the respect and power they enjoy, living literally like kings. 
In their pride, they even abandon the custom of using High-Elven names, a practise
that reminds us of the corrupt rulers of old who despised the Eldar Elves and
rebelled against the Ban of the Valar.However, despite their honoured position, a
steward can only remain a regent, they are not a royal scion of Elendil and can
never become king.In fact, they dare not sit on the ancient throne, they do not
wear a crown, nor wield a royal sceptre ~ the mark of kingship to the
Numenoreans.This forever reminds them of their inferior position despite their
authority, and prophecies foretell that the rule of the Stewards will not last forever
as the surviving branch from the royal house of Elendil the Faithful will one day
come to light and be restored, prophecies to which the future Stewards harden their
hearts, for they still dread the day when they will be compelled to relinquish their
power notwithstanding their oath.

After centuries of waiting, the prophecies soon become legends and dwindle
into songs and old wives’ tales.The days grow ominous, darkness covers the land 
for Sauron’s might is rising once more.No one knows if any survivors of the
Northern Scion still exists, the people doubt that the kingdom of Gondor will ever
be restored to its former glory and fall into despair, while the Stewards remain smug
in their borrowed absolute power yet fear their rule may indeed be numbered,
assuming that Gondor may inevitably fall to Sauron as few of their former allies
come to their aid to defend the land.The Ring also grows restless as it senses this
change in the earth and it begins to seek its true master.Fell creatures proliferate
and gather for battle, evil men from the South and East are rallied to the call of
Mordor, war is in the air, the destruction of Gondor and with it the last of the
Numenoreans seems eminent. 

At this point Tolkien brings in the numerous Catholic prophecies concerning
a once blessed kingdom bereft of it’s rightful king and plagued with uncertainty
similar to the political situation of France upon which many of the prophecies
revolve.Once unified by an absolute monarchy chosen by Heaven, France is now
tossed on the tides of opposing political parties and ruled by a president whom the
people look upon almost like a king,* but who can never be king similar to the
stewards of Gondor.The mystic Marie-Julie Jahenny revealed that France would
suffer greatly because it has no king, or rather, rejected its legitimate ruler. 9 “Ever
since Louis XVI died on the scaffold, France is threatened with danger and
misfortune.” 10 However, as Heaven promised in the prophecies the restoration of
the legitimate monarchy of France at one of humanity’s most darkest hours,
Tolkien now sets in motion the restoration of Gondor’s rightful king albeit from the 


8 ‘The Stewards’, Appendix A, Lord of the Rings, p. 1089. 

During the recent presidential campaigns in France, i.e.the elections of Presidents Sarkozy and
Holland, people interviewed on the street explained they did not view their president as the
Americans did, i.e.simply as an elected man with limited years of power. In contrast, the French
consider their president a temporary king. 

9 We Are Warned, Locution dated April 27, 1877., p. 54. 

10 Ibid.Christ to Marie-Julie, May 28, 1877, p. 56. 


18 



most humble and unlikeliest of places just when the black power of Mordor is 
reaching its height.

Returning to Lord of the Rings, we learn there are other people in Middle
Earth not descendants of the Eldar or the different races of Men, namely, hobbits
from the peaceful Shire, small men-like beings that have gone practically unnoticed
in the annuals of the land.The hobbit Bilbo Baggins stumbles upon the One Ring
of Power by accident during one of his adventures, and after using it to get out of
various scrapes, he leaves it to his nephew Frodo.During his travels Gandalf the
wizard learns that it is in fact the One Ring fashioned by the evil Lord Sauron.
However, he has dreadful news: Lord Sauron knows it has once again been found
and has sent the evil Nazgul kings to seek the current bearer.If it should ever 
return to its master, Gondor and the whole of Middle Earth is doomed.

The immortal Lord Elrond summons a council to be held at his regal home
in the elven valley of Rivendell, and it is decided that the reappearance of the Ring
may in fact be the opportunity the people of Middle Earth have been waiting for. If
the Ring is destroyed, not only would the temptation for others to wield it be
removed, but Sauron would ultimately lose his power and could be defeated once
and for all.It seems an impossible task, for there is only one way to destroy the
Ring ~ to throw it back into the volcanic fires from which it was forged in Mount
Doom situated within the very borders of Mordor itself. After much deliberation it 
is decided that if there is to be any hope of success in this perilous mission, a small
band or Fellowship must be formed that would have the advantage of stealth on its
side. Frodo steps forward and declares he will carry the Ring, since it has fallen to
him as his burden he refuses to relinquish this doom to another.Three other
hobbits, Sam, Pippin and Merry, agree to go with him, as well as Gandalf the
wizard, Boromir, the eldest son of the current Steward of Gondor, Legolas the elf,
Gimli the drawf, and an itinerant soldier-hunter or Ranger who is simply called 
‘Strider’ in the beginning of the tale, but whom we immediately discover is Aragorn
son of Arathorn, last of the Northern Line of Numenorean Kings. 


As their journey progresses, the members of the Fellowship are eventually
separated. Gandalf is lost in the underground caverns of Moria battling an ancient
fire-demon of the depths, Boromir is slain by ores, Frodo and Sam journey on to
Mordor in a near hopeless attempt to destroy the Ring, while Aragorn returns to
Gondor amidst the ravages of battle to claim his throne and in the process distract
Lord Sauron from the two hobbits attempting to make their way to Mount Doom.
Aragorn’s journey features several adventures that include Legolas, Gimli, Pippin
and Merry as his own quest to reclaim his throne is fulfilled, each member of the
Fellowship playing their part to aid the forces of good in Middle Earth and thereby
destroy the evil power of Sauron. 



Aragorn and the Prophecies of the Great Monarch



Turning to Aragorn, was his character actually inspired by Catholic
Tradition and prophecies? In the third book in the Lord of the Rings called The
Return of the King, we immediately discover that there is a distinct link between the
fictional king of Gondor and the historical Clovis I, the first King of France from 


19 




whom the Great Monarch of the Latter Days would descend.** As stated earlier,
after Clovis’ conversion to Christianity, he and the descendants of his blessed royal
bloodline were said to have been granted many mystical powers, especially the gift
of healing.In Tolkien’s work, we discover this is one of the principal signs that
would announce the appearance of the hidden monarch to the people of Gondor.

Aragorn enters the capital city for the first time after the Battle of the
Pelennor Fields, but as the war with Mordor is far from over, Aragom refrains from
entering as king or making his claim to the throne until he can ascertain the current
situation.Instead, he conceals his outward tokens of royalty, namely, the royal
banner and the Star of the North Kingdom lest they be challenged before the time is 
ripe, and orders he be announced in the city simply as a captain of the Rangers.
However, Gandalf urgently requests his assistance: Lord Faramir, son of the Last
Ruling Steward is dying, and Aragorn immediately attends to the worded lord,
saving his life.Immediately the prophetic sign is recognised: 

“Thus spake Ioreth, wise-woman of Gondor: The hands of
the king are the hands of a healer, and so shall the rightful king be
known.” 11 


Wasting no time in helping his people, Aragorn together with the immortal
sons of Elrond immediately set themselves to work, healing all who had been
wounded in the battle or had fallen under the evils of the Black Shadow, a freakish
paralysing dementia inflicted by the Nazgul witch-kings.News of his healing
powers spreads rapidly: 

“And word went through the City: ‘The King is come again indeed.’ ” 12 


Aragom heals the wounded using a humble-looking herb called athelas.The
plant also bears the regal name kingsfoil, or ‘king’s leaf, which is a curiosity as the
people are unaware it has beneficial properties and think it is nothing more than an
herb that is useful to freshen the air, but in Aragom’s hands its full power is released
and the meaning of the name is made clear. 


“Then taking two leaves, he laid them on his hands and
breathed on them, and then he crushed them, and straight-away a
living freshness filled the room, as if the air itself awoke and
tingled, sparkling with joy.And then he cast the leaves into the
bowls of steaming water that were brought to him, and at once all
hearts were lightened.For the fragrance that came to each was


Tolkien may have also drawn inspiration from French secular and sacred history for another character
in his epic, the heroic shield-maiden Lady Eowyn of Rohan, niece of King Theoden who was destined to
slay the chief Nazgiil. Refusing to stay behind, she rides into battle disguised as a soldier and defeats the
evil servant of Sauron whom no man may kill. Aragorn declares: “When I first looked on her ... it
seemed to me that I saw a white flower standing straight and proud, shapely as a lily...” (The Return of
the King, pp. 900-901). These details seem reminiscent of St.Joan of Arc (1412-1431), the ‘Maid of
Orleans’, who was called by heaven to defend the French monarchy and the kingdom.Joining the
soldiers and dressing in their attire, she rallied them to many victories against the invading English in the
Hundred ears’ War.She was ennobled by the king, her family name becoming ‘du Lys’, ‘of the Lily’. 
She was burned at the stake by the English in Rouen. “Rohan” is the anglicized word for Rouen.

11 Lord of 'the Rings, p.897. 

12 Ibid.p. 905. 


20 



like a memory of dewy mornings of unshadowed sun in some land
of which the fair world of Spring is itself but a fleeting memory.” 13 


Earlier in The Fellowship of the Ring , Aragorn reveals that the simple plant has
a noble origin, that it was brought to the mortal lands of Middle Earth from the
ancient Isle of Elenna, the lost homeland of the Numenoreans, hence its efficacy in 
his healing hands as the heir of Elendil.

Of interest, we find in the prophecies of the Catholic mystic Marie-Julie
Jahenny that the use of certain herbs will be important in the times of the
chastisements leading to the Days of the Great Monarch.Due to the evilness of
the times, deep black depression will afflict many and hitherto unknown plagues
will strike the earth, and according to her revelations Heaven was reminding
mankind that there are healing properties in herbs that will allay the symptoms
when human medicines will fail: “You will take the infusion of St.John’s wort,
especially during crisis (mental crisis?), sufferings of the chest and violent
headaches.Hawthorn for cholera.For unknown fevers, the humble violet, the
perfume and virtue of humility will have effect.” 14 According to a locution given by
the Mother of God, the white hawthorn is of particular importance as it will be the
only cure for one previously unknown plague that will strike: 


“There will be serious diseases that human art cannot
alleviate.This malady will attack the heart first, then the mind,
and at the same time, the tongue. It will be horrible. The heat that
will accompany it will be a consuming fire, so strong that the
affected parts of the body will be of an unbearable redness.After
seven days, this malady, like the seed sown in a field, will rise
rapidly and make immense progress, (i.e.incubate quickly?). My
children, this is the only remedy that can save you.You know the
leaves of thorns that grow in almost any hedges, (i.e.the white
hawthorn). The leaves of this thorn will stop the progress of the
disease. You must pick the leaves, not the wood. Even dry, they
will retain their effectiveness. Put them in boiling water and leave
them there for fourteen minutes, covering the container so that the
steam remains. When the malady first attacks, you must use this 
remedy three times a day. (...) The malady will produce a
continual uprising of the heart, (blood pressure? Increased heart
rate?) vomiting. If the remedy is taken too late, the affected parts
will become black, and in this black, there will be yellowish
streaks.” 15 


Hence, as the athelas of Aragom was considered a mean plant of little worth
but releases a fragrant healing balm in steam whether the plant is fresh or dried, so
shall the different tea infusions of St. John’s wort, the simple fragrant violet, and the 


13 Ibid. pp. 899-900. 

14 We Are Warned: The Prophecies ofMarie-Julie Jahenny, p. 578. 

15 Prophecy dated August 5, 1880. Ibid. pp. 578-579. 


21 



humble hawthorn bush of ditches and hedges will prove a sign and a saving grace 
for mankind. 

Returning to Aragorn, we find that he not only shares the same gift of
healing as the historical and divinely-blessed Clovis I, the first of the French kings, 
but he also shares similarities with prophecies of the Great Monarch who will
become a great defender of the Faith similar to his ancestor. We recall Aragorn
descends from the First King Elendil, who comes from a graced monarchy of
Middle Earth, a remnant of the blessed Faithful of Numenor. Aragorn is the
prophesied healer and restorer of his race similar to the Great Monarch foretold to
restore our own ‘Middle Earth’: 

“And Aragorn hearing him, turned and said, ‘Verily, for in 
the high tongue of old, I am Elessar, the Elfstone, and Envinyatar, 
the Renewer.” 16 

We also see other similarities between Aragorn and the Great Monarch in 
that his royal lineage remains hidden from his enemies, especially from the Black
Lord Sauron and his demonic minions until the time is right for him to reveal
himself. In fact, Aragorn is ignorant of his own bloodline during his childhood. 
After the death of his father, he and his mother are brought to the house of Lord
Elrond, who raises him as his own son and gives him the name ‘Estel’, eventually
disclosing the truth of his parentage when he grows older: 


“But he (Aragorn) was called Estel, that is ‘Hope’ and his 
true name and lineage were kept secret at the bidding of Elrond, 
for the Wise then knew that the Enemy was seeking to discover the
Heir of Isildur, if any remained upon the earth.” 17 


As mentioned earlier, Marie-Julie Jahenny had affirmed that the Great
Monarch destined for the future would be a hidden descendant of the ‘King and
Queen Martyrs’, that is, the guillotined King Louis XVI and Queen Marie- 
Antoinette. 18 Her visions continually reveal that the Great King would remain
hidden until the time was ripe for his appearance; “Poor child exiled, you will see
your homeland, welcomed by your tears.” 19 According to the prophecies, he will
have many enemies, hence the necessity to keep his lineage hidden until the proper
time, and we see Aragorn is compelled to remain hidden for the same reason. 


16 Lord of the Rings, The Return of the King, p. 897. 

17 Ibid, Appendix A, pp. 1094. 

18 Marie-Julie continually affirmed this revelation of the 'King and Queen martyrs' to the Marquis
de la Franquerie, who assumed she meant Louis XVI and Marie-Antoinette, and included this detail 
in his book, The Breton Stigmatist, p. 52. See We Are Warned, p. 432. The Marquis also assumed
Marie-Julie meant there was a hidden bloodline waiting to be discovered, and Tolkien may have
been inspired by this theory. However, Marie-Julie never mentioned a hidden bloodline, and in fact, 
already identified who the king was and would be: Henry V, the Count of Chambord (1820-1883). 
According to her revelations, he is still destined to fulfil future prophecies. For more information, 
see the article, Marie-Julie Jahenny, the 'Breton Stigmatist', Her Life and Prophecies'. 

www.mysticsofthechurch.com/2015/07/marie-iulie-iahenny-breton-stigmatist.html 

19 Words of Christ to Marie-Julie describing the King, (June 1, 1, 1877), We Are Warned, p. 58. 


22 




In addition, the Great but hidden King will not be recognised at first, the fact
he remains true to the Faith and refuses to doubt the Divine promise he will be
brought forth out of exile will cause him to be ridiculed as “incompetent” for the
task. The Great Monarch will be slandered and mocked like the kingship of Christ
was before the Crucifixion, he will be deemed the most “despised of men” and will
have to bear the “mantel of abomination”, even his few loyal followers will be
mocked in the same way before his claim to the throne is recognised and accepted. 20 

In Lord of the Rings, we discover that Aragorn suffers similar abuse. After he
leams the truth of his parentage, Elrond reminds Aragorn he must prepare for the
test that lies ahead of him before he may worthily wield the royal sceptre. 
Therefore, Aragorn leaves the house of Elrond and for thirty years he enters the
wild as a Ranger and leader of the northern chieftains, learning sword-craft and the
arts of war in preparation for the destiny that awaits him, fighting valiantly against
the evil plots of Lord Sauron in secret, joining the armies of other kings under
various names. However, his anonymous life as a Ranger is a hard one, a homeless
existence filled with restless wandering and many battles, a ‘man of the wild’ who is 
shunned by all ‘respectable folk’. This hard life takes its toll on his appearance, 
causing him to be severely misjudged. This is our first introduction to ‘Strider’: 


“Suddenly Frodo noticed that a strange-looking weather¬ 
beaten man sitting in the shadows near the wall, was also listening 
intently to the hobbit-talk. (...) His legs were stretched out before 
him, showing high boots of supple leather that fitted him well, but 
had seen much wear and were now caked with mud. A travel- 
stained cloak of heavy dark-green cloth was drawn close about 
him, and in spite of the heat of the room, he wore a hood that 
overshadowed his face, but the gleam of his eyes could be seen as 
he watched the hobbits. (...) As Frodo drew near he threw back 
his hood, showing a shaggy head of dark hair flecked with grey, 
and in a pale stem face a pair of keen grey eyes.” 21 


In some places such as the town of Bree, his mysterious presence under the 
name of ‘Strider’, plus his travel-worn apparel, earn him mistmst and the bmnt of 
ridicule as a drifter among men, which ‘Strider’ grimly jokes about: 


“No, I don’t think any harm of old Butterbur. Only he 
does not altogether like mysterious vagabonds of my sort.’ Frodo 
gave him a puzzled look. ‘Well, I have rather a rascally look, have 
I not?’ said Strider with a curl of his lip and a queer gleam in his 
eye.” 22 

At first, even the hobbits think he is a highway rogue and are wary of him. 

Sam remarks: “He comes out of the Wild, and I never heard no good of such folk.” 


20 Christ to Marie-Julie. Ibid. p. 284. 

21 Lord of the Rings, The Fellowship ofthe Ring, pp. 172-173. 

22 Ibid. p. 180. 

23 Ibid. p. 182. 


23 



Nevertheless, ‘Strider’ is patient and quietly takes the slander and abuse of the 
townspeople: 


“Over the hedge another man was staring boldly. He had 
heavy black brows, and scornful dark eyes, his large mouth curled 
in a sneer. He was smoking a short black pipe. As they 
approached he took it out of his mouth and spat. 

‘Morning, Longshanks!’ he said, ‘Off early? Found some 
friends at last?’ Strider nodded, but did not answer. 

‘Morning my little friends!’ he said to the others. ‘I suppose 
you know who you’ve taken up with? That’s Stick-at-naught 
Strider, that is! Though I’ve heard other names not so pretty. 
Watch out tonight !’.” 24 


Yet by now the hobbits have received a letter from Gandalf hinting at 
Strider’s true identity in verse, warning them not to mind outward appearances: 


\All that is gold dos not glitter, 

Not all who wander are lost; 

The old that is strong does not wither, 
Deep roots are not reached by the frost. 
From the ashes a fire shall be woken, 

A light from the shadows shall spring; 
Renewed shall be blade that was broken, 
The crownless again shall be king .” 25 


However, Aragorn is still mistrusted at times; his appearance looks anything 
but regal and the prophecies seem too much to believed, even during the great 
Council of Elrond when the weighty matters of the Ring are weighed. Boromir, 
son of the current Steward of Gondor, still doubts Aragom’s words despite having 
seen with his own eyes the royal token of the Broken Sword that would one day be 
re-forged in addition to hearing Lord Elrond himself confirm Aragorn’s claim that 
he is indeed the true heir: 


“(...) Now you have seen the sword that you have sought, 
what would you ask? Do you wish for the House of Elendil to 
return to the Land of Gondor?”(Aragorn) 

‘I was not sent to beg any boon, but to seek only the 
meaning of a riddle,’ answered Boromir proudly. ‘Yet we are hard 
pressed and the Sword of Elendil would be a help beyond our hope 
—if such a thing could return out of the shadows of the past.’ He 
looked again at Aragorn, and doubt was in his eyes .” 26 


24 Ibid. p. 197. 

25 Ibid. p. 186. 

26 Ibid, p.265. 


24 



Aragorn still forgives the proud lord of Gondor: 

“ ‘For my part, I forgive your doubt, he said. ‘Little do I 
resemble the figure of Elendil and Isildur as they stand carven in 
their majesty in the halls of Denethor. I am but the heir of Isildur, 
not Isildur himself. I have had a hard life and a long; and the 
leagues that lie between here and Gondor are a small part of in the 
count of my journeys. (...) Lonely men are we, Rangers of the 
wild, hunters—but ever of the servants of the Enemy; for they are 
found in many places, not in Mordor only .” 27 


Aragom continues to describe the great service he and the Rangers of the 
North have provided the people of that region who are ignorant of the good they 
do, securing the peace and freedom for a time, yet they receive next to little or no 
thanks for their lonely life of toil and instead are slandered in return and given 
scornful names. Yet Aragorn and the last of his people in the Northern Kingdom 
do not regret their noble and chivalric mission to protect the weak: “If simple folk 
are free from care and fear, simple they will be, and we must be secret to keep them 
so. That has been the task of my kindred, while the years have lengthened and the 
grass has grown .” 28 Silent, humble, brave and virtuous, rarely throughout the tale 
does Aragorn reveal his identity, only when need or duty demands it. Even Prince 
Imrahil, who recognises Aragom’s wisdom in concealing his royal tokens, is 
dismayed that Aragorn should enter Minas Tirith, the city of Gondor, after their 
first victory without regal recognition paid him: “Yet I would not have you remain 
like a beggar at the door .” 29 However, Aragorn insists on being announced as 
Captain of the Rangers, as mentioned earlier. In all, Aragorn for a time was 
hidden, mocked and deemed the most despicable of men similar to the how the 
Great Monarch will first be received. 

Of interest, we find that several prophecies concerning the Great Monarch of 
France are similar to Aragorn’s life as an unknown roving Ranger from the North: 
he will be a solider who defends his country, driving the enemies of France towards 
the south. Some say he will come from the east and work southward, but one 
revelation in particular mentions he will actually enter from the north of France and 
drive his enemies south, eventually coming to the aid of the Pope: 


“(...) I will return to your subjects and your people he who 
bears on his head the same flower that you love. This flower is the 
lily (fleur-de-lys), O King, miracle child, do not prepare to come 
from exile under a thick dust stirred up by the fury of the 
murderers of your country. (...) From the north of the borders your 
noble person will pass through the legions who only wait to rise up 
(in) vengeance, (i.e. legions of enemies). But, as in the days of 
darkness, their eyes will be veiled, the exile will be returned and 
My Justice will be accomplished. You will pass to reclaim the sceptre 

27 Ibid. 

28 Ibid. p. 266. 

27 Ibid. The Return of the King, p. 895. 


25 



of glory. You will temper the tip in the blood of Romans, in the 
defence of the Sovereign Pontiff, the bond of all the faithful .” 30 


Of interest, we observe the Great Monarch with a ‘lily’ on his brow he will 
reclaim the ‘sceptre of glory’. According to French tradition, the title of king was 
already conferred by the Divine Right of Kings by God in Clovis I, hence the 
universal acclaim of ‘The King is Dead, Long Live the King’ after the death of the 
previous monarch was the official ‘coronation’ and recognition of the people, the 
crowning was a royal formality added later. In the numerous prophecies of Marie- 
Julie the lily or fleur-de-ly is often described as white, and represents his purity and 
his justice. We find a very close parallel in Tolkien’s work as the ancient 
Numenoreans regarded the sceptre the chief token of nobility, and like the Great 
Monarch with the White Lily, the Numenorean kings wore a white royal gem on 
their brow, obviously the white Star of the North Kingdom that Aragorn wears at 
the Battle of the Pelennor Fields, but conceals before his entrance into Gondor: 


“The sceptre was the chief mark of the royalty in Numenor, 
(...) and that was so in Arnor (i.e. the Northern Kingdom), whose 
kings wore no crown, but bore a single white gem, the Elendilmir, 
Star of Elendil, bound on their brows with a silver fillet .” 31 


Eventually, in Tolkien’s kingdom the practise of crowning the king was 
added later to the Numenorean ritual similar to the Kings of France from whence 
the Great Monarch will descend. Also, the Numenorean kings wore an unusual 
jewelled crown fashioned after a soldier’s helm, obviously paying tribute to their 
lineage as soldier-kings and defenders of Middle Earth; again, another possible link 
to the Great Soldier-Monarch of Catholic prophecy: 

“The crown of Gondor was derived from the form of a 
Numenorean war-helm. In the beginning it was indeed a plain 
helm, and it is said to have been the one that Isildur wore in the 
Battle of Dagorlad (for the helm of Anarion was crushed by the 
stone-cast from Barad-dur that slew him). But in the days of 
Atanatar Alcarin this was replaced by the jewelled helm that was 
used in the crowning of Aragorn .” 32 

Furthermore, Aragorn’s royal gem, the white Star of the Northern Kingdom, 
bears a striking resemblance to one of the mighty signs in the sky that will 
accompany the Great Monarch when he assembles his armies near the Rhine and 
begins to drive out his foes. This sign will arise and appear from the West: 


30 The Lord to Marie-Julie Jahenny, March, 22, 1881, We Are Warned, pp. 278-279. 

31 Lord of the Rings, The Return of the King, Appendix A, (note 1), p. 1080. 

32 Ibid. 


26 



“Amid these bloody and frightening signs, (i.e. red signs in 
the sky like blood) there will be a white light that will surpass the 
beauty of the dawn. (...) A white sign to the west of France, 
surrounded by a curtain of diamond fringes, enormous, the space 
of three quarters of an hour. Your homes will be lit up as if by the 
sun. (...) It will be as an ornament in the sky, in the form of a square 
star, bearing in its middle a sceptre and a crown, that will be well 
distinguished by the people of the earth .” 33 


Aragorn, who is also called a Dunadan, Numenorean Man of he West , 34 has 
similar miraculous signs that announce his arrival like the Great Monarch, such as 
the sign of the White Star of the Northern Kingdom. During the course of their 
journey, Aragorn majestically reveals himself to Eomer, Third Marshal of 
Riddermark, and although he does not wear the noble jewel, Prince Legolas the elf 
witnesses a royal sign hover over Aragorn’s brow: 


“Gimli and Legolas looked at their companion in 
amazement, for they had not seen him in this mood before. He 
seemed to have grown in stature while Eomer had shrunk, and in 
his living face they caught a brief vision of the power and majesty 
of the kings of stone. For a moment it seemed to the eyes of 
Legolas that a white flame flickered on the brows of Aragorn like a 
shining crown .’’ 35 


When Aragorn rides forth to battle in the Pelennor Fields, he wears the 
Royal Insignia of the Northern Star, he bears the Broken Sword now re-forged, 
which emits powerful Elven flames. His Royal Standard is now unfurled to the 
bewilderment of his enemies, and he is followed by a terrifying phantom host 
mustered from the Paths of the Dead as foretold in prophesy, a great and 
unconquerable army of dead warriors, former allies who had broken their oath to 
aid Gondor and were punished for their treachery. For centuries they were doomed 
to haunt the Paths of the Dead until an heir to the Kingdom came forth and 
demanded they fulfil their oath, after which they would finally be granted eternal 
rest: 


“And all eyes followed his gaze, and behold! Upon the 
foremost ship a great standard broke, and the wind displayed it as 
she turned towards the Harlond. There flowered a White Tree, 
and that was for Gondor; but Seven Stars were about it, and a high 
crown above it, the signs of Elendil that no lord had borne for 
years beyond count. And the stars flamed in the sunlight, (...) 

Thus came Aragorn son of Arathorn, Elessar, Isildur’s heir, out of 
the Paths of the Dead, borne upon a wind from the sea to the 
kingdom of Gondor (...) But the hosts of Mordor were seized with 

33 The Virgin Mary to Marie-Julie Jahenny, (November 21, 1882), We Are Warned, pp. 339-340. 

34 Lord of the Rings, The Fellowship of the Ring, p. 249. 

35 Ibid. The Two Towers, p. 454. 


27 



bewilderment (...) and a black dread fell on them, knowing that the 
tides of fate had turned against them and their doom was at hand. 
(...) But before all went Aragom with the Flame of the West, 
Anduril like a new fire kindled, Narsil re-forged as deadly as of 
old; and upon his brow was the Star of Elendil.” 36 


Returning to Catholic prophecy, the Great Monarch will not only be 
accompanied by a great army aided by angelic hosts, according to several of Marie- 
Julie Jahenny’s visions and other mystics, he will have a great royal standard, the 
White Flag or Banner of the Absolute Monarchy to which no enemy could 
withstand, in addition to miraculous signs. St. John Bosco (1815-1888) also had a 
vision of a ‘great warrior’ king who would come from the north bearing a black 
standard that would turn white, in the middle of which was written, “the name of 
Him who is able to do all things,” 37 which bears a striking mystical similarity with 
Tolkien’s royal black and white standard of Gondor. 

In Tolkien’s fictional kingdom, the various symbols on Aragorn’s royal 
banner represent the Exiled Faithful after the destruction of their beautiful island 
kingdom of Numenor and their arrival on Middle Earth. The White Tree stands 
for Gondor and also the royal house, for Elendil brought with them a blessed 
seedling: a descendant of Telperion, one the famed Eldest of Trees that gave light in 
the Undying Lands of the Valar from which the famed Silmarilli Jewels were made 
as we learned earlier from the chronicles. Although the evil entity Morgoth had 
poisoned the two trees, Telperion bore fruit from which its likeness was preserved 
in the circles of the world for age upon age. Henceforth, a descendent from the 
royal lineage of this tree was also planted in the royal courtyard of Gondor. The 
Seven Stars represent the First King Elendil and his captains vis the seven ships that 
each bore a Seeing Stone from Numenor, powerful crystals with which the kings 
and leaders of the Numenorean exiles kept in communication with each other. 

First, we must examine the legends of the tree. As mentioned, Tolkien’s two 
blessed trees may have been inspired by the Two Trees of Paradise: Knowledge and 
Life. One of Tolkien’s trees, Laurelin, is poisoned before it bore fruit, hence all 
likeness of the tree died when it perished, while Telperion’s descendants continued 
to beget a likeness of its parent throughout the ages and is associated with the 
blessed and Faithful remnant race of Numenor. This appears remarkably close to 
the fate of the Biblical trees: mankind was ‘poisoned’ by original sin in disobeying 
God by eating from the Tree of Knowledge, and therefore man was banned from 
approaching the Tree of Life until the Saviour was sent to redeem the human race. 
Throughout the Bible, the Tree of Knowledge is not mentioned again, perhaps 
represented by Laurelin that is wiped out forever, but the Tree of Life appears again 
in the Apocalypse—those who remain faithful to Christ and His rule are saved and 
shall be permitted to partake of its fruits in the Heavenly Kingdom, symbolised by 
Tolkien’s Telperion: 


“And he showed me a river of water of life, clear as crystal, 
proceeding from the throne of God and of the Lamb. In the midst 


36 Ibid. The Return of the King, p. 881. 

37 We Are Warned, p. 559. 


28 




The Royal Standard of Gondor 



“The Tree of Life”, miniature by Pacino di Bonaguida, Florence (1305-1310). 

Christ is allegorically depicted as the Tree of Life opening heaven to mankind, the events of 
His life and the foundation of the Church are depicted as fruits. 




























of the street thereof, and on both sides of the river, was the tree of 
life, bearing twelve fruits, yielding its fruit every month, and the 
leaves of the tree were for the healing of the nations. And there 
shall be no curse anymore, but the throne of God and of the Lamb 
shall be in it, and his servants shall serve him. And they shall see 
his face; and his name shall be on their foreheads.” (Apoc. 22:1-4) 


Often the Cross is also described as the Tree of Life since by Christ’s 
sacrifice as the ‘Lamb of God’ on the ‘tree’, + Heaven was once more opened to the 
human race. Hence, the name of Christ, God and Lamb, the “name of Him who 
can do all things” on the Great Monarch’s black and white banner as described by 
St. John Bosco is also symbolically represented by the White Tree of Gondor set 
upon a black background, a figurative representative of the Tree of Life. 

Yet, what about the seven stars? In the first chapter of the Apocalypse, we 
discover a direct correlation between Seven Stars, Seven Angels, and Seven 
Candlesticks representing Seven Churches before Christ the King, (Apoc. 1:20). 
These symbols represent both the Seven Archangels that stand before the heavenly 
throne of God and the seven principal bishops of that time, also called ‘messengers’ 
or ‘angels’ of God’s Kingdom on earth, a direct mystical image of Christ’s Eternal 
Kingdom in Heaven and the Church on earth. However, the Great Monarch to 
come is also represented in this symbol, for in accordance with the Divine Right of 
Kings his arrival on the earth will be a secular representation of Christ’s eventual 
return to earth. As Christ restored all, the Great Monarch will help the Church 
renew the face of the earth before the End Times. Hence, we also see a link 
between Aragorn and his title ‘the Renewer’ through his Faithful Numenorean 
ancestors symbolised by seven stars. 

We cannot help but notice that ancient maps of our own ‘Middle Earth’ 
depict the Mediterranean Ocean as a ‘tau’ or T-shape, and Tolkien may also have 
been inspired by this mystic representation with regards to the White Tree of 
Gondor. St. Isidore of Seville (560-636 AD) provided one of the earliest depictions 
of the earth in Western civilization in his famous encyclopaedia Etymologiae ~ the 
T-0 Map ~ the World Circle represented by the ‘O’ featuring Jerusalem in the 
centre of the earth, with Asia (the East) situated on top, Europe (North) on the left, 
and Africa (South) on the right, all separated by the Mediterranean ‘Middle Earth’ 
Ocean and the rivers Nile and the Don, these bodies of water marking the letter ‘T’ 
or sacred ‘tau’ in the lower section of the World Circle. The Mappa Mundis or 
World Maps of Europe were drawn according to St. Isidore’s mystic plan of the 
earth, that is until the discovery of the New World and north was placed on the top 
of cartographer’s maps. Curiously, the ‘T’ in these Mappa Mundis bear a rough 
resemblance to a tree. Of interest, the tau was used as a symbol of Christ’s cross, the 
‘Saving Tree’ of mankind, and in the medieval period a tau-cross was a sign of 
renewal adopted by the Franciscans. When compared with the ‘Seven Stars’ of the 
Seven Churches of the Apocalypse situated near the west coast of present day 
Turkey, we see the ‘stars’ are situated roughly in the middle of the tau-cross and 
figurative ‘tree’ of the medieval Mediterranean Sea. In Lord of the Rings 


1 St. Peter described the cross as a ‘tree’ in Acts 10:39: “And we are witnesses of all things that he 
did in the land of the Jews and in Jerusalem, whom they killed, hanging him upon a tree,” also in 
the First Epistle of St. Peter (2:24) “Who his own self bore our sins in his body upon the tree: that 
we, being dead to sins, should live to justice: by whose stripes you were healed.” 


31 




Psalter illumination of a T-O Mappa Mundi with Christ and His Angels ruling from 
the East. Date between 1200 and 1250 A. D. Jerusalem is in the centre, with the 'monstrous 
races of men' are depicted in Africa to the south on the far right. Notice the green-hued T- 
shape of the Mediterranean ocean resembles a tree. 







JU> LIWVV l ill'UlUllllLy 

ac t (\ttApp£ fi m dual partes oiurn 



teas 7 


fpaiadt^ cfc tocttC monettfcfc pat* 

1. rjlt+4'll r-o frrlod 


(Above) A mystical representation of the world in a T- O diagram dating from the 12 th century 
based on St. Isidore's map. Asia is on the top, Europe to the left, Africa to the right. The 
principal oceans and bodies of water in the Mediterranean and surrounding areas is represented 
by the red T, or tau cross. (Below) T- O Mappa Mundi illumination attributed to Simom 
Marmion in Jean Mansel's La Fleur des Histoires. Valenciennes, (1459- 1463). 
























The Hereford Mappa Mundi (1300s) 


Another classic T-O map, with Jerusalem at the centre of the World Circle. Notice the T- 
shape of the Mediterranean Ocean also resembles a tree in this map. The Seven Churches, 
Seven Candlesticks, Seven Stars of the Apocalypse (not shown) are located on the west coast of 
present day Turkey, which is roughly situated in the left 'branch' of the tree. 







Tolkien emphasises the Kings of Gondor were sea kings,** and considering his love 
of all things ancient, Tolkien may have hinted to this hidden map-symbolism of the 
‘sea-tree’ with the seven stars in the Mappa Mundi of ‘Middle Earth’ in his fictitious 
royal standard of Gondor featuring the White Tree and the Seven Stars. 

On other miracles or signs in Catholic prophecies, we further note that 
according to Marie-Julie Jahenny there would be ‘resurrections’ during these great 
and terrifying times when the hidden King will appear on earth: “There will be 
great signs in this reign, there will be resurrections, there will be wonders of 
protection for My souls that I want to guard to raise up the good, to (make them) 
flourish once again.” 38 We note resurrections of the dead occurred when Christ 
established His spiritual Kingdom on earth in the Church, which took place at the 
Crucifixion: great signs occurred, there were earthquakes, darkness covered the 
earth, and “the graves were opened: and many bodies of the saints that had slept 
arose, and coming out of the tombs after His resurrection, came into the holy city, 
and appeared to many.” (Matt. 27:51-53) It would seem the Great Monarch shall 
have the same wonders attend the commencement of his reign. Possibly, Aragorn’s 
journey to the Paths of the Dead to raise an invincible army in order to rescue the 
City of Kings and claim his throne was inspired by these momentous signs and 
prophecies. 

Furthermore, Tolkien’s eye for detail concerning noble weapons and their 
exquisite craftsmanship in Lord of the Rings suggests he may have drawn inspiration 
for famous jewels of old. Is it possible Aragorn’s famed sword may have several 
symbolical connections with the Great Monarch’s weapon as future King of France 
and Holy Roman Emperor? Fet us recall a sentence from a prophecy quoted 
earlier: the Great Monarch would bear a sceptre that would be used like a spear to 
“... temper the tip in the blood of Romans, in the defence of the Sovereign Pontiff.” 
The monarchs of France possessed a very unusual sceptre in their coronation 
treasury, the Main de Justice, or Hand of Justice; a slender rod on which sits a 
delicate figure of a hand poised in a gesture of blessing representing the Hand of 
God. No doubt the form of the sceptre represents the Divine Right of Kings 
miraculously revealed through Clovis I. St. John Bosco in his vision saw this 
Divine Right would be renewed in the Great Monarch to come, for the hand that 
supported the Royal Banner had written on it in mystical letters, “The Irresistible 
Hand of the Ford”. In a mystical form, the Great Monarch would have God’s 
authority as a weapon to save the Pope and uphold the authority of the papacy 
similar to his ancestors, the French Kings of old. Yet, the Great Monarch also has 
an allegorical ‘spear’, and this may indeed refer to an historical sword. According 
to tradition and legends of old, the Coronation Sword of Charlemagne called 
Joyeuse contained a fragment from the Spear of Fonginus, the spear that pierced the 
side of Christ at the crucifixion. We note Bl. Anne Catherine Emmerich explained 
the mystic significance of the spear-thrust through the side of Christ: “Jesus 
received the stroke of the lance in His right side, and the Church came forth from 
the same right side. When we enter the Church, we enter into the right side of 

In addition to the stars representing the seven ships bearing a Seeing Stone, the sea was 
represented in the Royal Helm-crown of Gondor. On either side it bore wings in the shape of a sea¬ 
bird, “for it was the emblem of kings who came over the sea.” Also, the coronation declaration of 
the Kings of Gondor are an exact repetition of Elendil’s words as he and the Faithful Exiles set foot 
on Middle Earth; “Out of the Great Sea to Middle-Earth am I come. In this place will I abide, and 
my heirs, unto the ending of the world.” Lord of the Rings, The Return of the King, pp. 1003-1004. 

38 Christ to Marie-Julie, referring to the Reign of the Sacred Heart, which will also flourish in the 
era of the Great Monarch. (November 13, 1924). Ibid. p. 380. 


35 



Jesus, and we are in Him united to His Heavenly Father.” 39 Hence, Christ’s 
spiritual kingdom on earth was initiated in a baptism of Water and Blood with the 
spear of Longinus, a piece of which is kept secure in the sword of French kings, a 
prized item among the surviving crown jewels of France. 

We may observe an important link with a second sword: when Imperial 
kings were crowned as Holy Roman Emperor, they also received an Imperial 
coronation sword. The Imperial Sword was decorated and embellished over the 
years, but it bears several interesting inscriptions in Latin: CHRISTVS: VINCIT: 
CHRIS TVS: REIGNAT: CHRISTVS: INPERAT , “Christ triumphs, Christ reigns, Christ 
rules”, which has also been interpreted as, “Christ the Victor, Christ the King, and 
Christ the Emperor”, a reminder that imperial rule comes from a divine origin. 
There is another inscription on the pommel: BENEDICTVS ■ DO[minv]S DE[v]S QVI 
DOCETMANVfsJ: 'Blessed be the Lord my God, who teaches the hand [to fight]”, 
which is an abbreviation of Psalm 143:1, 40 Benedictus Dominus Deus mens, qui docet 
manus meas ad prcelium, et digitos meos ad bellum (Blessed be the LORD my God, who 
teacheth my hands to fight, and my fingers to war ). According to tradition, history 
and the prophecies, the French Kings and the Holy Emperors were duty-bound to 
protect the Church and defend the Faith and the Papacy. As the Great Monarch 
will be King of France and Emperor from the West, both swords will symbolise his 
reign and the great mission he will accomplish: a ‘sceptre-spear’ of kingly rule, the 
Hand of God that will smite the enemies of the Church, restoring both the secular 
and spiritual world. 

Yet, where is this mystic symbolism in Lord of the Rings? How does this 
symbolism of the ‘sceptre-spear’ link to Aragorn’s famed sword Narsil? Of course, 
the Royal sceptre and the Sword Reforged are symbols of Aragorn’s legitimacy, but 
we find additional clues linking them to a spear in Tolkien’s chronicles where the 
breaking of the blade is recounted. When the First King Elendil and the High Elf 
Gil-galad lead the battle against Lord Sauron after the Rings of Power are made, 
Gil-galad fights his enemy with a noble spear named Aiglos: both the spear and the 
sword are mentioned as important details in this chronicle. 41 However, after the 
two heroes are slain, no more is heard about the spear, yet while Narsil may be 
shattered, it is not lost to history. The shards are kept by his heirs and eventually 
reside in the house of Lord Elrond until the time comes for the sword to be 
remade. The appointed time arrives when the Fellowship of the Ring is formed and 
Aragorn prepares to emerge from exile and fight his foes. Narsil is re-forged by 
Elvish smiths and they infuse new power into the blade. When striking an enemy 
or raised up on high, the blade sends forth white or red flames, thus Aragom gives 
it a new name, Anduril, ‘Flame of the West’. Hence, as the French Sword of 
Charlemagne allegedly held a piece of the Holy Spear that impaled the Heart of 
Christ and established His spiritual Kingdom via the Church, it is possible the red 
and white flames of Anduril may symbolise the Blood and Water that poured forth 
from the side of Christ as the spear struck, for red and white rays are often used to 
depict the Blood and Water in religious art. The Great Monarch shall be a Great 


39 The Life of Jesus Christ and Biblical Revelations, Vol. I, p. 84. 

40 A psalm of David against Goliath. Numbering: Catholic Douay-Rheims edition. 

41 Lord of the Rings, The Fellowship of the Ring, p. 264, 


36 




(Top Left) A Main de Justice (c. 10 th century), a surviving piece of the crown jewels housed in the 
treasury of St. Denis. At one time the treasury had three: this could by the St. Louis sceptre, or 
another main de justice that was allegedly made from 'unicorn's horn'. + (Top Right) The Imperial 
Holy Spear, the point contains a Roman nail believed to be the Nail of the Crucifixion. 
(Bottom) The Imperial Sword of the Holy Roman Emperors and its gold sheath. 



+ Dom Michel Felibien, Histoire de L 'Abbaye Royale de Saint-Denys en France (1706). 








Charlemagne's Joyeuse, sword of the French Kings. 


According to tradition, a piece of Longinus' spear is concealed in the pommel. 




Renewer of the Holy Roman Empire and the Church.* Aragorn is a descendent of 
the Faithful Elendil and is called ‘the Renewer’. 

Furthermore, just like the Imperial Sword with its Latin inscription 
promising everlasting Victory to Christ through the Emperor’s rule, the High Elves 
of Lorien give Aragorn a priceless gift for his sword Anduril, a sheath overlaid with 
silver and gold flowers with runes listing the name of the sword and its noble 
lineage. It is promised that the blade drawn from that sheath would never be 
stained or broken in defeat. In addition to the promise the blade will never be 
broken again, Aragorn reveals that only the heirs of Elendil may touch or wield the 
sword, it appears to be protected by a deep power of ‘Old’ or ‘On High’: “Telchar 
first wrought it in the deeps of time. Death shall come to any man that draws 
Elendil’s sword save Elendil’s heir.” 42 These details reveal Aragorn shall never 
know defeat and pretenders to the throne shall never again reign over Gondor 
similar to the promises concerning the Great French Monarch. It is predicted when 
his kingdom is established France will never lose the Faith and its royal rule would 
last until the end of time. 43 Perhaps for Tolkien the shattered shards of the Broken 
Blade re-forged represented the relic-shards of the spear of Longinus that opened 
the side of Christ and brought forth the birth of the Church, which are currently 
scattered throughout the Christian world? Anduril is re-forged as a symbol of unity 
between the kingdoms of the North and South never to be defeated or broken again, 
just as the Faithful Great Monarch would reunite the various Christian churches 
under One Church as stated in the prophecies. In the end of Lord of the Rings, 
Aragorn unites both the North and South Kingdoms which had been divided for 
centuries, in addition to all the smaller kingdoms of Middle Earth that are 
permitted the royal boon to govern themselves yet under his rule as High King: a 
last link with the Great Monarch who will restore all the former kingdoms of 
Europe and rule over them as Holy Roman Emperor as Charlemagne in ages past. 

As we have seen, Tolkien’s character Aragorn bears a striking resemblance 
to the prophecies of the Great Monarch, which leads us to consider other intriguing 
questions: did the corresponding revelations concerning an ‘Angelic Pope’ also 
influence Tolkien’s development of another character? If so, who could it possibly 
be? 


The Imperial Coronation regalia of the Catholic Holy Roman Emperors also features a ‘Holy 
Spear’, but this is believed to contain the famous relic of the nail from the Crucifixion once owned 
by Emperor Constantine and a not a piece of Longinus’ spear. In fact, a piece of metal consistent 
with the shape and size of a first-century Roman nail has been found incorporated into the 
spearhead. Recent metallurgy tests show the Holy Spearhead was recast circa the seventh century, 
making it the oldest piece in the Imperial Regalia. There is an interesting theory that the Holy Spear 
actually featured in Charlemagne’s coronation as King of the Lombards in 774 AD, thus explaining 
how it came into the possession of the Holy Roman Emperors. The Lombard kings had a tradition 
of using an ancient spear in their coronation ceremony, and Charlemagne may have been crowned 
King of Italy in the same manner as the Lombards, i.e. grasping a spear. Considering that Milan 
was their capital as in the times of Emperor Constantine, it is believed that this spear does indeed 
contain the Nail of the Crucifixion. Of interest, historians have observed that in 585 AD the 
Merovingian (Frankish) king Guntram officially designated his nephew Childebert II his heir by 
handing him his lance; it is possible that a royal lance was a symbol of kingship among the 
Merovingian kings in addition to the sceptre. In all, Aragorn’s royal signs of legitimacy, the 
Numenorean sceptre and Anduril that bears mystical flames associating it with Longinus’ spear, 
display consistent links with the dual kingship of the prophesied Great Monarch of France and his 
restoration of the Christian Holy Roman Empire represented in the Holy Spear of the Imperial 
Regalia. 

42 Lord of the Rings, The Two Towers, p. 533. 

43 Christ to Marie-Julie, (October 27, 1875), We Are Warned, p. 38 


39 



The Angelic Pontiff 


Is there a ‘pope’ in Lord of the Rings! To answer this, we would first have to 
determine if Tolkien found some way to represent the Catholic priesthood and its 
hierarchy in his mythical world of elves, dragons, hobbits and semi-mortals without 
blatantly crossing the line into heresy, or stray too far into fantasy for that matter to 
where the links between fact and fiction are blurred beyond recognition. He would 
need to depict a ‘priesthood’ of sorts in his narrative, or how could any of his 
characters represent a Great Pope, the highest priest in the hierarchy of the Church 
after Christ? 

We detect Tolkien found a solution by keeping the ‘religious’ aspect of his 
narrative centred on the absolute concepts of Good inevitably triumphing over Evil, 
and avoided many thorny issues by interpreting the priesthood itself in very general 
mystical terms, portraying it in a manner without delving too deep into the details 
of Catholic ritual and doctrine. In fact, we hardly see an organized religion per se 
in Lord of the Rings, but we do find clues that an ‘idolatrous’ belief was replaced by a 
‘true faith’, for there is evidence that the ‘lesser men’ of Middle Earth were pagans 
once under the Dark Lord before the ‘Greater Races’ converted them to the ‘One’ 
God at some point in their history as Lord Denethor remarks as he lights a funeral 
pyre: “We will bum like heathen kings before ever a ship sailed hither from the 
West.” 44 Of interest, we see Gandalf attempts to reason with the despairing 
Denethor and prevent him from burning his son while he is yet alive, reminding 
him he is a descendant of the Faithful Numenoreans and must not fall into the 
errors of the ancient heathens: 


“Authority is not given to you, Steward of Gondor, to order 
the hour of your death, and only the heathen kings, under the 
dominion of the Dark Power, did thus, slaying themselves in pride 
and despair, murdering their kin to ease their own death.” 45 


Hence, if there is a general Judeo-Christian ‘religion’ hinted at in Lord of the 
Rings, where is its priesthood? No doubt the reader may already be asking; surely, 
you are not suggesting Gandalf. A wizard? How can a wizard represent a Catholic 
priest let alone a pope? Is not magic condemned by the Church? However, if we 
consider how Tolkien used the word ‘wizard’, the answer becomes clear. 

In the Index provided in Lord of the Rings we discover that the term ‘wizard’ 
is used in two very different contexts; the first is when the ignorant, the vulgar, or 
the simple-minded confuse Gandalfs powers and abilities with sorcery. The 
second context is discerned when Gandalf is properly referred to as a high-ranking 
member of the Istari, and consequently, as a member of the White Council. 
Together with the leaders of the immortal High Elves and Half-Elven, the members 
of the White Council are also called ‘the Wise’, hence we discover Tolkien was 
inferring the original significance of the word ‘wizard’, which according to the New 
Oxford Dictionary originates from the Middle English ‘wise’ + ‘ard’ meaning 
‘philosopher’ or ‘sage’. It is a similar misconception with the Three Kings of the 

44 Lord of the Rings, The Return of the King, pp. 856-857. 

45 Ibid, p.887. 


40 



New Testament who followed the Star to Bethlehem. In history they have been 
called the three ‘Wise Men’, and also ‘Magi’, inferring that the kings belonged to a 
priestly-caste in ancient Persia. Their wisdom, arts and skills were called ‘magica’ 
in Latin, derived from the Greek ‘magike’, ‘art of a magus’, which obviously was 
confused over time with the term ‘magic’ applied to sorcery and supernatural 
powers. Hence, it is the second context of Tolkien’s Istari we find the semblance of 
a ‘mystical priesthood’ and not necessarily ‘magic sorcerers’, their skills and 
knowledge misconstrued by the ignorant. 

Yet, what are the Istari? Tolkien weaves great mystery around them. Frodo 
describes them as: “... of a noble kind that we should not dare to raise our hands 
against.” 46 They appear on Middle-Earth from the West across the sea about two 
thousand years before the action of the Lord of the Rings takes place during the 
‘Great Years’ of 3018-3019 in the Third Age.* The Istari are great ‘blessed’ beings 
that obviously originate from the Undying Lands, however, they are not Elves or 
Men eventhough they take the shape of men. They were not ‘young-looking’ when 
they arrived, yet are not exactly immortal like the Eldar races of Elves and Half¬ 
elves, for the Istari age albeit very slowly. In fact, they have been granted powers 
and wisdom that seem even greater than that granted to the Elves. They are special 
‘messengers’ sent to battle evil, to instruct and encourage the ‘good’ races. Tolkien 
writes very little about the origins of this mysterious ‘race’ of messenger-guardians: 


“When maybe a thousand years had passed, (...) the Istari 
or Wizards appeared in Middle-Earth. It is afterwards said that 
they came out of the Far West and were messengers sent to contest 
the power of Sauron, and to unite all those who had the will to 
resist him; but they were forbidden to match his power with 
power, or to seek to dominate Elves or Men by force and fear. 
They came therefore in the shape of Men, though they were never 
young and aged only slowly, and they had many powers of mind 
and hand. They revealed their true names to few, but used such 
names as were given to them. The two highest of this order (of 
whom it is said there were five) were called by the Eldar Curunir, 
‘the Man of Skill’, and Mithrandir, ‘the Grey Pilgrim’, but by Men 
in the North Saruman and Gandalf (respectively).” 47 


Hence, through the narrative and the appendixes in Lord of the Rings , we 
discover that the Istari do have a hierarchy that in later years form the White 
Council ruled by Saruman the White, which resembles a symbolical image of a 
‘church’ entrusted with the mission to teach and guide the ‘elect’ peoples of Middle- 
earth when times begin to grow dark. In the beginning of Lord of the Rings, Gandalf 
appears to be second in command of the five highest ranking members of their 
order, his position marked by the colour grey. Of interest, we recall that the 
bishops of the Seven Churches of the Apocalypse were referred to as ‘angels’, or 


46 Ibid. p. 1056. 

The Third Age of Middle-Earth began with the defeat of Sauron by Elendil and Gil-galad, and 
ended with the death of King Aragom and the departure of Legolas to the Undying Lands in the 
year 3141. Lord of the Rings, Appendix B, pp. 1121-1134. 

47 Ibid. Appendix B, p. 1121. 


41 



‘messengers’, an apropos connection with Tolkien’s idea of a blessed group of 
messenger-guardians originating from the mystic Undying Lands of the angelic-like 
Valar far across the sea. 

Yet, we may ask, where are the references to a priesthood?. The main role of a 
priest is to offer sacrifice and perform rites in an established church, and if Tolkien 
was wary of introducing ceremonies into a fantasy novel that could be 
misconstrued by readers to be something resembling a pagan or an occult rite, how 
could the priesthood of the Catholic Church possibly be represented? As 
mentioned, it would have to be in very general allegorical or mystic terms without 
portraying an actual ceremony, and Tolkien may have accomplished this by having 
the almost inexplicable arrival of his Istari resemble the ‘mysterious’ appearance of 
the High Priest Melchisedech to Abram yet to be called Abraham in the Old 
Testament. After Abram goes into battle in a woodland vale and victoriously frees 
his brother Lot who was held captive by warring kings, Melchisedech the king of 
Salem ‘appears’ with an offering of bread and wine to the Lord, and blesses Abram: 


“But Melchisedech the king of Salem, bringing forth bread 
and wine, for he was the priest of the most high God, blessed him 
and said: Blessed be Abram by the most high God, who created 
heaven and earth. And blessed be the most high God, by whose 
protection the enemies are in thy hands.” (Gen. 14: 18-20) 


Of paramount importance is the observation that Melchisedech was a priest 
ordained by God long before the Hebrew nation and the Levitical rites were 
instituted, and according to the prophet King David, Melchisedech was of an 
‘eternal order’ and therefore much greater than the Levitical one, a prophetic type 
of the Eternal Kingdom and Everlasting Priesthood of the Messiah that came to 
fruition through Christ and his Church: 


“The Lord said to my Lord: Sit thou at my right hand: 
Until I make thy enemies thy footstool. 

The Lord will send forth the sceptre of thy power out of 
Sion: rule thou in the midst of thy enemies. 

With thee is the principality in the day of thy strength: in 
the brightness of the saints: from the womb before the day 
star I begot thee. 

The Lord hath sworn: and he will not repent: Thou art a 
priest forever according to the order of Melchisedech. 

The Lord at thy right hand hath broken kings in the day of 
his wrath. 

He shall judge among nations, he shall fills ruins: he shall 
crush the heads in the land of many. 

He shall drink of the torrent in the way: therefore shall he 
lift up the head.” (Psalm 109) 


42 



St. Paul explains King David’s verses, declaring that Melchisedech’s 
mysterious appearance without any parentage recorded in the sacred texts displays 
the difference between the finite and imperfect Levitical rite of the Old Testament 
that could not redeem mankind and the Eternal and everlasting priesthood of Christ 
in the New Testament: 


“For this Melchisedech was king of Salem, priest of the 
most high God, (...) who first indeed by interpretation is king of 
justice: and then also king of Salem: that is, king of peace: Without 
father, without mother, without genealogy, having neither 
beginning of days nor end of life, but likened unto the Son of God, 
continueth a priest forever.” (Heb. 7:1-3) 


Hence, in Melchisedech we have a reference to a mysterious king-priest who 
is ‘everlasting’ ~ from whence he comes and where he goes, no one knows. Of 
interest, Bl. Anne Catherine Emmerich was granted a vision concerning the 
prophetic appearance of Melchisedech, and that he appeared to Abraham “...in the 
same way as did the angels at different times.” 48 She also notes: “I have often seen 
Melchisedech, but never as a human being. I have always seen him as a being of 
another nature, as an angel, as one sent by God.” 49 Therefore it is possible Tolkien 
may have modelled the mysterious arrival of his ‘angelic’ Istari upon that of 
Melchisedech. 

Yet, where is the acceptable ‘sacrifice’ or offering in the Lord of the Rings that 
the ‘priesthood’ is to make if there is indeed a priesthood? We must examine the 
offerings of Melchisedech to find the answer: bread and wine. These early offerings 
were prophetic symbols of the bread and wine that would later be offered by Christ 
at the Last Supper and transubstantiated by His Divine Power into His Body and 
Blood that would be given up the next day, the perfect and spotless Eternal 
Sacrifice to the Father for the sins of mankind. 

Focusing on Gandalf, we find he indeed offers an ‘ultimate sacrifice’ like 
Christ. During their journey in their quest to destroy the Ring, the members of the 
Fellowship are compelled to take a perilous route through the underground Dwarf 
kingdom of Moria that in years past had been laid waste by goblins, ores and other 
fell beings. However, the mine-kingdom is still inhabited by evil creatures. In 
addition to hoards of goblins, trolls and ores, the small band of travellers are 
suddenly perused by a colossal Balrog, a terrifying fire-demon reawakened from the 
deepest recesses of the mountains. Described as an “evil of the Ancient World,” 
and a “Terror” feared almost as much as Lord Sauron by both Elves and Dwarves, 
it is a creature of shadow and flame that was and continues to be a servant of 
Morgoth, the Great Enemy of Old. The ferocious power of the Balrog is so mighty 
that even the other dark creatures of Moria fear it, and Gandalf is the only one of 
the Fellowship who has the skill and wisdom to battle with the foe. As the 
travellers escape, Gandalf stays behind and bars the way, preventing the Balrog 
from pursuing them over a black abyss. He engages in a dramatic sword fight, his 
white elf-blade smashing the Balrog’s flaming blade to molten pieces declaring 
imperiously, “You cannot pass!” The Balrog attempts to cross the bridge again, but 

48 The Life of Christ, Vol I, p. 81. 

49 Ibid. p. 64. 


43 




“Durin's Bane”, the Balrog of Moria by Markus Roncke (2008) 




Gandalf uses the full force of his powers as servant of the ‘Secret Fire’ and wielder 
of the flame of Anor. Shattering his staff against the land-bridge and raising up a 
blaze of light, he sends himself and his foe into the chasm, imploring the 
Fellowship to save itself. The travellers flee as he bids, thinking Gandalf is lost 
forever, having fallen to his death in a bottomless abyss with the evil Balrog. 

However, we discover later we have not heard the last of Gandalf s 
adventures with the Balrog in the bowels of Middle-Earth. Gandalf eventually 
reunites with Aragorn, Legolas and Gimli in Fangorn forest, and they are 
astounded at his reappearance, thinking he was dead. Now, he is dressed in a 
brilliant white and he explains his transformation from the Grey Pilgrim to the 
bright figure they see before them, destined to become the new leader of the White 
Council.*

When the bridge collapsed and the Balrog snapped its whip around his legs, 
dragging him down with him, they fell for what seemed like an eternity down to the 
very roots of the mountains of Moria and into a great hidden lake. The water 
doused the evil flames of the Balrog, turning it into a hideous slimly creature, but 
Gandalf continued to fight his enemy, hewing it with his Elven sword as they 
struggled in the water. “We fought far under the living earth, where time is not 
counted.” 50 The Balrog then turned and fled, making its way up through hidden 
stairs and passageways, attempting to reach the sun to reignite its flames and 
Gandalf followed him up to the very pinnacle of the mountain, engaging in battle 
once more with the monster, its flames now reignited: 


“A great smoke rose about us, vapour and steam. Ice fell 
like rain. I threw down my enemy, and he fell from the high place 
and broke the mountain-side where he smote it in his ruin. Then 
darkness took me, and I strayed out of thought and time, and I 
wandered far on roads that I will not tell. Naked I was sent back ~ 
for a brief time, until my task is done.” 51 


In the end we find Gandalf did give up his life to destroy the enemy, the 
coming of death described as the ‘darkness’ taking him. We see he was no longer 
in the temporal spheres of Middle-Earth for he strayed out of thought and time yet 
was ‘sent back’ for his mission was not yet accomplished. 

Hence, Similar to Christ who gave the ultimate sacrifice of His life to defeat 
Eternal Death brought into the world by Satan, Gandalf risks his life to save his 
friends, knowing he may be defeated in the struggle, and eventually does give up his 
life to destroy a Demon of Death that had been the cause of the decimation of the 
Dwarf Kingdom in Moria. “I am the good shepherd. The good shepherd giveth 
his life for his sheep.” (John 10:11) We see Frodo later explains to Lady Galadriel: 
“Gandalf was our guide, and he led us through Moria; and when our escape 


Compare Gandalf s transformation with Bl. Emmerich’s comments about the mysterious angelic- 
priest Melchisedech: “The impression made by Melchisedech was similar to that produced by the 
Lord during His teaching life. He was very tall and slight, remarkably mild and earnest. He wore a 
long garment so white and shining that it reminded me of the white raiment that surrounded the 
Lord at His Transfiguration.” The Life of Christ, Vol. I (p. 82). 

50 Lord of the Rings, The Two Towers, p. 523. 

51 Ibid. pp. 523-524. 


45 



seemed beyond hope he saved us and he fell.” 52 As Christ said: “Greater love than 
this no man hath, that a man lay down his life for his friends.” (John 15:13) 
Indeed, Gandalf is also presented as a symbolic Christ-like figure rising from the 
dead for he declares later in the text: “I am Gandalf the White, who has returned 
from death.” 53 In the Elven woods of Lothlorien he is clothed in the victorious 
colour white and later becomes the new Leader of the White Council, Saruman 
having proved a traitor and unworthy to hold the noble office. Rather than become 
a wise protector, looking after the flock so to speak, Saruman became a wolf in 
sheep’s clothing. He coveted the black magic of the One Ring and in fact, lusts 
after power, rebelliously flouting the order laid on the Istari that they may not rule 
over Elves or Men by fear or force, nor go so far as to challenge the Dark Lord 
Sauron with the powers granted them. In one sense, the expulsion of Saruman and 
the rise of Gandalf represents the end of the Old Testament Levitical priesthood 
and the establishment of the new Eternal Priesthood of Christ via his Church in the 
New Testament for Gandalf remarks: “Yes, I am white now. Indeed I am 
Saruman, one might almost say, Saruman as he should have been.” 54 

In fact, this order to guide and instruct yet not vie of power, even against the 
Evil Sauron in an attempt to defeat him, is remarkably similar to the role of a 
Catholic priest who may guide and instruct, yet force no one to enter the True Faith 
against their free will. Indeed, even exorcist priests may not ‘challenge’ Satan, only 
drive out a demon if called upon to do so by the power invested in him through 
Christ as it is ultimately God who decides the time of deliverance from a demon. A 
priest is only the means and simply represents God. Of interest, we find that this is 
the one of the few ‘priestly’ functions we see Gandalf engage in other than 
sacrificing his life like Christ, that is, to carry out his duty as a type of exorcist. 
Gandalf protects others from the powers of dark creatures, and in one instance, 
drives out the black clouds of oppression possessing the King of Rohan, 
encouraging him to turn from the evil councils of the traitor Saruman and embrace 
the light once more. 

Throughout the rest of the narrative, this Christ-like image of Gandalf as a 
regal leader and ‘pontiff is firmly established in his new adventures as the White 
Rider. During his travels Gandalf tames the famed white horse belonging to the 
King of Rohan, Shadowfax, a distant descendent of the speaking horses that no 
doubt were brought over from the Undying Lands of the Valar. Only the kings of 
Rohan are permitted to ride rare horses such as Shadowfax, yet once he is tamed by 
Gandalf, he will bear no other rider. Gandalf continually rides like the wind to the 
aid of those who need his help and powerful assistance. He musters armies, dispels 
evil, gives counsel to kings and captains, comforts the doubtful, protects and saves 
lives, and dares to confront the leader of the Nazgul witch-kings as he attempts to 
enter the hallowed gates of Gondor’s capital city: 


“ ‘You cannot enter here,’ said Gandalf, and the huge 
shadow halted. ‘Go back to the abyss prepared for you! Go back! 
Fall into the nothingness that awaits you and your master! Go!” 55 


52 Ibid. The Fellowship of the Ring, p. 375. 

53 Ibid. The Two Towers, p. 607. 

54 Ibid. p. 516. 

55 Ibid. The Return of the King, p. 861. 


46 



We note Gandalf s challenge sounds very familiar ~ it mirrors the eternal 
sentence Christ will mete out to the reprobates on the day of Judgement: “Depart 
from Me, you cursed, into everlasting fire prepared for the devil and his angels.” 
(Matt. 25: 41) In fact, Gandalf s new role as the White Rider and leader of the 
White Council is remarkably similar to the mystic representation of Christ near the 
end of the Apocalypse, riding into battle against the Beast and the evil kings of the 
earth: 


“And I saw heaven opened, and behold a white horse; and 
he that sat upon him was called faithful and true, and with justice 
doth he judge and fight. And his eyes were as a flame of fire, and 
on his head were many diadems, and he had a name written, 
which no man knoweth but himself. And he was clothed with a 
garment sprinkled with blood; and his name is called, THE 
WORD OF GOD. And the armies that are in heaven followed 
him on white horses, clothed in fine linen, white and clean.” 
(Apoc. 19:11-14) 


We recall that just like Christ whose mystic name is known only to Himself, 
Tolkien’s Istari rarely reveal their true names known only to them and will allow 
themselves to be addressed by whatever name the peoples of Middle-earth call 
them. Only once do we hear Gandalf reveal what it is, Olorin, his name when he 
was still ‘young’, obviously before the time he arrived on Middle Earth since the 
Istari were not youths when they appeared: 


“Many are my names in many countries, he (Gandalf) said. 
Mithrandir among the Elves, Tharkun to the Dwarves; Olorin I 
was in my youth in the West that is forgotten, in the South 
Incanus, in the North Gandalf; to the East I go not.” 56 


Of importance, we discern that Gandalf may also be associated with Christ 
as ‘The Word of God’ in his capacity as a ‘pontifical’ servant of the ‘Secret Fire’ 
and ‘wielder of the flame of Arnor’. When we examine the theological and 
philosophical importance of the description of Christ as ‘The Word’, the connection 
with this mystical fire becomes clear. St. John, author of the Apocalypse, also 
commenced his Gospel with this description of Christ: “In the beginning was the 
Word.” However, ‘word’ is a weak literal translation from the original Greek and 
the full meaning of the passage is lost. The Gospel should read: “In the beginning 
was the logos. ” 

What is logos, and why is it so important? Logos conveyed the triple meaning 
of ‘word’, ‘reason’, and ‘ratio’. It was used by ancient Greek philosophers to 
describe the Divine Reason that permeates and orders the whole universe. At first, 
it was thought that this Logos was a fire-like being or essence, and that the actions of 
this being were mirrored in human reason. The Stoic philosophers associated this 
power with God and His actions through the Universe, or the active power of 

56 Ibid. The Two Towers, p. 696-697. 


47 




“The Rider on the White Horse”, early 14 th century manuscript 
depicting Christ with His army clothed in white. 

































Divine Reason. This Greek concept of the Logos was introduced into Judaism in 
the first century AD by Philo Judaeus in an attempt to explain how God remained 
in contact with the earth via the Logos, or His Divine Wisdom. Apparently, 
Heaven itself confirmed this explanation of the Logos, for in St. John’s vision in the 
Apocalypse, Christ showed He was indeed the Logos, the Mediator between Heaven 
and Earth, revealing He verily was both human and divine. This was an important 
revelation from Heaven at the time as the heresy of Docetism was beginning to 
appear, that is, a belief that all matter was ‘corrupt’ or ‘evil’ while only the spirit 
could by pure and holy. This inferred that if matter was corrupt, Christ was God or 
of God, but could not become human and did not assume a human form, an 
Antichrist belief according to St. John. St. John combated Docetism and similar 
heresies by proclaiming in his Gospel: “In the beginning was the Word (the Logos), 
and the Word was with God, and the Word was God. The same was in the 
beginning with God. All things were made by Him: and without him was made 
nothing that was made. In him was life, and the life was the light of men. And the 
light shineth in the darkness, and the darkness did not comprehend it. (...) And the 
Word was made flesh, and dwelt amongst us, and we saw his glory, the glory as it were 
of the only begotten of the Father, full of grace and truth.” (John 1: 1-5, 14) 

Hence, is it possible that Gandalf as a servant of the ‘Secret Fire’ is presented 
as a symbolic follower of the Logosl The Logos was once thought to be a ‘fire’, and 
Christ was prophesied by John the Baptist as the Messiah who would baptise with 
the Holy Spirit and with fire, (Matt 3:11). Christ also declared: “I am come to cast 
fire on the earth; and what will I, but that it be kindled?” (Fuke 12:49) We recall 
the Holy Spirit later appeared above the heads of the Apostles as tongues of fire 
during Pentecost, and Catholic teaching declares one cannot enter the Church 
unless they are baptised and renewed by the Holy Spirit according to Christ’s 
words: “Unless a man be born again of water and the Holy Ghost, he cannot enter 
the kingdom of God” (John 3:5) Christ is also described as the Fight as well as the 
Logos, and the Holy Spirit represented as a Tongue of Fire as the giver of Grace and 
the sustainer of the Church. Without the Holy Spirit, mankind cannot do the least 
work deserving of salvation, even the apostles were frightened until the Flames of 
the Holy Spirit enlightened them and filled them with undaunted courage at 
Pentecost. 

In comparison, Gandalf s skills rest mainly in light and fire. We recall he 
drives away darkness and despair with light, and courageously fights the evil Balrog 
with a powerful white flame that emits from his staff when it shatters in the conflict. 
Furthermore, we cannot help but notice that if Gandalf is indeed a symbolic servant 
of the Logos and the Holy Spirit, Tolkien obviously made rare allusions to Catholic 
doctrine in Lord of the Rings, in particular, the doctrine of the Trinity, that the Son 
was indeed both human and divine and guided His Church through the Holy Spirit 
also represented as fire. The Spirit proceeds from the Father and the Son therefore 
the entire Trinity is represented. As we have seen, Christ’s sacrifice for the 
salvation of mankind and His resurrection are also alluded to, these are the 
doctrines on which the entire foundation of the Catholic Faith rests. 

In summary, there is evidence of a ‘priesthood’, a ‘church’ and a ‘true faith’ 
influencing Tolkien’s work skilfully concealed in the text. In fact, if reference to the 
Catholic Faith is intended, no doubt the White Council and the wise ‘priesthood’ of 
the Istari are representative of the Church. The ‘angelic’ Gandalf is eventually 
made ‘pontiff when he deposes Saruman by rightful authority invested in him from 
Beyond, “You have no colour now, and I cast you from the order and the 


49 



Council”. 57 Gandalf wears ‘papal’ white, and has symbolically carried out the 
threefold office conferred upon the Church: that of teacher, of priest, and of 
shepherd. Of importance, he remains faithful as a ‘servant of the Secret Fire’ and 
therefore, defends the doctrine of the Trinity. 

He also bears the symbols of his authority as ‘pontiff, a staff and a ring. 
Like Christ, he was a shepherd who protected his flock with his very life, his first 
staff as Gandalf the Grey shattering in the process. “... For it is written: I will strike 
the shepherd, and the sheep of the flock shall be dispersed.” (Matt. 26:31) The 
Fellowship are indeed scattered when Gandalf falls in the Mines of Moria with the 
Balrog, but he reunites them all when he rises again in victory. Of interest we find 
that Bl. Anne Catherine Emmerich was shown the significance of the pastoral staff 
from the time of the ancient prophets to the crosiers used by the bishops, and the 
Pope as Bishop of Rome also carries a distinctive crosier: 


“I saw this gift of the priesthood possessed by the 
Prophets, and the signification of the form under which it was 
exercised was shown me. I saw, for example, the history of 
Eliseus giving his staff to Giezi to lay upon the dead child of the 
Sunamitess. In this staff lay spiritually Elisues’s mission and 
power. It was, as it were, his arm, the prolongation of his arm. 
And here I saw the interior signification of a Bishop’s crosier and a 
monarch’s sceptre. If used with faith, they unite both Bishop and 
monarch in a certain way with Him from whom they hold their 
dignity, with God, marking them out at the same time as distinct 
from all others.” 58 


And the Ring? We discover in the end of the tale that Gandalf had in his 
possession the whole time one of the Three Rings of Power made by the Elves ~ 
“Narya the Great, and the stone upon it was red as fire.” 59 In the Appendix we 
discover this rare Ring was given to him by one of the greatest of the Eldar Elves, 
Cirdan the Shipwright, who was granted the gift of perception and discernment 
more than anyone else on Middle Earth. When Gandalf first arrived from the 
Undying Lands with the Istari centuries ago, Cirdan welcomed him “... knowing 
whence he came and whither he would return.”... 


“Take this Ring, Master,’ he said, ‘for your labours will be 
heavy; but it will support you in the weariness that you have taken 
upon yourself. For this is the Ring of Fire, and with it you may 
rekindle hearts in a world that grows chill.” 60 


Hence, Cirdan foresaw that Gandalf would renew the faith and the charity 
of the people when times would be at their darkest, much like the End Times when 


57 Ibid, p.607. 

58 The Life of Jesus Christ, Vol I, p. 19. 

59 Lord of the Rings, The Return ofthe King, p. 1068. 

60 Ibid. Appendix B, p. 1122. 


50 



charity will “grow cold” as Christ foretold. 61 The only detail that does not 
correspond with the idea of the papal ring is that Gandalf s ring is not the mightiest 
of the Three. The Pope of the Catholic Church as the Vicar of Christ is quite 
independent of every temporal sovereignty and of every spiritual power, i.e. he 
cannot be ordered around by kings or bishops in Church matters, and is supreme on 
earth, not even being subject to a general council of the Church. 62 Concerning the 
papal ring, it was once used to sign important documents as his official seal. Upon 
the death of a pope, the papal ring was effaced to ensure that no other may usurp 
his authority or forge documents after his death with the seal. The ritual of effacing 
the ring is still continued to this day. Perhaps it was an unintended oversight in 
that Tolkien did not give Gandalf the most powerful of the Three Elven Rings, but 
he did reaffirm the theological symbols of Gandalf as ‘pontiff of the Istari, 
representative of the Logos and the Holy Spirit symbolised by Light and Fire, by 
giving him Narya the Great, the Ring of Fire. Of interest, one of the principle 
duties of the Catholic pontiff is to preserve the Faith, unite Christendom, and heal 
Christ’s people. Lord Elrond reveals that the Three Elven Rings, (including 
Gandalf s Ring of Fire), were made with a similar purpose: “But they were not 
made as weapons of war or conquest: that is not their power. Those who made 
them did not desire strength or domination or hoarded wealth, but understanding, 
making, and healing, to preserve all things unstained.” 63 The only difference is the 
Elven Rings could be enslaved if Sauron finds the One Ring, while pontifical 
authority symbolised in the pope’s ring cannot be enslaved as the spiritual authority 
of the pope is above all secular and ecclesial power. 

Regarding the Catholic pontificate itself, Christ had declared that Peter was 
the Rock on which he would build His Church and the gates of Hell would not 
prevail against it. (Matt.l 6:18) In other words, all Hell would try to destroy the 
Church, especially by attacking the papacy, but would not succeed. We notice 
Tolkien may have alluded to Christ’s promise to Peter and his successors, i.e. when 
the black ore-hosts of Mordor eventually attack the Gates of Minas Tirith with a 
gigantic battering ram shaped in the likeness of a ravening wolf. The battering ram 
is called Grond after the Hammer of the Underworld wielded by the ancient Satan- 
like Lord Morgoth. The gates of the King’s City holds amidst the initial poundings 
of the battering ram, but the Lord of the Nazgul urges the black army onward and 
the gates eventually burst asunder. The Nazgul king attempts to enter the City of 
Gondor and rides ... under the archway that no enemy ever yet had passed.” All 
flee from his horrific form sending despair with its menacing shadow, all save one, 
Gandalf and his fearless white horse: “There waiting, silent and still in the space 
before the Gate, sat Gandalf upon Shadowfax: Shadowfax who alone among the 
free horses of the earth endured the terror, unmoving, steadfast as a graven image in 
Rath Dinen. ‘You cannot enter here,’ said Gandalf, and the huge shadow halted.’” 
64 Gandalf commands him to depart and enter the black nothingness of the abyss 
prepared from him and his Dark Master. The Lord of the Nazgul mocks Gandalf, 
but he is prevented from entering and taking the city. The sun rises and the faithful 
armies of Rohan ride to the rescue. The evil Nazgul king suddenly flies off to 
engage them and leaves the city just when he had it within his grasp. In the end, 


61 “And because iniquity hath abounded, the charity of many shall grow cold.” (Matt. 24:12) 

62 The Pope not subject to a general council was declared by Eugenius IV., (Sept. 4, 1439; Vatican 
Council, 4, 3). 

63 Lord of the Rings, The Fellowship of the Ring, p. 286. 

64 Ibid. The Return of the King, pp. 860-861. 


51 



Gandalf courageously held him off, ensuring that the City of the Faithful 
Numenoreans that had never seen an enemy enter past its threshold remained as it 
was ~ hammered, but undefeated. 

One last observation concerning Gandalf s role as ‘pontiff is his unexpected 
mercy towards Saruman in a Christ-like manner in the hope he might repent of his 
treachery. The most important mission of the Church is teaching the forgiveness of 
sins no matter how great, and to encourage souls to follow He who is the Way, the 
Truth, and the Life: Gandalf fulfils this mission as well. Saruman and his army are 
defeated and the traitor is imprisoned in the tower of Orthanc. However, Gandalf 
gives Saruman the choice to go where he wishes, even to the Enemy if that be his 
desire, or, to redeem himself by helping them in their cause to defend Gondor 
against Lord Sauron. Gandalf also declares that in time if Saruman’s deeds merit 
it, he will eventually give him back his staff and reinstate him as a member of the 
Council. Everyone is amazed at this generous offer and cannot comprehend it. 
Unfortunately, Saruman craves supremacy in Middle Earth and refuses to leave the 
tower of Orthanc willingly, nor will he help Gondor and its allies, accusing Gandalf 
of the lust for power that he himself is consumed by. Gandalf is left with no choice 
but to forcibly divest Saruman of his office not only as Leader but also as a member 
of the Istari as he has proved unworthy to be numbered among them. Gandalf 
leaves him confined within the tower to await the dreadful wrath of Lord Sauron, 
whom he had also betrayed. Gandalf bitterly regrets this turn of events; “I do not 
wish for mastery. What will become of him? I cannot say. I grieve that so much 
good now festers in the tower.” 65 Rather than rejoice at his enemy’s demise, 
Gandalf attempts to save him from his own evilness and is mournful that Saruman 
remains unrepentant. 

As we have seen, there is enough evidence to suggest that Tolkien fashioned 
Gandalf and his adventures after the Roman Catholic papacy to a point, but are 
there passages or events in Lord of the Rings that links him with the ‘Angelic Pontiff 
that Catholic mystics have foretold? According to prophecy, both the Great 
Monarch and the Angelic Pontiff will work together in their respective spheres to 
restore all that was destroyed by evil and usher in an age of peace before the final 
temptation of mankind near the end of time. As we have seen earlier in our study, 
Gandalf reappears as the ‘Angelic’ Leader of the Istari just as Aragorn comes forth 
from hiding and reclaims his kingdom similar to the prophecies concerning the 
Great Monarch that will help restore Christendom. There are a few other 
similarities with Gandalf and prophecies concerning the Angelic Pontiff: when 
Saruman attempts to persuade Gandalf yet known as The Grey Pilgrim to join with 
him in his evil designs, Gandalf refuses and as a consequence is imprisoned upon 
the pinnacle of Orthanc; however, he eventually escapes Saruman’s clutches. As 
we have seen earlier, Catholic mystics such as Marie-Julie Jahenny foretold that the 
Angelic Pontiff would be held captive within Rome itself, and would be freed by 
the Great King. Although Gandalf s situation is slightly different, he is not yet 
Leader and is not rescued by Aragorn, the fact he is held prisoner by one of his own 
who has grown corrupt bears a resemblance to Jahenny’s revelations. We could 
also propose that Gandalf courageously challenging the Nazgul King at the Gates 
of the King’s City when all resistance seems hopeless may also represent the 
captivity of the Angelic Pontiff surrounded by enemies in Rome. The King of 
Rohan and Aragorn arrives with his phantom army and saves Gondor, much like 
the Great Monarch who will come to Italy with his armies and liberate the Eternal 

65 Ibid. The Two Towers, p. 608. 


52 



City. In several prophecies we find that the Great Pope will crown the Great 
Monarch Holy Roman Emperor of Christendom, for example, St. Ignatius of 
Santhia declared (1686-1770): “A scion of the Carolingian race, by all considered 
extinct, will come to Rome and behold and admire the piety and clemency of this 
Pontiff, who will crown him, and declare him to be the legitimate Emperor of the 
Romans...” 66 In the Lord of the Rings, we find that Aragorn departs from custom for 
his coronation and instead of setting the crown upon his head, grants the honour to 
Gandalf: 


“...let Mithrandir set it upon my head, if he will; for he has 
been the mover of all that has been accomplished, and this is his 
victory.’ 

Then Frodo came forward and took the crown from 
Faramir and bore it to Gandalf; and Aragorn knelt, and Gandalf 
set the White Crown upon his head, and said: 

‘Now come the days of the King, and may they be blessed 
while the thrones of the Valar endure!’.” 67 


Yet, the triumph and happiness of the restored kingdom is not yet complete, 
Aragorn is awaiting the ‘sign’ when all shall be fulfilled and his days assured of 
blessedness and peace, for the White Tree of his forefathers still stands dead in the 
King’s courtyard. Gandalf takes Aragorn up a steep forgotten path that only kings 
have tread leading to a high precipice in the mountains overlooking the kingdom. 
First, he reminds Aragorn of his secular and sacred duties, to rule wisely, and to 
preserve and defend the true faith: “This is your realm, and the heart of the greater 
realm that shall be. The Third Age of the world is ended, and the new age is begun; 
and it is your task to order its beginning and to preserve what may be preserved.” 68 
Gandalf bids Aragorn to look away from the valley and search the snow. To his 
surprise, Aragorn discovers a young white sapling: a lost descendant of Telperion, 
symbolic of the Biblical Tree of Fife. With joy Aragorn takes it back to the city and 
plants it in the royal courtyard for now he knows that his wish will be granted ~ 
Ford Elrond will give his daughter Arwen to him to be his wife. Elrond had 
declared he would not give him the hand of his daughter in marriage, Princess 
Arwen, unless he became King of the Numenoreans and someone worthy of her. 
Now that a White Tree has been found, Aragorn set guards upon the walls of the 
city and awaits her arrival. Elrond and his retinue enters the city and at last 
surrenders to Aragorn the sceptre of his ancestors that he may rule as king, and 
their joy is finally complete as he gives him Arwen to be his bride, a scene 
reminiscent of the Famb and Eternal King receiving His bride in the Heavenly 
court with the Tree of Fife planted at the foot of His Eternal Throne as seen in the 
Apocalypse: 


“Eet us be glad and rejoice, and give glory to him; for the 
marriage of the Famb is come, and his wife hath prepared herself. 


66 We are Warned, pp. 539-540. 

67 Lord of the Rings, The Return of the King, p. 1004. 

68 Ibid. p. 1007. 


53 



And it is granted to her that she clothe herself with fine linen, 
glittering and white.” (Apoc. 19:7-8) 

“And he showed me a river of water of life, clear as crystal, 
proceeding from the throne of God and of the Lamb. In the midst 
of the street thereof, and on both sides of the river, was the tree of 
life ...” (Apoc. 22:1-2) 


In all, there is considerable evidence that Tolkien modelled his characters 
Gandalf and Aragorn upon the various prophecies of the Angelic Pontiff and Great 
Monarch, mighty spiritual and secular leaders restoring peace and joy to the 
Faithful on Middle-Earth. 

By now, the reader is probably wondering that if Tolkien did indeed fashion 
two of his heroic characters from Catholic prophecies, what about the evil 
protagonists? Were any of them inspired by these little-known revelations 
concerning future times? The answer is yes, but to discover the links between the 
myth and the prophecies, we must venture not only into the realm of unnerving 
revelations, but also into the murky world of secret sects, dark plots, occult signs, 
bloody revolutions and conspiracy theories ~ we must probe deep into the burning 
Eye of Sauron. 


Lord Sauron ~ Veiled Malice 


Of all the evil antagonists ever portrayed in literature, the Dark Lord Sauron 
is certainly one of the most mysterious. He is not Evil itself embodied in the 
Satanic Lord Morgoth who poisoned the two Trees of the Undying Lands, but he is 
its servant, and as a loyal servant he has learned all the diabolical ways of his 
Master. Since he has plagued Middle Earth for millennia and has been reduced to a 
black shapeless spirit of terror, we know he is immortal like the Valar and at one 
time was a spirit of good as Lord Elrond declares, “... nothing is evil in the 
beginning. Even Sauron was not so.” 69 Sauron then is obviously a fallen member 
of an angelic race similar to demons in Christian theology, and as such he is greatly 
feared by all the faithful peoples of Middle Earth who remain true to the One 
Creator and His immortal Guardians, the Valar. Strangely, in spite of the terror he 
spreads and the vast armies under his command, we do not see Lord Sauron 
throughout the entire epic of Lord of the Rings. He is only perceived under different 
veils for we learn in the Chronicles in the Appendixes that he assumes various 
‘shapes’ throughout the different ages when his evil powers grow, but his forms are 
never fully described. He did at least have a hand on which he bore the One Ring 
before Isildur hacked it off, but whether he assumed a man-like shape or a beast 
with a hand-like appendage is left to the imagination. At another point in Middle 
Earth’s history he had assumed another form and was called the ‘Necromancer’, 


69 Lord of the Rings, The Fellowship of the Ring, p. 284. 


54 



but again, what he looked like, and indeed if he looked human at all, is left a 
mystery. 

During the Third Age in which the Lord of the Rings takes place, it is curious 
that Tolkien leaves this shadowy veil draped over his principal character of evil. 
Considering that for the first time in millennia Sauron has the opportunity of 
crushing the last remnant of the Faithful Numenoreans and is reaching the zenith of 
his powers, he does not rise forth in a blaze of demonic bravado to lead his own 
armies as the reader might expect in fantastic literature such as this. Tolkien 
completely sidesteps this dramatic imagery and instead, he reveals one particular 
feature of Sauron’s being that fills the world with awe and fear ~ the Great Lidless 
Eye, a burning Eye, an Evil Eye that never sleeps and watches over all, plotting, 
seeking, mustering fell beasts, rallying evil allies and causing despair. 



Insignia of the Dark Lord Sauron: the Red Lidless Eye 


55 


Frodo is shown a vision of the terrible Eye in the Mirror of Lady Galadriel: 


“But suddenly the Mirror went altogether dark, as dark as if 
a hole had opened up in the world of sight, and Frodo looked into 
emptiness. In the black abyss there appeared a single Eye that 
slowly grew, until it filled nearly all the Mirror. So terrible was it 
that Frodo stood rooted, unable to cry out or to withdraw his gaze. 
The Eye was rimmed with fire, but was itself glazed, yellow as a 
cat’s, watchful, and intent, and the black slit of its pupil opened on 
a pit, a window into nothing.” 70 


The most chilling aspect is the length and breadth of Sauron’s menacing 
influence despite never leaving the Dark Tower of Mordor, the entire world feels 
the malevolent presence of his watchful Eye. In some instances, he attempts to 
read the thoughts of the Wise, even the Elven Lady Galadriel. At other times he 
endeavours to win allies such as Saruman and corrupts the White Council, not to 
mention he destroys the unity of Gondor by instilling despair in the ruling Steward 
using the master Seeing Stone he captured, fooling or twisting the minds of those 
who dare to look into the other Stones that still exist. When Sauron does not 
attempt to influence anyone directly, his power is exerted through his minions who 
carry out his wicked designs. Fell creatures of his own twisted breeding programs 
such ores and trolls, and evil men under his dominion, especially the Nazgul 
Witch-Kings, hasten to carry out his commands. He himself remains secreted 
away and lays a rule of silence on his servants, never allowing them to say or even 
spell his name except for the Lieutenant of the Tower, a fallen member of the 
Numenorean race adept in the dark arts who is given the dubious honour of being 
“the Mouth of Sauron”. A miserable creature named Gollum who has become 
decrepit on account of the One Ring is one of the few who have seen the Dark Lord 
and declares he still has a powerful ‘Black Hand’ missing one finger, but never once 
do we see Sauron as he truly is, only in the guise of his diabolical trait as the Evil 
Eye. It is his chosen Sign and his minions bear a Red Eye on their shields and 
helmets. The Dark Lord remains a hidden entity of maliciousness lusting after 
power and the ultimate control of Middle Earth. 

Who or what could have inspired this new and dreadful revelation of Lord 
Sauron as the All-Seeing Eye? If Tolkien also based his characters on Catholic 
prophecies concerning the appearance of the Great Monarch and the Angelic 
Pontiff, it stands to reason he would also fashion the Dark Lord on the enemies of 
both Kingdom and Church denounced in these revelations. Hence, we need look 
no further than the Eye of Providence appropriated by Freemasonry and similar 
secret sects. 


All of the prophecies tells of great heresies and the global relaxation of 
morals spread by the enemies of God before the coming of the Great Monarch and 
Angelic Pontiff: several mystics clearly state Freemasonry and other associated 
secret orders will be the prime instigators of this dark period. The mystic Bl. Anne 
Catherine Emmerich revealed that the secret societies were the principle enemies 

70 Ibid, p.383. 


56 



that would relentlessly attempt to undermine the Church before the great renewal. 
Sister Jeanne Royer (1731-1798) also foretold that many precursors, false 
prophets and members of infernal secret societies, worshippers of Satan, shall 
impugn the most sacred dogmas and doctrines of our holy religion, shall persecute 
the faithful, shall commit abominable actions.” 71 Marie-Julie Jahenny declared that 
before the chastisements, France would lose the faith, and the chief cause would be 
the evil influence of men working from the depths of the “lodges”. 72 She also 
received a visitation from St. Michael the Archangel who declared that he himself 
would aid the arrival of the Great Monarch into France by destroying all the 
enemies of God, Freemasonry included; “I hold under my feet all the enemies of 
God and all that is of Freemasonry. I will exterminate them and the Justice of God 
will complete it and will crush them under the weight of His anger. Meanwhile, 
marching to France and on the borders of France, we will accomplish our duty.” 73 
The Church itself has also condemned Freemasonry, declaring all members are 
automatically excommunicated ipso facto. Pope Leo XIII, who saw Satan challenge 
Heaven and demanded a period of time to bring havoc on earth as mentioned 
earlier, also warned the faithful about the dangers of Freemasonry. No doubt Pope 
Leo recognised the esoteric guild as one of the tools that would be used during that 
predicted time. 

Why has Heaven and the Church condemned Freemasonry? The answer is 
complex: in order to understand the centuries-old irreconcilable division between 
the secretive lodges and the Catholic Faith, we must first examine the known 
history of the early stonemason guilds together with the formation of the liberal arts 
and the philosophical mysticism of the medieval period. 

In those times, the sum total of scholastic education and higher learning 
consisted of seven arts: grammar, rhetoric, logic, arithmetic, geometry, astronomy 
and music. These academic branches of learning were held in the greatest esteem 
as they were sublime evidence mankind was more than an animal: humans were 
beings created by God with the ability to reason, and through these arts mankind 
could be ‘liberated’ from the base nature of the corporal body and attain wisdom, 
hence the term ‘liberal’ arts. An important scholar and philosopher named 
Boethius (c. AD 430-525) categorised the last four mathematical branches into what 
he called the quadrivium, setting them apart from the first three arts, which were 
later called the trivium. For Boethius, number was the ultimate means to 
understand and attain heavenly wisdom as numbers with their mathematical laws 
were steadfast and never changing just like the Creator, hence his focus on the 
quadrivium. Boethius’ categorisation of these liberal arts as ‘numerical’ 
philosophical disciplines greatly influenced the academic thought of medieval 
Europe. Every art was bound by the use of reason, hence the importance of 
understanding the laws that governed numbers and ratio, even music was studied as 
a mathematical discipline governing sound. In fact, Boethius considered music the 
highest form of mathematical science, enabling one to understand the cosmic music 
of the spheres, for it was believed every planetary body moved in unity and 
harmony to an unheard ‘music’ in the heavens. The corporal heavens were the last 
boundary between Creation and the Spiritual Heaven, and hence to understand this 
hidden wisdom of the cosmos would enable man to come closer to the Wisdom of 
his Heavenly Creator. 

71 We Are Warned, p. 544. 

72 Ibid. p. 331 August 22, 1882. 

73 Ibid. St. Michael to Marie-Julie, September 29, 1878, p. 154. 


57 



Boethius divided music into three categories: the cosmic music as described 
above, the second was musica Humana , which was an ‘inaudible music’ that 
governed the invisible and mysterious union of the soul with the body. The third 
(and least important!) was audible instrumental music, which according to 
Boethius, pandered to the pleasures of the body but did little to improve the mind. 
Instrumental music had its place, it was the first step to hear and understand that 
sounds could be structured with proportion, balance and unified in a beautiful 
harmony, but it was not the highest form of music, which was always mystical and 
philosophical. Instrumental musicians were considered ‘labourers’ oblivious to the 
harmonic and metaphysical laws behind their performances. Composers were only 
a step above this grade as they fashioned music on an instinctive level, but not on 
the rational level of the philosopher, who was the ‘true musician’. Boethius 
declared: “How much nobler is the study of music as a rational discipline than as a 
composition and performance. It is as much nobler as the mind is superior to the 
body; for devoid of reason, one remains in servitude.” 74 Numbers then were more 
than mathematical figures, each number also held a mystic significance. By 
studying rational numbers through music and the other mathematical arts, the mind 
could grasp the concept of unseen yet perceptible wisdom of philosophy and 
theology. As a result, theology and philosophy were also bound together with the 
liberal arts in an interdisciplinary fashion. We note Tolkien was obviously 
influenced by medieval philosophy when constructing his mythical tales of Middle 
Earth as evidenced in his other writings in which he envisioned the ‘One’ God 
creating a cosmic music that was visibly made manifest via the creation of the 
physical World Circle. 

Returning to our study, we can see from Boethius’ philosophical theories on 
numbers and music that medieval scholars’ perception of the liberal arts was 
completely different from that of today. The sciences were not primarily studied for 
the purpose of learning a technical or practical trade, but to expand the mind and 
reach the heights of wisdom, and by learning wisdom, one could discern how to 
attain spiritual perfection. The liberal arts were an ennobling means to teach 
mankind how to rise from its fallen, base nature and connect once more with the 
divine. For instance, another example of science mixed with allegorical philosophy 
is alchemy, the pseudo-science of turning base or worthless materials into more 
precious substances, the ancestor to modern chemistry. Alchemy is often perceived 
as the ‘goose-chase’ of ages past, the dabbling quest of the greedy determined to 
produce gold out of lead, but it was much more than that, working with lead was 
just one aspect of the craft. The alchemists experimented with many materials, 
plants and minerals, in attempt to discover the quintessence ~ the perfect and 
incorruptible fifth element hidden in Nature that bound the Universe together. As 
gold was the symbol of wisdom in both the Bible and ancient myth, the Holy Grail 
of alchemy was the quest to discover how to make it, for it was believed that if one 
could reveal the secret of transforming crude lead into precious gold, they could 
also discover how to unlock the hidden quintessence of man ~ the eternal quest to 
rise above the corrupt flesh and once more reach perfection in spirit. In all, 
Christianised alchemy of the medieval period was intended to be a visual allegory, 
much like the nature-parables Christ used to teach the people about the Kingdom of 
Heaven. Unfortunately, the hunt to make easy gold quickly overshadowed 
alchemy’s original symbolical purpose. 

74 Wayne D. Bowman, Philosophical Perspectives on Music (New York: Oxford University Press, 

1998), p. 64. 


58 



Although the liberal arts were intended for philosophers, many of the mystic 
and allegorical aspects of the sciences also became an integral part of the trades 
associated with them. Geometry, ‘measurement of the earth’, became the revered 
art of the stonemason guilds. While Boethius championed music as the ultimate 
philosophy, geometry was viewed by others as the ultimate branch of numerical 
knowledge in understanding the Creator and His creation, for geometry, the unique 
three-dimensional application of number, was the highest form of arithmetic. It 
was thought that since God could not have created the structure of the universe 
without creating the laws of geometry, it had to be the most important. God was 
the ‘Great Architect of the Universe’ and therefore every other art was subject to 
geometry. The heavens and the earth could not be ordered without three- 
dimensional measurements, alchemy was closely bound with the study of 
astronomy and the materials of the earth, and therefore also tied to geometry. 
Music and words were bound by rhythm, and since that too was bound by logic 
and proportion, which required the use of reason symbolised in rational and 
unchanging numbers in addition to measurement, it followed that geometry, the art 
of the Freemasons, had to be master of all the liberal arts. 

The term ‘freemason’ arose circa the 1200s AD and was originally used to 
describe those stonemasons that were skilled in carving ‘freestone’ that did not 
splinter in the process, such as limestone. Later, ‘Freemason’ defined a stonemason 
who was free to work his trade wherever he chose without any restrictions imposed 
upon him by the trade unions or builders’ guilds. In most cases, medieval masons 
worked in lodges where much of the preliminary labour of drawing plans and 
hewing rough stones was carried out. Soon, guilds were formed with a master 
mason as leader, the term ‘lodge’ was continued and later used in reference to a 
guild, or a group of stonemasons. Each step from apprentice to master mason was 
accompanied by various ‘rites of passage’, ‘graduation’ rituals so to speak 
emphasizing the mystic knowledge gained with each step of becoming a 
stonemason and mystic philosopher of geometry. 

Stone masonry, also inseparable with architecture at the time, had the 
unique privilege of being associated with kings, princes, and with the philosophers 
and theologians of the Church since most of the master stonemasons’ skill s were 
channelled into building castles, palaces, municipal buildings, and of course, 
churches and cathedrals. As a result, many of the allegorical and mystical parables 
of the Church became closely entwined with the geometric mysticism of the 
stonemasons’ lodges. As the Scriptures declare Christ is the rejected Stone that 
became the cornerstone of the Church, every member was also a ‘living stone’ that 
constituted the heavenly kingdom and represented in the physical stones of a 
church; therefore, as the masons had the unique privilege of fashioning each and 
every stone, it is not surprising that they also incorporated this visual symbolism 
into their craft, viewing each member as a living ‘stone’ or ‘block’ that constituted 
their mystic lodge. The tools of their trade also held an allegorical significance 
concerning the path to Christian perfection. A ladder represented the spiritual steps 
leading up to heaven, while the plumb-line, geometrical compass and rule were 
symbolic reminders of how a man should live his life with moderation and moral 
balance. The gavel and hammer used to trim down and polish an ashlar or rough 
stone displayed the patience and labour required to transform one’s fallen and base 
nature into a perfectly hewn stone worthy of the heavenly Kingdom. The trowel 
was symbolic of laying the perfected stone in place, that is, within the Christian 
society of the Church, while mortar represented the charity, peace and brotherly 


59 



love that keeps the ‘stone’ secure. In all, the freemason’s trade was an allegorical 
parable made visible in construction tools similar to the chemical hunt for the 
spiritual quintessence, or ‘philosopher’s stone’ of alchemy. 

As we can see, freemasonry was not regarded as an ‘evil’ organization in the 
beginning and was closely associated with the Church. We cannot help but recall 
Lord Elrond’s observation in Lord of the Rings, “... nothing is evil in the beginning,” 
including the Dark Lord Sauron. Indeed, the freemasons adopted many Christian 
symbols, including the Eye of Divine Providence set within the triangle of the 
Trinity as the number three was considered a mystically important number in 
geometry. However, several factors began to contribute to the growing division 
between Church and the Mystic Lodge. One of the first troublesome issues 
emerged when freemasons continually added pagan myths and belief systems into 
the ‘history’ of their craft in their zeal to discover when mankind first practised the 
noble liberal art of geometric-stonemasonry. A number of the earliest surviving 
stonemasons’ charters display a curious mishmash of texts, inventive retellings of 
Biblical history, anachronistic accounts of secular history in addition to speculative 
myths concerning the foundation of the seven liberal sciences, all that were later 
combined with pagan philosophy as the years progressed. Many guild charters 
listed the ill-omened Tower of Babel as the first Biblical mention of organized stone 
masonry. Masonic legends grew from this supposed beginning, in particular, a 
strange account that a prophecy had already existed before the deluge warning 
mankind it would be destroyed by fire or water. Not knowing which would strike 
first, humanity had preserved knowledge of the seven sciences in two pillars, one 
that could withstand fire, the other water, hence the sciences were saved for 
posterity and allowed proud King Nimrod to build his mighty edifice. How they 
arrived at this legend is a mystery, some Masonic researchers note the ancient 
historian Josephus first mentioned this legend and wrote that it was Adam who had 
warned his son Seth what would happen, accrediting Seth with the construction of 
the two pillars. However, Josephus could have confused this story with the 
Egyptian pharaoh Sethos, or Seth, who raised memorial columns in the countries 
he conquered. Masons then traced the ‘history’ of their craft from Babel to the 
patriarch Abraham, who according to their legends taught the arts to the Egyptians, 
who in turn passed it on to the Greek philosophers, eventually arriving at the 
history of Solomon’s temple. After ancient Israel, masonry was then introduced 
into Europe, France receives particular attention in several guild charters. This 
‘history’ of their origins was often incorporated into the various graduation rituals 
of ‘raising a mason’ from apprentice to Master Mason. 

The temple of Solomon also features in Masonic pseudo-history and has its 
own curious collection of legends connected with it. For instance, freemasons 
associated the mythical two pillars of ‘Seth’ with the pillars of Wisdom and 
Strength in the Biblical temple. Another strange legend is that of ‘Hiram Abif, the 
widow’s son, who helped King Solomon in its construction. In the Bible, King 
Hiram of Tyre sends King Solomon his own father also named Hiram to help with 
the construction of the building. (2 Paralipomenon 2:13) His father Hiram, the son 
of a widow from the daughters of the tribe of Dan, was skilled in every craft 
concerning building, metalwork, engraving, and rare materials. However, the 
freemasons concocted a strange tale that non-masons tried to enter the lodge to 
leam the secrets of the masons and discover the hidden plans for the temple: when 
‘Hiram Abif refused to reveal the secret password or ‘Mason’s Word’ allowing 
admittance into their exclusive workspace, he was murdered and became a martyr 


60 



for sacred wisdom. There is no proof this ever happened, but for the freemasons 
the legend was a symbol of Christ’s death and resurrection as the ‘Word’ of God, 
the Divine geometric Logos of ‘ratio’, ‘word’ and ‘proportion’. 

We may ask why was secrecy so important? First, there was a practical 
reason as only those skilled and learned in the craft where allowed to progress 
through the various stages of initiation from apprentice to master mason and learn 
their trade secrets. If the ignorant could learn how to carve or draw architectural 
plans, the stonemasons and architects would be out of work! It was common sense 
to keep the skills ‘in house’ and off limits to the general populace. Even today, 
revealing patented trade secrets of a company is a serious crime. However, secrecy 
was important for other reasons. In the medieval period, the study of the 
philosophy surrounding the seven liberal sciences was often shrouded with mystery 
and kept a private matter among those of ‘higher intellect’ as the ignorant could 
often perceive the research of the scholars to be something bordering on the Satanic. 
Alchemy could be misconstrued as brewing witch potions, astronomy closely 
bordered on astrology in those days, and the study of mysticism in numbers, 
especially the strange geometrical figures associated with architecture, could be 
misjudged to be pagan witch-circles and diagrams. In fact, innocently studying the 
‘occult’ or hidden mysticism of the earth in the footsteps of the Three Kings or 
Magi was a risky business, scholars were often labelled ‘wizards’ in the incorrect 
sense rather than philosophers, the word ‘occult’ corrupted into something 
associated with the demons, hence the requisite for secrecy. As a result, masons 
developed codes to recognise each other, the infamous development of secret 
fraternal handshakes among lodge members comes from this practise. However, 
the protective shroud of secrecy was often taken to extremes. We recall the 
confidentiality surrounding the Venetian glass blowers guild of the medieval days 
was infamous, their glass was so prized throughout Europe that it would be 
detrimental if their trade secrets should be made common knowledge, their source 
of income would come to an end. Of interest, glass-blowing was also a unique 
form of alchemy, the base material of sand turned into something pure, clear, hard 
and brilliant through the cleansing process of fire was a prime example of the 
quintessence at work in Nature and displayed how the world in the end times would 
eventually be purified by fire. The fortunes and mysticism of the glass-guild also 
had to be kept from the prying eyes of the vulgar and ignorant. Those who 
attempted to leave were hunted down by an assassin and killed with a sword or 
dagger made of glass. 

As time progressed, the requisite of secrecy in the lodges helped to contribute 
towards the friction between the Church and Freemasons. Scholars of the medieval 
and Renaissance periods who wished to study pagan sources of ‘wisdom’ and 
various scientific works banned by Rome found a hidden sanctuary from the 
Church’s scrutiny in the lodges as ‘speculative members’, that is, as members who 
did not intend to acquire the practical skills of the stone carvers, but who wished to 
study the esoteric and ‘speculative’ history of masonry in addition to the associated 
liberal ‘occult’ sciences. However, the occult knowledge acquired in the lodges was 
‘all inclusive’ ~ wisdom had to be ‘good’ no matter where it was found ~ therefore 
many heretical concepts and ideas contrary to Church doctrine continued to be 
melded with the Judeo-Christian mysticism of the speculative branches of the 
guilds. Hence, not only were hermetic scholars concealing their studies, they began 
to separate themselves from the theology of the Church as well. 


61 



Over time, the various trades and sciences were divested of their 
‘speculative’ nature and progressed into the forms we know today: alchemy became 
chemistry, astronomy was purged of astrological study, mathematics became the 
study of equations, and so forth. Stone masonry was also gradually stripped of its 
mysticism, yet the speculative branch survives in Freemasonry. When this 
separation took place, it is difficult to discern considering the secrecy surrounding 
the lodges, although we may safely say the speculative Freemasons still operated 
according to the charges of their stonemason lodges for a considerable amount of 
time, albeit independently from the carvers that is until June 24, 1717 when a small 
group of four lodges in London formally united to created the first fraternal 
organisation with a common set of Charges. Six years later in 1723 the Grand 
Lodge of England was established from which all other recognised Masonic grand 
lodges throughout the world claim their origin. This period is generally considered 
the first official historical division of the operative or practical practise of stone 
masonry from speculative Freemasonry. 

From this time onward, Freemasonry as a fraternal society quickly spread 
throughout Europe. As the true history of masonry as a stone carvers’ craft was 
lost over time or obscured in speculation, the various lodges began to vie with each 
other in the quest to discover which had the oldest charters, and therefore, the lodge 
that should hold supreme authority over the others. In addition to the hunt for the 
oldest charters, many attracted to speculative Freemasonry attempted to form their 
own rival esoteric Masonic orders, attracting adherents by claiming they had 
discovered the true origins of the hermetic craft. At this point, many other forms of 
mystic philosophy such as Jewish cabala, Gnosticism, Egyptian lore, Persian 
wisdom myths, in addition to Christian doctrine, were all considered valid modes 
of attaining wisdom for a Masonic philosopher, the various Christian symbols of 
the stonemasons trade, including the All-Seeing Eye of the Trinity, was often 
placed side by side with other pagan images of ancient Babylon, Egypt, Persia, 
Greece and Rome, not to mention those from other non-Christian belief systems. 
Eventually the All-Seeing Eye become recognised as a definitive Masonic symbol 
circa the 1790s. 

One of the most popular rites that emerged was the Rite of the Strict 
Observance founded by Baron von Hund in the late 1800s allegedly ruled by a 
group of secret ‘Unknown Superiors’. Hund claimed that hermetic Freemasonry 
had originated with the medieval crusader Templar Knights who had discovered 
esoteric secrets of the East during their time guarding the Temple and escaped to 
England disguised as stonemasons when their chivalric order was disbanded and 
persecuted. All English lodges were reputedly descendants of the exiled Templars 
according to Hund, who therefore claimed his order was the legitimate form of 
Masonry. The theory that the Templar knights had stumbled across occult wisdom 
hidden in caverns under the temple mount and practised it secretly similar to the 
hermetic scholars of old was a popular theme among masons, accounting for the 
introduction of numerous ‘Templar grades’ in Masonic rites, the symbol the 
Templar masons adopted was a skull and crossbones. Another strange contender 
to legitimacy was the charlatan Count Cagliostro (1743-1795) who claimed to have 
received mystic powers at the ancient pyramids of Egypt, inventing a new Egyptian 
Masonic Rite with which he attempted to “ ... exercise universal jurisdiction over 
Freemasonry” according to the New Encyclopaedia of Freemasonry. 75 Cagliostro 

75 Arthur Edward Waite, A New Encyclopaedia of Freemasonry (Ars Magna Latomorum), And of Cognate 
Instituted Mysteries: Their Rites, Literature and History ~ Combined Two Volume Edition, Vol. / (New 


62 






Rare Masonic Steward's apron dating from the 1800s 
with the Eye of Divine Providence above a silver cornucopia. 


York: Wing Books, 1996), p. 90. 



















allegedly founded a private Temple of Isis in Paris where he ordained himself High 
Priest, or Copht, Bearer of the mysteries of the gods Isis and Anubis from the Far 
East. It quickly grew in popularity until the lodges of France rejected his ‘order’ 
and it dwindled into obscurity. However, before it lost its popularity it was a rite to 
be reckoned with and was influential in establishing Egyptian-oriented rites such as 
the Rite of Mizraim. 

In all, instead of solidifying the various lodges, myriads of new Masonic rites 
and orders mushroomed, competing against or using each other, their strange 
theories rising into popularity or falling into obscurity, each founder squabbling 
over who had discovered the true history of Masonry, or who were the legitimate 
guardians of esoteric wisdom and could lead mankind to the surest path of 
perfection. We cannot help but notice that in Lord of the Rings Tolkien may have 
alluded to the deep ‘secret devilry’ introduced by this strange proliferation of 
constructed legends and rites, in particular, the Templar legends that continue to 
intrigue people today. King Solomon’s Temple was built on Mount Moria (2 
Paralipomenon 3:1) the exact same name Tolkien calls his fabulous underground 
kingdom of the Dwarves. Just as wise King Solomon’s temple and kingdom were 
associated with one* precious metal, gold, the alchemical symbol of wisdom among 
the hermetic scholars, Tolkien’s Moria is prized for its extremely rare mithril, the 
priceless metal of kings and princes. However, the Dwarves burrowed too far into 
Moria in their quest for mithril and unleashed the terrifying Balrog of the depths, a 
demon-servant of the satanic Morgorth as we recall. In the end, evil creatures 
overtook their beloved kingdom and the Dwarves were forced to abandon their 
realm. No doubt Tolkien was secretly jabbing at the hermetic scholars who delved 
too deep into forbidden places in their quest for the hidden ‘gold’ of wisdom and 
ultimately unleashed the multi-headed hydra of Masonic spiritualism. Only the 
Angelic Pontiff of the Church would eventually put an end to the Enemy and his 
useless rites once and for all as symbolised by Gandalf quelling the Balrog of Moria. 

For obvious reasons, the all-inclusive nature of occult esoteric study in 
Freemasonry and its offer of an alternative path to redemption divorced of Christ’s 
organised religion became a great cause for alarm with the Church. 76 Any 
promised path to perfection or salvation derived from pagan religions and 
whitewashed with Christian mysticism was nothing more than a ploy of the devil to 
ensnare the curious through alluring but hazy ‘mysteries’ that lead nowhere. 
Scripture clearly states that all pagan deities are devils and places idolatry in the 
same category as witchcraft, a ‘spiritual adultery’ separating the soul from God. 
Hence, the study of hidden wisdom from the medieval days was no longer viewed 
as a completely innocent academic occupation as it dived straight into pagan 
sources for alternative sources of ‘wisdom’, the term ‘occult’ now viewed as 

“For no account was made of silver in those days,” i.e., during King’s Solomon’s reign. (2 
Paralipomenon 9: 20) 

76 The Russian author Leo Tolstoy indicated this was a particular lure of the Lodges. In War and 
Peace Pierre Bezukhov joins the Freemasons, believing he has found the true path to heaven and the 
surest road removed from the oppressive ‘rules’ of religion. He declares all other creeds are a lie: 
“Freemasonry, he claimed, was Christian doctrine freed from the bonds of politics and organized 
religion, (...) ‘You must understand, my dear fellow, outside this fraternity it’s all lies and deceit.” 
Leo Tolstoy, War and Peace, Volume II, Part II, Ch. 12, Penguin Red Classics, (London: Penguin Books, 
2006), p. 418. Eventually Pierre is disillusioned with the members of the lodge as they joined simply 
to make connections or to be sociable, rarely paid their expected alms to the poor, were too busy 
trying to poniard those who had betrayed the secrets of the lodge, or were scrambling to find which 
lodge had the oldest charters: nearly all members proving to be hypocrites, failing to practise the 
supposed wisdom that they preached. 


64 



something demonic. Mankind still corrupted by original sin could not save itself 
without Christ and the graces of the Holy Spirit. Therefore, Freemasonry could 
offer nothing more than fool’s gold, a spiritual sect with no known or concrete 
foundation in history luring new followers in with the promise of attaining true 
wisdom but failing to deliver, giving nothing but appealing yet illusive vagaries 
followed by the accomplishment of strange rites without any power invested in 
them from Heaven and therefore could not bestow or convey supernatural grace to 
lead man to salvation. 

Freemasonry therefore became an ‘empty’ organisation in contrast to the 
Church and its grace-giving seven Sacraments established by Christ Himself: two of 
which imparted the gifts of the Holy Spirit, Baptism and Confirmation, one which 
restored grace when lost through sin, the Sacrament of Penance, and of course, the 
Blessed Sacrament of His own Body and Blood, the Eucharist that sustained body 
and soul unto Life Everlasting. No other religion, sect or fraternity possessed the 
promised gifts of Christ and the Holy Ghost, nor had the power to forgive sin and 
impart grace. Anyone who attempted to seize Christianity and its mysticism while 
at the same time setting themselves apart from Christ’s one and only Church, or 
claimed to have the secrets to salvation, or declared that all religions were equal, 
was nothing but a fruitless sham leading souls to perdition. Therefore, Satan, who 
separated himself from God yet could not make his own kingdom and had to 
accept Hell prepared for him and his angels, could not create a convincing ‘church’ 
of his own unless he appropriated the mysticism of Christ’s true Church and used it 
to promote his diabolical aims, turning the original good intentions of the medieval 
freemason guilds into a satanic Antichrist ‘church’. We observe Tolkien’s Lord 
Sauron shares similar characteristics as Frodo remarks: “The Shadow that bred 
them (the ores) can only mock, it cannot make: not real new things of its own.” 77 

This division between Freemasonry and the Church became more apparent 
in the 18 th century when many lodges were used as tools to foster the ideals 
associated with the Age of Enlightenment, in particular, Deism: the belief that the 
‘Sublime Being’ or Creator was not concerned with the affairs of mankind after the 
Creation and left humanity to its own devices. It was the duty of man to tread the 
path of good, and therefore was given the gift of reason to learn how to accomplish 
this, namely, by doing charitable deeds and promoting the concepts of equality, 
fraternity, liberty and love. Deism proposed the belief that reason and observation 
of the natural world alone were sufficient means to determine the existence of a 
Creator, therefore deists rejected religious knowledge as a source of authority, 
including the scriptures. Of course, by rejecting revealed religion in favour of a 
‘natural’ belief system, the deists also cast aside the doctrine of the Holy Trinity, 
which in turn was to reject the concept of a loving God. In all, Deism inferred that 
man was left independent of God, and could advance in perfection by his own 
reasoning power and merits. 

Hence, the proverbial line had been drawn when Deists had abandoned 
everything that was held sacred in the Catholic Church. In addition to rejecting 
religious authority, the Deist concept of an ‘aloof god’ was a completely heretical 
doctrine contradicting the teachings of the Church cunningly masked with the 
Christian ideal of fraternal charity: the idea that mankind could do very well on his 
own without God was nothing short of Satanic pride. In addition, the scriptures 
clearly state God so loved the world He gave up His only Son in order to redeem it. 
The world was not a plaything made on a whim, a mere bauble to be set aside by a 

77 Lord of the Rings, The Return of the King, p. 948. 


65 



bored deity. God had created an Eternal Kingdom out of Love for His Son and 
with His Son, both acting together in union with the Holy Spirit. There could be no 
surer or quicker path back to Heaven than the one God revealed Himself through 
His Son and the Church established by His own Blood in self-giving sacrifice. As 
God is Goodness and Love itself, in fact he is Everything except evil, there is no 
possible alternative to righteousness. Everything else is darkness and hell. Christ 
declared He was the True Vine, and that any branch that separated from Him 
would prove fruitless, it would eventually wither and die, warning everything not 
united to Him will come to nothing. 78 Therefore a similar fate awaited any 
illegitimate order or sect that established itself apart from God as prophesied in the 
Book of Wisdom: “... and bastard slips shall not take deep root, nor any fast 
foundation. And if they flourish in branches for a time, yet standing not fast, they 
shall be shaken with the wind, and through the force of the winds they shall be 
rooted out. For the branches not being perfect, shall be broken, and their fruits 
shall be unprofitable, and sour to eat, and fit for nothing.” (Wisdom 4: 3-5) Of 
interest, we find other texts in Scripture that warn about the ‘doom of nothingness’ 
awaiting the enemies of God, stating that anyone who deliberately separates 
themselves from the Father, Son and Holy Spirit and the path to salvation set by 
Them has chosen all that is not of God ~ a state of ‘nothingness’. “All things were 
made by Him: and without Him was made nothing that was made.” (John 1:4) In 
other words, God not only made the world out of nothing, but anyone or anything 
that openly rebelled against Him was ‘made nothing’ or ‘made void’ and had set 
itself aside in darkness exactly like Satan, described as the Beast that “was and is 
not”. (Apoc. 17:8) 

Tolkien makes a particular point about the ‘nothingness’ that awaits the evil 
ones in Lord of the Rings. We recall how Gandalf commands the evil Nazgul Witch- 
king to depart from the city of the Faithful and return back to the ‘nothingness’ 
prepared for him and his Dark Master; indeed, the evil king leaves no earthly 
remains but disappears into emptiness when he is slain on the Pelennor Fields. 
When the traitor Saruman is murdered, his ‘spirit’ appears as a thick mist, but soon 
disappears into emptiness. “As a cloud is consumed and passeth away: so he that 
shall go down to hell shall not come up.” (Job 7:9) The eye, often considered the 
window to the soul, is a dead aperture in the case of Lord Sauron, the horrific pupil 
of his All-Seeing Eye opening like a black bottomless pit, “a window into nothing” 
Tolkien writes. The Dark Lord Sauron faces the fate of ‘nothingness’ when the 
One Ring is eventually destroyed: he rises up in a huge billowing lightning-crowned 
shadow with a frightening hand, but his power has evaporated. As he grasps 
towards Aragorn and his army, Sauron is blown away by a great wind like the 
fruitless branches mentioned in the Bible and is reduced to emptiness in the end. 
His black kingdom is but a far cry from the royal kingdom of Aragorn symbolised 
by the blessed White Tree of Telperion, the fruitful Tree of Life. 

Returning to the contentions between the Church and the secretive lodges, 
they became more than theological struggles, for several of the secret orders vying 
with the lodges for dominance or acceptance as legitimate rites soon acquired 

78 “I am the true vine; and My Father is the husbandman. (...) Abide in Me and I in you. As the 
branch cannot bear fruit of itself, unless you abide in the vine, so neither can you, unless you abide 
in Me. I am the vine; you the branches: he that abideth in Me, and I in him, the same beareth much 
fruit: for without Me you can do nothing. If anyone not abide in Me, he shall be cast forth as a 
branch, and shall wither, and they shall gather him up, and cast him into the fire, and he burneth.” 
(John 15: 1,4-6) 


66 



subversive political agendas. The most notorious of these orders was the Bavarian 
Illuminati founded by Adam Weishaupt on May 1, 1776, which may be the prime 
source of Tolkien’s secretive Dark Lord and his chosen emblem of the Lidless Eye. 
Although not a Mason at first, Weishaupt attempted to join the fraternity, 
apparently with the aim of ensuring his new version of the Illuminati was accepted 
into the hermetic fold. 79 In fact, Freemasonry already had several orders founded 
under the name ‘Illuminati’ or the ‘Enlightened Ones’, no doubt in reference to the 
scholars of the medieval and Renaissance periods who strove to acquire 
enlightenment through their studies of mystic hermetic wisdom, but Weishaupt’s 
new order had more dangerous objectives. Weishaupt was one of the foremost 
promoters of hard-line Deism: he believed mankind could reach perfection, but not 
until it returned to a simpler patriarchal life. The only way to accomplish this was 
to instigate a great reformation that would ultimately clear the ground, a complete 
eradication of the exiting forms of ‘domination’ supposedly oppressing mankind, 
namely monarchies and all established Christian religion. Only then could this 
‘New World Order’ of the true Illuminati rise up and take its rightful place: 


“In its complexion the Order (of the Illuminati) was anti- 
Christian, because it was an aggressive Deism; it was anti- 
monarchical certainly; and those who describe it as an anti-social 
movement are not far from the mark, if we admit their implicits in 
the use of the term. (...) (Through Deism) Weishaupt sought to 
raise his doctrine of human perfectibility, while the means sought 
for its advancement were political revolution and the destruction 
of all authority, for the restoration of a patriarchal life.” 80 


Although Weishaupt failed to have his new order officially recognised by the 
Freemasons, it continued to spread its destructive influence. Waite declares it “... 
was one definite and highly organised attempt to appropriate Masonry in the 
interest of propaganda which aimed at religious, political and social revolution.” 81 
In the structuring of his new Illuminati order, Weishaupt was inspired by Hund’s 
Rite of Strict Observance and its ‘Unknown Superiors’ upon which much political 
intrigue circled. Weishaupt was further influenced by one peculiar Masonic 
foundation-theory proposed by the Mason C.F. Nicolai: that Freemasonry was first 
established by Francis Bacon (1561-1626) who attempted to establish a secret order 
hidden from the eyes of the world that would bring about a ‘great reformation’. 82 
Nicolai had based his curious hypothesis on Bacon’s Instauratio Magna and also his 
famous unfinished text The New Atlantis (1627), the latter tract presenting Bacon’s 
vision of a secret commonwealth unknown to the world with daily life centring on 
Christian ideals, yet with no visible organised Christian Church, its advanced way 
of life carried out by a priestly brotherhood of scientists who presided over a ‘House 
of Solomon’. Their undiscovered continent remains hidden from the rest of the 
world, yet the New Atlantians are well aware of the other countries around them, 
and in fact, send out secret scouts to observe how far the rest of the nations are 


79 A New Encyclopaedia of Freemasonry, Vol. I, p. 386, Vol. II, p. 67. 

80 Ibid. Vol. I, pp. 386-387. 

81 Ibid, p.386. 

82 Ibid. p. Vol. II, pp. 134-135. 


67 



progressing in scientific matters. Armed with this ‘proof from Bacon’s text, 
Nicolai then dared to propose Bacon attempted to accomplish a similar ‘secret 
reformation’ by establishing the Royal Society of London in order to spread 
knowledge throughout the world via the ranks of a secret society, aka, 
Freemasonry. Influenced by these theories and rumours, Weishaupt constructed 
his New Order with its various rites around a group of Unknown Superiors with the 
aim to spread his destructive anarchist ideals under the dark cloak of secrecy 
doubly-concealed by the guarded exclusivity of the Masonic lodges. It is no wonder 
his subversive ‘Big Brother’ order became associated with the symbols of the 
Freemasons, the Eye of Providence twisted into a sinister emblem of intimidating 
surveillance leering from the shadows. 

In 1784 Weishaupt’s Illuminati order was eventually suppressed by an 
electoral edict in Germany, which lead to the closure of many recognised Masonic 
lodges in the south of the country. No doubt it was believed Weishaupt’s 
Illuminism had already infected the lodges and they were duly closed to prevent the 
spread of civil unrest. Rumours circulated that many of the suppressed Illuminati 
fled into France and were received into several recognised Masonic lodges with the 
result the exiles helped to foment the spirit of the French Revolution. 83 Other 
researchers of Masonic history continued to maintain that the order was never 
completely disbanded and that despite having been rejected by the official masons, 
the order still worked secretly like a virus through the lodges of recognized 
Freemasonry until Weishaupt’s death in 1830, and was in fact, one of the prime 
instigators of the French Revolution, the order sending out various pawns to do the 
dirty work while most of the ‘Unknown’ leaders of Illuminism remained cloaked in 
secrecy. There is evidence that Weishaupt used the charlatan Cagliostro and the 
meteoric rise of his bogus ‘Egyptian Rite’ to inject Illuminism into the lodges of 
Europe. Apparently, Cagliostro himself confessed to the Inquisition in Rome that 
he had received a commission from Weishaupt to groom the French Masonic 
lodges to be receptive to Illuminist doctrine. 84 Of interest, in Lord of the Rings, the 
traitor-wizard Saruman is used in a similar fashion by the Dark Lord Sauron as 
Frodo remarks: “Yes, this is Mordor ... just one of its works. Saruman was doing 
its work all the time, even when he thought he was working for himself. And the 
same with those that Saruman tricked...”. 85 

How successful was Cagliostro in his mission? Considering the secrecy 
surrounding the lodges even to this day, it is difficult to tell. However, we have a 
few personal opinions from famous Masons who it is said joined the Illuminati in 
those days and who dared to let a few things ‘slip’, such as the German author 
Wolfgang von Goethe.” Goethe, a monarchist not supportive of the revolutionary 
schemes, was disgusted at how far the quack Cagliostro had instigated himself into 
the French court. The charlatan had found favour with King Louis XVI and many 
members of the French nobility, fooling them with his claims of possessing magus¬ 
like powers and the ability to produce the famed alchemical ‘elixir of youth’, which 
disgusted Goethe. In his opinion, Cagliostro’s quackery helped to discredit the 
French monarchy as the gullibility of the court occasioned it to lose what little 

83 A New Encyclopaedia of Freemasonry, Vol. I p. 386. 

84 Rev. Mgr. George Dillon, The permanent instruction of the Alta Vendita, Chapter VIII, (Dublin: M. 

H. Gill and Son., Ltd., 1885). Reprint: E-text: www.catholicvoice.co.uk/dillon/text.htm#14 

85 Lord of the Rings, The Return of the King, p. 1055. 

For more information on the Goethe’s interest in alchemy, Freemasonry, the French Revolution, 
and how they influenced his work, see Faust: My Soul be Damnedfor the World, Vol. 2 (Portugal: 
Batalha Publishers, 2010). 


68 



respect it still retained amid the growing dissatisfaction of the French people riled 
up by the disgruntled revolutionaries. Goethe also believed Cagliostro and other 
corrupt members of the court played their part in a premeditated conspiracy to 
deliberately destroy the French monarchy, namely, the scandalous Diamond 
Necklace Affair in which Queen Antoinette was accused of recklessly spending on 
a costly necklace while her people starved. She never commissioned the necklace ~ 
it was an elaborate set-up and jewel heist arranged by the Countess de Mott who 
duped her lover, the Cardinal of Rohan, into ordering the necklace by pretending 
the queen wished him to personally place the commission. Eventually the truth 
came out, the Countess was flogged, branded and imprisoned for life, while the 
Cardinal was acquitted and banished to a monastery. However, the damage was 
done, the final blow came when the Cardinal and Countess were put on trial. 
Cagliostro was also brought forward for questioning as the Cardinal was his 
staunch supporter. Goethe was infuriated about Cagliostro’s ‘performance’ during 
this serious trial on which the reputation of the French court rested, giving the law 
court a load of gibberish and “ridiculous cock-and-bull stories”. 86 In all, Goethe 
observed Cagliostro’s quackery (used by Weishaupt we recall!) helped to put the 
nail in the coffin of the absolute French monarchy: 


“I saw the dignity of royalty undermined and doomed by 
this incredibly wicked plot, and unfortunately everything that 
happened from that time only confirmed my fearful forebodings. 
(...) For many years I had been dismayed by the frauds peddled by 
bold visionaries and calculating fanatics and had had occasion to 
curse them roundly; and I had been amazed and repelled by the 
incomprehensible blindness of otherwise intelligent people in the 
face of such brazen importunities. Now I saw before me the direct 
and indirect consequences of such follies, (i.e. the French 
Revolution), which led to crimes and offences against royalty and 
had an effect powerful to shake to its foundations the fairest throne 
in the world.” 87 


Of course, history tells us what eventually happened next, the following is a 
brief summary: the Revolution erupted, the Church and the nobility were despoiled 
of their lands. With the monarchy overturned and the aristocracy in tatters, the 
majority of the surviving nobility fleeing into exile, the Church was left without its 
royal defenders and the New Order of France was free to take shape in the form of 
a democratic Republic championing liberty, equality and fraternity, which in turn 
brought about a bloodthirsty Reign of Terror (1793-1794) in the new jostle for 
power. Churches were plundered and submitted to terrible desecrations, such as 
undergoing new ‘consecrations’ as temples to their new principles of Deism and 
Liberty. A sacrilegious ritual was held in Notre Dame in which atheists lit a flame 
to the power of Reason. Loyalists to the throne were rounded up, thousands of 


86 Goethe, letter written in Sicily, April 13-14, 1787, Italian Journey [1786-1788], Reprint, W.H., 
Auden and Elizabeth Mayer, trans. (London: Penguin Classics, 1970), p. 248. 

87 Johann Wolfgang von Goethe, Campaign in France 1792. Siege of Mainz, in Goethe: The Collected 
Works, Vol. 5, Trans, Ed. Thomas P. Saine, Ed., Jeffrey L. Sammons, (Princeton, New Jersey: 
Princeton University Press, 1994), p. 743. 


69 



anti-revolutionaries were slaughtered. The Holy Ampulla miraculously brought 
centuries ago by the Holy Ghost to anoint Clovis I and his house was smashed in 
1793, only a few fragments were saved. King Louis XVI was executed on January 
21, 1793 just before the Terror began, while Queen Marie-Antoinette was executed 
nine months later on October 16, 1793. 



Reliquary holding the surviving fragments 
of the Holy Ampulla at the Tau Palace in Rheims. 


70 




Artistic recreation of the original reliquary holding the Holy Ampulla by Sergey Prokopenko 
(2012) according to surviving sketches. The vial containing the oil is held by a representation 
of the Holy Spirit in the form of a dove. A remnant of the oil was saved the day before the 
Ampulla was publicly destroyed by the Revolutionaries in 1793. 













The thirst for revolution and the desire to put an end to the ancient 
monarchical order of Europe, and indeed of the Church, did not stop with France. 
Years earlier, the American Revolution had already commenced with the Signing 
of the Declaration of Independence referring to the (Deist?) God of Nature a few 
months later after Weishaupt founded his New Order in 1776. While the founding 
fathers of the newly fledged United States simply wished for independence and did 
not set out to dispatch their monarch, their new image of the republic advocating 
the separation of church and state was decidedly Masonic. Many of America’s 
revolutionary heroes were or became Freemasons, such as Benjamin Franklin, 
George Washington, Robert R. Fivingstone and Paul Revere. In fact, Washington 
encouraged his soldiers to become Masons with the result the ideals of 
Freemasonry became the new ‘image’ of their nation. 88 Millar observes: 


... America was not only looking to build its communities, 
it was also looking to represent itself visually. With public displays 
of Washington, first president of the United States, (laying the 
cornerstone of the Capitol building in full Masonic regalia), such 
an enthusiasm for Masonic symbolism was inevitable, because it 
sent the message that the morals and ideals of the newly 
independent America were synonymous with those of 
Freemasonry.” 89 


It is difficult to discern the extent of which Illuminism may have influenced 
American politics, but we find a curious set of symbols represented on the reverse 
side of the dollar bill that appear to be a tribute to Weishaupt’s ideals: a Masonic 
lodge or temple represented in the shape of an Egyptian pyramid, the base 
displaying the year 1776 in Roman numerals, the year of the American Revolution 
and the foundation of the Illuminati. Over the temple hovers the All-Seeing Eye, 
above which we see a scroll, ‘Annuit coeptis ’, ‘He has smiled on our undertakings’, 
while under the pyramid’s base we find ‘Novus order seclorum’ ~ New Order of 
the Ages. 

While America gained its independence and was busy establishing its new 
identity as a democratic republic, there were many upheavals in French politics for 
decades to come, particularly after Napoleon placed the crown on his head as 
Emperor in 1804 and foisted upon France a rival bloodline to the throne. A triple 
clash raged for decades with certain factions demanding a republic, opposed by 
other parties and their efforts to restore the French throne under the legitimate 
surviving descendants of the Bourbon Kings, contended by those who wanted to re¬ 
establish Napoleon’s descendants as rulers of France. Eventually, the royal line of 
the Bourbons became extinct with the death of the Count of Chambord in 1883, 
which ultimately secured the establishment of Third Republic, hence it was thought 
that any hope or possibility of restoring the absolute, or even a constitutional 
monarchy in France was quashed once and for all, the new revolutionaries in the 
Chamber of Deputies at that time going so far as to propose that the government 
auction off the crown jewels as one deputy declared, “Without a crown, there’s no 
need for a king,” which was done in 1887. With the royal jewels scattered, the 

88 Angel Millar, Freemasonry: A History (San Diego: Thunder Bay Press, 2005), p. 205-209. 

89 Ibid. pp. 211,216. 


72 




The Great Seal of the United States 
on the reverse side of the one dollar bill. 


















































republicans succeeded in keeping the current democratic form of government and 
hoped that they had put an end to any further hopes of an absolute monarchical 
restoration, forgetting the ancient tradition of the heaven-blessed blood-line in that 
the French king makes the crown, the crown does not make the king. This turn of 
events with several contenders in France may have inspired Tolkien’s inclusion of 
the Stewards’ guardianship of Gondor in Lord of the Rings. As we recall, the 
Stewards skilfully prevented the legitimate kings of the Northern Scion from taking 
the throne of Gondor by persuading the people to enthrone a distant relative of 
Isildur’s eldest son from the Southern scion. Lacking in support and in order to 
keep the peace, the Northern line directly descending from Isildur’s second son does 
not press its claim, yet the Stewards do not relinquish their guardianship of the 
realm when the Southern Scion eventually becomes extinct. For centuries the 
Stewards arrogantly rule like kings despite their status as mere stewards, much like 
the Presidents of the French Republic who are viewed as temporary kings, but do 
not have any royal blood or a legitimate claim to the kingship of France. 

Continuing our study, France was not the only country to fall victim to the 
poisonous influence of secret societies using Freemasonry for its own ends: a 
conspiratorial order with its own initiation rites called the Carbonari or ‘Charcoal 
Burners’ formed in Italy to complete the great reformation left undone by the 
Illuminati. According to Rev. Dillon, a series of documents dating from the 1820s 
revealing the secret plans of the ‘Alta Vendita’, the Unknown Superiors of the 
Carbonari, came into the possession of the Roman police detectives. One of the 
supposed Superiors using his code name ‘Piccolo Tigre’ penned a chilling set of 
instructions to their Piedmontese branches on how to topple the current order by 
inciting uprisings demanding republican constitutions and infiltrating the Church 
from within in order to bring it down, especially through the destruction of the 
family unit: 


“ (...) All Italy is covered with religious confraternities, and 
with penitents of divers colours. Do not fear to slip in some of 
your people into the very midst of these flocks, led as they are by a 
stupid devotion. Let out agents study with care the personnel of 
these confraternity men, and they will see that little by little they 
will not be wanting a harvest. (...) The essential thing is to isolate 
a man from his family, to cause him to lose his morals. He is 
sufficiently disposed by the bent of his character to flee from 
household cares, and to run after easy pleasures and forbidden 
joys. (...) Lead him along, sustain him, give him an importance of 
some kind or other; discreetly teach him to grow weary of his daily 
labours, and by this management, after having separated him from 
his wife and children, and after having shown him how painful are 
all his duties, you will then excite in him the desire of another 
existence. Man is a bom rebel. Stir up the desire of rebellion until 
it becomes a conflagration, but in such a manner the threat of 
conflagration may not break out. (...) When you shall have 
insinuated into a few souls disgust for family and for religion (one 
nearly always follows in the wake of the other,) let fall some words 
which will provoke the desire of being affiliated to the nearest 
(Masonic) lodge. (...) You divine his inclinations, his affections, 


74 



and his tendencies; then, when he is ripe for us, we direct him to 
the secret society (i.e. of the Carbonari) of which freemasonry can 
be no more than the antechamber. (...) In the present 
circumstances never lift the mask. Content yourselves to prowl 
about the Catholic sheepfold, but as good wolves seize in the 
passage the first lamb who offers himself in the desired conditions. 
(...) It is of absolute necessity to de-Catholicize the world. (...) 
The Revolution in the Church is the revolution en permanence. It 
is the necessary overthrowing of thrones and dynasties. (...) Let us 
not conspire except against Rome.” 90 


The fires of revolution flamed from that time on, anticlerical and anti- 
monarchical movements influenced by this political society continued to spread. 
For example, a Carbonari faction was formed in Portugal in 1822 but disbanded 
not long after. However, a new organization of the same name and claiming to be 
its continuation was founded by Artur Augusto Duarte da Luz de Almeida in 1896. 
Similar to the original Carbonari movement, the new Carbonari of Portugal were 
hostile to the Church and contributed to the republic’s anticlerical formation. In 
fact, Carbonari members were active in the assassination of King Carlos I of 
Portugal and his heir, Prince Luis Filipe, Duke of Braganca in 1908. Carbonari 
members were also involved in the Republican revolution of October 5, 1910. 

Other revolutions around the same period were brutally anti-clerical, we turn 
to Mexico for another example, the Revolution of 1910-1920. An anticlerical 
Constitution was ratified in 1917, resulting in the counter-revolutionary Cristero 
War 1926-1929 in which thousands of Catholics were persecuted and martyred, 
many of those put to death cried out with their last breaths the rallying cry ‘Viva 
Cristo Rey’~ “Long Live Christ the King”.* Although a peace was eventually 
reached in 1929 allowing Catholic churches to reopen in Mexico, many of the 
anticlerical laws were not repealed until 1992. 

In all, for those interested in Catholic mysticism and history, there is 
considerable controversial evidence that many of the modem republics and 
democracies formed in the last two centuries began as deliberate attempts by 
Masonic and other secret sects to destroy both monarchies and the Church. 
According to the prophecies, several mystics warned that before the appearance of 
the Great Monarch and the Angelic Pontiff, evil would flood the world due to the 
rapid expansion of republics, suggesting it is the lack of absolute monarchies caused 
by the rise of liberal democracies declaring the equality of all religions, plus the 
abuse of liberty as a way to promote licentiousness, that will cause heresies and 
amorality to spread. Mother Mariana de Jesus Torres (1635) in Quito Ecuador 
revealed, “... at the end of the 19 th century and for a large part of the 20 th , various 
heresies will flourish on this earth which will have become a free republic. The 
precious light of the Faith will go out in souls because of the almost total moral 
corruption.” 91 If Tolkien’s Steward Denethor loosely represents the rise of republics 
usurping the power of kingship, we see his character falls under this prophecy to a 


90 Alta Vendita, Ch. XII. 

It was during this bloody persecution that Pope Pius XI first instituted the feast of Christ the King 
on December 11, 1925. 

91 We Are Warned, p. 533. 


75 



certain degree: Denethor is touched by the Evil Eye and believes its lies. Falling 
into despair, he abandons the true faith of Numenor and wishes to die as the 
heathens of old by sacrificing himself and his son on a burning funeral pyre, no 
doubt a hideous scandal to the faithful people of Middle Earth.® 

Returning to the prophecies, Marie-Julie was explicit in saying that heaven 
was displeased with democracy as it was a form of government designed by hell 
and that France would be severely punished for bringing revolutions upon the 
earth: “The Blessed Virgin told me we have to pray much to deflect the evils that 
must fall upon France. It will unfortunately atone for two centuries of political and 
social atheism, two centuries of a non-Christian regime. Democracy is indeed the 
Luciferian regime par excellence. The sole regime of a divine origin never comes 
from below, but only from above. Without making a pun, let us say in its very 
name, recognizes that it is the devil that guides demo-c racy: the devil is the 
master.” 92 Many times Marie-Julie declared Heaven considers the French Chamber 
of Deputies as the ‘Chamber of Hell’, and Paris a new Sodom due to its treacheries 
and iniquities. We note another mystic, Maria Simma reported c. 2002 that the 
souls in Purgatory revealed to her democracy was not a God-given right, 93 implying 
a republic was nothing but self-rule grabbed by mankind similar to Satan who 
rebelled against God. 

The few examples of democracy in the Bible are certainly not encouraging: 
when given a choice over who should be released to them, the Jews chose a thief, 


In Lord of the Rings, the faithful peoples of Middle Earth reverently bury their deceased. The 
Kings of Gondor have dignified ‘houses of the dead’ where their people are laid to rest, the Kings of 
Rohan bury their dead in sacred mounds, and the Dwarves lay their dead in tombs hewn from stone. 
The Dwarves in particular abhor cremation and resort to it only when necessity requires it, such as 
after the grievous Battle of Azanulbizar when the number of their dead was so great it would have 
taken years to carve their tombs and so they had no other option but cremation to ensure the bodies 
of their war-heroes were not desecrated by beasts or carrion-eating ores. {Lord of the Rings, Appendix 
A, p. 1113, n. 1.) Hence, we discover that the condemnation of suicide, (unless the suicide victim is 
mentally afflicted), and the abhorrence of cremation are two other instances where traditional 
Catholic doctrine and devotional practises are alluded to in Lord of the Rings. Traditional doctrine 
maintains that it is an abominable abuse to cremate the dead as the body had housed the immortal 
soul and had been the temple of the Holy Spirit. Theologians cite examples in which even pagan 
nations such as the Romans and Egyptians once used to bury or embalm their dead, their graves 
were considered sacred until their culture and manners became corrupt. A Christian should imitate 
Christ, whose Body was laid reverently in a tomb, hence burial is considered the most dignified 
treatment of laying the dead to rest. Unless cremation is necessary due to pestilence, it is regarded as 
an uncivilized manner of burial for the worldly and the unbeliever to practise, a convenient way to 
dispose of all reminders of death that would eventually bring an end to all earthly amusements. 
Furthermore, it is taught that to cremate a body is also reprehensible in the interests of justice, for a 
body may be exhumed if a crime needs to be investigated, but all evidence of a crime is destroyed 
after cremation. “Those therefore who speak in favour of cremation befriend criminals, inasmuch as 
they aid in the removal of all traces of their crime.” Rev. Francis Spirago, The Catechism Explained: 

An Exhaustive Exposition of the Catholic Religion (1899), (Reprint: Rockford, Illinois: Tan Books and 
Publishers, Inc., 1993), pp. 701-702. 

Rev. Spirago also writes: “Christianity did, in fact, abolish cremation. But in these 
days, when Christian faith is on the decrease, cremation is once more becoming the fashion. (...) No 
true Christian can fail to shrink from the horrors of cremation; only those who are lost to all sense of 
the dignity of human nature, to all belief in the truths of religion, can desire it for themselves.” Ibid, 
p. 702. 

92 We Are Warned. Vision dated April 20, 1874, p. 25. 

93 Nicky Eltz, Get Us Out of Here!! (Medjugorje Web: 2002). Re: Maria Simma (1915-2004); this 
mystic is awaiting Church approval. Although her revelations have not yet been officially approved, 
they are not yet condemned either as far as we are aware, hence this statement has been included in 
this study. 


76 



rebel and murderer instead of Christ whom they had hailed as their King a little less 
then a week previously, showing how democracy can be a fickle form of 
government subject to the changing opinions of mob rule. The Bible commands, 
“Thou shalt not follow the multitude to do evil; neither shall thou yield in 
judgement, to the opinion of the most part, to stray from the truth.” (Ex. 23:2) 
Hence, according to the scriptures, a government run by majority rule has the 
inherent danger of luring the masses into believing something evil is ‘all right’ if the 
many vote for a law or motion that may in fact be quite evil and contrary to God’s 
laws. True, there have been many corrupt kings in the past that failed in their duty, 
but as the Bible reminds us: “ ... shall a man be more pure than his Maker? Behold 
they that serve him are not steadfast, and in his angels he found wickedness.” (Job. 
4:17-18) There is always the risk of corruption, but that does not give mankind the 
excuse to reject the form of government most acceptable to God. St. Faustina 
revealed that a soul cleansed from sin and on intimate terms with God recognises 
that it “comes from royal stock”. 94 Christ taught His disciples to pray, “Thy 
Kingdom come. Thy will be done on earth as it is in Heaven.” Heaven is not a 
republic. 

This denunciation of democracy by the mystics is certainly a harsh rebuke, 
and no doubt sounds irrational to people today now convinced democratic 
republics are the best and most just form of government. It certainly sounds fair that 
the people should elect their own rulers as no one wants the ‘tyrants of old’ to 
return; however, if there is even a suspicion that secret political societies directly or 
indirectly influenced the formation of modern day republics as mentioned earlier, 
can anyone be entirely sure that this entrenched perception denouncing monarchies 
is not the result of a deliberate vilification of the monarchical order? Democracy 
certainly has its own set of gaping if not worse flaws, particularly with political 
divisions. A nation can be splintered apart more rapidly from within by 
dysfunctional political parties jostling for power and racing to secure their own 
interests and seats, not to mention limited terms of office ensure that any real 
progress made in the interests of the nation will more often than not come to a 
grinding halt as one side press forward their own agendas and block those of 
another, the process repeating itself as majorities in office are gained or lost with 
each election. There is also the unseen corruption: how often do money and the 
‘power behind the scenes’ dictate the polices of a republic to the detriment of the 
people? We must not forget democracy does not guarantee a government will not 
end up burdening its people with excessive taxes that are then outrageously 
misspent, that the nation will not be mutated into a police-state, or escape being 
strangled alive by a ‘red-tape dictatorship’ for that matter, the laws of a country 
becoming so oppressive under the guise of protecting civil liberties that the citizens 
fear their own governments. There are many forms of tyrants, but there are none so 
terrible as those stifling their own people in the name of freedom. Of interest, 
Tolkien penned the following in a letter to Christopher Tolkien dated November 
29, 1943: 


“My political opinions lean more and more to Anarchy 
(philosophically understood, meaning abolition of control, not 
whiskered men with bombs), or to ‘unconstitutional’ Monarchy .” 

94 St. Sr. M. Faustina Kowalska, Divine Mercy in My Soul: The Diary of the Servant of God, Sr. M. 
Faustina Kowalska. Notebook 1, entry 120, (Massachusetts: Marian Press, 1987), p. 67. 


77 



In other words, by considering ‘anarchy’, Tolkien no doubt meant a 
peaceful dissolution of the constrictive forms of government currently existing, 
(democracy and communism?) to allow a new government to take place. He 
obviously did not favour ‘lawless mayhem’ brought about by terrorists according to 
the popular interpretation of the word as he simultaneously leaned towards the 
conservative right in supporting absolute monarchy. It is possible he yearned for 
the complete abolition of all anti-Catholic forms of rule that rose up since the 
American and French revolutions, which would allow for the prophesied renewal 
of the absolute monarchies and the Church to take place, not to mention the 
glorious Age of Peace that was promised. We find Tolkien’s political sentiments 
are in keeping with one particular revelation given to Marie-Julie in that the Great 
Renewal could not occur until Heaven intervened with cataclysmic events and 
cleared the ground for the ‘new seed’ of the Church to flourish. Everything that 
was established after the Revolution and opposed to the absolute monarchy will be 
swept away: 


“The hour of God is not far,” says Saint Michael, “this 
profound terror will (bring about) the triumph of the new France. 
But this triumph cannot come before (if) Justice is not pressed 
down on this rotten land. (...) To reinstate the King chosen and 
destined by God, it is necessary that all those who are present (i.e. 
in the present form of government) be swept away.” 95 


Indeed, many Catholic mystics foretell that all republics would be eradicated 
like useless weeds and fruitless branches with the arrival of the Great Monarch. 
Ven. Bartholomew Holzhauser (1613-1658) prophesied: “The powerful Monarch, 
who is sent from God, will uproot every Republic.” 96 

However, according to many of the prophecies, the situation on earth will 
become much more dire before the expected King and Angelic Pontiff arrive: anti¬ 
clerical ideals devised by the secret sects would also infect the hierarchy of the 
Church and they would be used to attack it from within. Bl. Catherine Emmerich 
noted in 1820, “I see more martyrs, not now, but in the future...I saw the secret sect 
relentlessly undermining the great Church.” 97 Ominously, Waite hints to a 
Masonic infiltration in his Encyclopaedia of Freemasonry, writing that there were 
forces attempting to bring a “Catholic scheme of Masonry” into the Brotherhood 
that were “one at root with the Church and behind the Church” with the prediction 
that the Church and the Brotherhood will someday enter “into one consciousness.” 


95 Vision c. September 29, 1878, Ibid, pp. 149-150. Is it possible that this vision refers to events in 
our own times? In the same vision, St. Michael warns God’s people not to place their confidence in 
one ruler who is described as a ‘pillar of mud’, he will do nothing to reform the government into an 
absolute monarchy. French President Sarkozy’s father comes from Hungarian aristocracy, but 
obviously President Sarkozy was not the ‘chosen one’. “Sar” and “Kos” are Hungarian words for 
‘dirt’ and ‘mud’. “Sark” also means ‘pole’, so President Sarkozy could literally be referred to as a 
‘pole’ or ‘pillar’ of mud! 

96 Bartholomew Holzhauser, Visions (1646), in We Are Warned, p. 536. 

97 We Are Warned, p. 546. 

98 Encyclopaedia of Freemasonry, Vol. 1, p. 33. 


78 



In the ‘Alta Vendita’ documents we discover the Carbonari political sect schemed 
to have a pope moulded according to their desire get elected to St. Peter’s seat, and 
were willing to work at their bold plan for a century if need be. We discover a 
Carbonari member code-named ‘Vindex’ wrote to a ‘Nubius’ in 1838: “It is 
corruption en masse that we have undertaken: the corruption of the people by the 
clergy, and the corruption of the clergy by ourselves; the corruption which ought, 
one day to enable us to put the Church in her tomb. (...) The best poniard with 
which to strike the Church is corruption. To work, then, even to the very end.” 100 

Many of the prophecies state that due to the moral corruption of clerics, the 
disciplines of the Church will become lax and that the form of the liturgical 
traditions as they had been practised for centuries would disappear for a certain 
period. Marie-Julie warned in 1880, “All the works approved by the infallible 
Church will cease to exist as they are today for a time.” 101 She also revealed that a 
rebellious priesthood not of Christ within the Church would institute a ‘New Mass’ 
with words odious in Heaven’s sight, it will be a new rite that is sealed with “the 
words of the abyss” 102 and composed by enemies of the Faith that will be of the 
same spirit as those who conspired to bring about Christ’s Crucifixion, 103 obviously 
referring to the Jewish sects that yearned for a Messiah that corresponded to their 
worldly ideals. 

Many of the traditionalist faithful in the Church note this could be none 
other than a forewarning about the ‘Revolutionary’ Vatican II council that brought 
in the new vernacular Rite of the Mass and use of the vernacular in other 
ceremonies contrary to what had been taught for centuries. Since the Council of 
Trent (1545-1563) when the Latin Rite of the Mass was set for all time by Pope Pius 
V, it had always been declared that by adhering to the use of Latin as its official 
language, the Church maintained its unity and was a means of preserving the faith 
from many evils. The use of the one and same language in all the Catholic 
churches around the world served as a connecting tie binding them to Rome, and 
drew together a multitude of nations divided by language into one unity as 
members of God’s family in the Church. The rites were the same no matter where 
a believer attended in the world: One, Holy, Catholic and Universal Church. 
Furthermore, the use of a dead language not commonly spoken among the people 
was not subject to change like vernacular tongues, and therefore Latin was a means 
of preventing doctrinal error and heresies from entering the Church: it was taught 
that these evils would inevitably arise from a multiplication of translations if the 
vernacular was introduced since the context and expressions of living vernacular 
languages changed on a regular basis. The use of the sacred unchanging ancient 
Latin language also imparted great reverence and dignity to the sacraments, in 
particular, the most important liturgical celebration of the Church, the sacrifice of 
the Mass. As a sacrifice, it was to be offered with all reverence possible, hence the 
vernacular was not to be used as this would imply an ‘instruction’ of the mysteries 
offered to the people and not a sacrifice. All instruction about the Mass was to be 
taught separately to the congregation at appropriate or specially designated times. 
We find nearly all Latin missals and catechisms dating before Vatican II point out 
these differences, reminding the faithful that when the Protestants broke away from 

99 ‘Alta Vendita’: Ch. XIV. 

100 Ibid. Ch. XV. 

101 We Are Warned, p. 235. Vision dated June 1, 1880. 

102 Ibid. p. 285. Also reiterated in a vision dated November 27, 1901: other sources say this vision 
was given in 1902, p. 353. 

103 Ibid. p. 353. 


79 



the Church and denied the sacrificial nature of the Mass contrary to the Church’s 
teaching they began to use the vernacular in their services. 

Suddenly, contrary to everything it had taught before, the Church began to 
abandon its universal application of Latin, the Mass was changed to the vernacular 
and then a new rite was introduced shortly thereafter, a service which is word for 
word and action for action exactly like the Protestant rite. Considering the Church 
now sanctions an opposing course of action against what it had taught for centuries, 
i.e. that use of the vernacular would allow a multitude of evils to creep in, it is no 
wonder that the Vatican II Council has been called a diabolical ‘revolution’ within 
the Church by the traditionalists. Even Pope Paul VI noticed that something 
dreadful was happening after Vatican II, (yet did nothing to repeal the decrees of 
the Council): 


“It is an interior upheaval, acute and complicated, which 
nobody expected after the Council (Vatican II). It is almost as if 
the Church were attacking itself. We looked forward to a 
flowering, a serene expansion of conceptions which matured in the 
great session of the council. But ... one must notice above all the 
sorrowful aspect. It is as if the Church were destroying herself.” 104 


Tolkien was without doubt dismayed when these changes occurred as 
languages were very important to him. Not only was he knowledgeable in existent 
ancient languages, he invented his own, devoting a considerable number of pages 
on the history, letters, spelling and pronunciation of his various fantasy languages 
of Middle Earth in his text, the symbolic use of which plays a considerable role in 
Lord of the Rings. We recall that the rebellious Numenoreans who separated from 
the Faithful and challenged the Angelic Valar abandon the ancient High Elven 
language, one of the most esteemed in Middle Earth, and embrace their own 
common tongue as a sign of defiance. Language is also symbolic of creating an 
identity: the Dwarves keep their language secret and use it only among themselves 
as a sacred tongue, while Lord Sauron invents a Black Speech to be used by his evil 
minions and inscribes the famous lines of the One Ring on the magical gold band in 
the same black speech. Tolkien, recognising the abandonment of the Church’s 
official sacred language as something reeking of rebellion adhered to the original 
teachings of the Old Faith and refused to submit, adamantly answering in the 
ancient Latin like a ‘Faithful Elendil’ during the new vernacular services to the 
mortification of all around him as his grandson relates: 


“I vividly remember going to church with him in 
Bournemouth. He was a devout Roman Catholic and it was soon 
after the Church had changed the liturgy from Latin to English. 

My grandfather obviously didn’t agree with this and made all the 

104 Pope Paul VI, Address to the Lombard Seminary in Rome. December 7, 1968. We Are Warned, p. 
569. On another occasion, Pope Paul VI also declared that Vatican II did not bring the promised 
day of sunshine within the Church, but storms and darkness: “It is as if from some mysterious 
crack, no, it is not mysterious, from some crack the smoke of Satan has entered the temple of God.” 
Sermon given during the Mass for Sts. Peter and Paul on the ninth anniversary of his coronation, 
June 29, 1972. We Are Warned, p. 568. 


80 



responses very loudly in Latin while the rest of the congregation 
answered in English. I found the whole experience quite 
excruciating, but my grandfather was oblivious. He simply had to 
do what he believed to be right.” 105 


Obviously Tolkien was aware of the prophecies concerning the rebels who 
would try to infiltrate the Church long before this occurred, hence his public 
demonstration of fidelity to the ancient Latin ways. Curiously, we find he slipped 
in notable references into Lord of the Rings that seems to refer to the dreaded 
‘infiltration’ that would take place: first is the battering ram of Mordor hammering 
the City of Kings, which is named after the ‘hammer of Hell’ and is fashioned in the 
shape of a ‘ravening wolf, a symbol of demonic infiltrators used by St. Paul to the 
Ephesians: “I know that after my departure, ravening wolves will enter in among 
you, not sparing the flock. And of your own selves shall arise men speaking 
perverse things, to draw away disciples after them.” (Acts 20: 29-30) Obviously, 
this analogy was inspired by Christ’s warning “Beware of false prophets, who come 
to you in the clothing of sheep, but inwardly they are ravening wolves.” (Matt. 
7:15) We discover Bl. Catherine Emmerich was shown that Christ used a similar 
term to warn his disciples how to detect certain followers of a secret political society 
that was in league with the Pharisees and Sadducees # and caused considerable 
trouble during His own ministry and that of St. John the Baptist, spying on them 
and setting subtle traps to ensnare them. They were called the ‘Herodians’: 


“(The Herodians) lived very privately and had some kind of 
mysterious organization by which they secretly helped one 
another. Many poor people applied to them, and received 
immediate relief. These Herodians were outwardly great sticklers 
for the prescriptions of the Pharisees, in secret they aimed at 
freeing Judea from the Roman yoke, and consequently were 
closely attached to Herod. They were something like modern 
freemasons. I understood from Jesus’ words that they feigned to 
be very holy and magnanimous, but in reality they were 
hypocrites. (,..)” 106 

“The people complained of their spying into everything. 

(...) the feeling of being constantly watched was very distasteful to 
them. (...) Then Jesus painted the ordinary manner of acting 
among Herodians, applying to them the passage from the Prophet 
Isaias (...) which treats of dumb dogs that do not bark, that do not 
turn from evil, and that tear men in secret.” 107 

105 Simon Tolkien, February 23, 2003. My Grandfather, The Mail on Sunday. See also: 
http://web.archive.Org/web/20080422072235/http:/www.simontolkien.com/irrtolkien.html 

# “The people hurriedly gathered in crowds, and the Doctors of the Law and the Herodians were 
all expectancy to ensnare Him in His doctrine.” The Life of Jesus Christ, Vol. 2, p. 273. 

106 The Life of Jesus Christ, Vol. 2, p. 243. 

107 Ibid. p. 278. The full passage in Isaias: “His watchmen are all blind, they are all ignorant: dumb 
dogs not able to bark, seeing vain things, sleeping and loving dreams. And most impudent dogs, 
they never had enough: the shepherds themselves knew no understanding: all have turned aside into 


81 




“(Jesus) warned the disciples of what people they should for 
the future beware, and described the Herodians in terms so exact 
that no one could fail to recognize them. Among other things, He 
said that they should beware of certain people in sheep’s skins and 
long leathern straps! ‘Beware,’ He said,’ of the profane in 
sheepskins and long girdles!’ By these words, Jesus signified the 
lurking Herodian disciples of John who, in imitation of John’s true 
followers, wore a kind of sheepskin stole around the neck and 
crossed on the breast.” 108 


According to Bl. Emmerich’s visions, the Herodians, like the Pharisees and 
Sadducees, were attempting to establish an earthly kingdom and expected a 
Messiah according to their own world-view: “What He (Jesus) said of the fulfilment 
of the weeks of Daniel, of the near coming of the Messiah, and of the King of the 
Jews, was excellent and quite in accordance with their own ideas. But as He told 
them, they might seek where they would, they would still nowhere find the 
Messiah.” 109 This bears a remarkable resemblance to Marie-Julie’s revelations 
mentioned above that those not of Christ’s priesthood would attempt to change the 
ancient liturgical forms of the Church, and would be of the same spirit as those who 
crucified Him.* Marie-Julie further warns that the infiltrators in the Church would 
not stop at these first attempts to change everything, they will also disperse good 
pastors (bishops) and replace them with others “... formed by hell, initiated in all 
vices, all iniquities, perfidious, who will cover souls with filth ... New preachers of 
new sacraments, new temples, new baptisms, new confraternities...” 110 

If the angelic Istari in Lord of the Rings are representative of the priesthood in 
the Church, then Tolkien also includes references to a ‘fallen member’ changing 
sacred traditions to suit his own ends via the treachery of the once-white wizard 
Saruman, suggesting the author may have been aware of the schemes of the 
Carbonari to corrupt the clergy and their plots to place an imposter-pope in the 
Holy See. We learn during the Council of Elrond held in Rivendell that Saruman 
as leader of the Wise Council helped to combat the forces of Lord Sauron and cast 
him out of the tower of Dol Gulder in ages past when he had assumed the shadowy 
form of the ‘Necromancer’. However, the means to defeat Sauron the first time 
were Saruman’s undoing in the Third Age when the Ring is found again. Saruman 
had studied the Dark Lord’s arts in order to learn how to defeat him, hoping to find 
a weakness, but in the end was captivated by his power, especially his invention of 
the One Ring and was seduced into imitating him. Elrond sadly notes: “It is 
perilous to study too deeply into the arts of the Enemy, for good or for ill.” 111 
Saruman begins to breed his own army of hybrid ores, their dark blood mixed with 
that of men so they have the ability to withstand the sunlight, which the other ores 

their own way, every one after his own gain, from the first, even to the last.” (Isaias 56: 10-11) 

108 The Life of Jesus Christ, Vol. 3, pp. 25-26. 

109 Ibid. Vol. 2, p. 274. 

Compare Christ’s description of the secret-society Herodians as ‘dumb dogs that do not bark’ 
mentioned earlier with Psalm 21 (17-18) predicting Christ’s crucifixion: “For many dogs have 
encompassed me: the council of the malignant hath besieged me. They have dug my hands and feet. 
They have numbered all my bones.” 

110 May 10, 1904. We Are Warned, p. 360. 

111 Ibid, p.282. 


82 



are unable to endure. To the new uruk-hai ore breed he gives their fill of man-flesh, 
plus has dreaded wolf-riders and other evil races enter his lists. As his symbol of 
power, he has chosen a White Hand, the sign of authority that sounds very similar 
to the French main de justice mentioned earlier. As we recall, Bl. Catherine 
Emmerich, was shown the significance of the ‘hand’ in the priesthood, its power to 
cure and bless which priests seldom do, noting that the staff of Eliseus also 
symbolised the ‘hand’ in the same manner and had a mystic connection with the 
bishop’s crosier and monarch’s sceptre, obviously as symbols of authority granted 
to them by God’s Hand. 112 In the case of Saruman, he has taken the symbol of a 
priest’s blessed authority and has turned it into one of tyrannical dominion. H 
attempts to rule over the realm of Rohan, and eventually takes control of the Shire, 
the idyllic pastoral land of the Hobbits, and turns it into an oppressive 
industrialized communistic police-state. The Hobbits are fooled into thinking they 
still have authority in their land by having been granted various official posts such 
as ‘sheriff or ‘deputies’, but are suffocating under a system bogged down by 
senseless laws, and the misappropriation of goods that are never redistributed to the 
people but are stolen by the evil Men overseeing the new government, including 
Saruman. 

Lusting after power, Saruman makes a new alliance with Mordor, and 
although he plans to betray this alliance, he falls under the secret influence of the 
Evil Eye and ends up doing the work of the Eye without realizing it as Frodo 
related. Filled with pride, Saruman begins to refashion the Istari Order into a new 
organisation modelled after his concept of how the Istari should be, not as the 
Immortals have ordained. When Gandalf the Grey seeks his assistance unaware of 
his treachery, he discovers Saruman has a ‘new ring’ and his actually created a Ring 
of Power in imitation of the Dark Lord by his own admission: “For I am Saruman 
the Wise, Saruman Ring-maker, Saruman of Many Colours!” 113 Mocking the ‘Old 
Order’, and indeed, treating Gandalf the Grey with contempt at first, he casts aside 
the revered colour white and displays to Gandalf new ‘vestments’ of his own 
making, a white-seeming cloth that is made of a myriad of flashing colours but 
bewilders those who look on it. Saruman admits he too like Sauron has “many 
eyes” that are in his service, seeking news of the One Ring. Aware that Gandalf 
knows where it is hidden, he attempts to persuade him to abandon the old order of 
the Istari as it was, forget the Eldar and the dying age of the Faithful Numenoreans, 
and join him in fashioning the New Order, first under the wing of Mordor, then 
turn on Sauron and reign in his place: 


“A new Power is rising. Against it the old allies and 
policies will not avail us at all. There is no hope left in Elves and 
dying Numenor. This then is the choice before you, before us. 
We may join with that Power. (...) Its victory is at hand, and there 
will be rich reward for those that aided it. As the Power grows, its 
proved friends will also grow, and the Wise, such as you and I, 
may with patience come at last to direct its courses, to control it. 
We can bide our time, we can keep our thoughts in our hearts, 
deploring the evils done by the way, but approving the high and 
ultimate purpose: Knowledge, Rule, Order; all things that we have 

112 The Life of Jesus Christ, Vol. 1, pp. 19-20. 

113 Lord of the Rings, The Fellowship of the Ring, p. 276. 


83 



so far striven in vain to accomplish, hindered rather than helped by 
our weak or idle friends. There need not be, there would not be, 
any real changes in our designs, only in our means.” 114 


Gandalf does not fall prey to Saruman’s deceit, for the end does not justify 
the means, and ‘The Grey Pilgrim’ remains faithful to the mission of the old Order 
of the Istari to defend Middle Earth against the wiles of Sauron without challenging 
Sauron himself, nor seek power or dominion over Elves and Men. Gandalf rebuffs 
his offer and realizes Saruman by his very treachery no longer holds authority of the 
Wise Council: “I have heard speeches of this kind before, but only in the mouths of 
emissaries sent from Mordor to deceive the ignorant. (...) You were Head of the 
Council, but you have unmasked yourself at last. Well, the choices are, it seems, to 
submit to Sauron, or to yourself. I will take neither.” 115 Saruman imprisons 
Gandalf in his tower, but Gandalf escapes and informs the other members of the 
Wise Council of Saruman’s treachery. Gandalf observes that of all the perils the 
Wise Council had to endure in their fight against the power of Sauron the worst 
was enemies from within: “In all our long wars with the Dark Tower treason has 
always been our greatest foe.” 116 He also says something similar about the despair 
of the Steward Denethor as his lack of hope and faith threatens to tear apart the 
unity of the King’s City: “Even in the heart of our stronghold the Enemy has power 
to strike us: for his will it is that is at work.” 117 Of interest, Gandalf s remarks are 
not unlike Christ’s warning: “And a man’s enemies shall be they of their own 
household.” (Matt. 10:36) 

Returning to the prophecies, due to this internal upheaval, there will be a 
spiritual war between the ‘New’ church established by usurpers from within and 
those faithfully holding on to the ancient traditions. As a result, confusion will 
arise within the Church itself, and indeed, persecutions. Tolkien includes similar 
references in Lord of the Rings. Gandalf, the faithful and more worthy member of 
the Istari, is rebuked and treated terribly by those who have fallen under the 
influence of the Evil Eye. The Steward Denethor does not give him as warm a 
welcome as he does for Saruman when they both wish to conduct research in the 
ancient archives of the royal city. Denethor continually calls Gandalf an old fool. 
The King of Rohan also treats Gandalf with disrespect until he later frees him from 
the malicious influence of Saruman. Under the influence of evil, Denethor and the 
King of Rohan view Gandalf s warnings and words of wisdom as a nuisance and 
bad omens, blind to the fact he is bringing them wise council. In fact, Denethor 
accuses Gandalf of seeking to seize power over the kingdom, the same accusation 
that Saruman makes when Gandalf takes his place and is promoted to the colour 
White. No doubt these accusations are attempts to discredit Gandalf and prevent 
people from placing their trust in him. Gandalf remarks as he rushes to prevent the 
crazed Lord Denethor from carrying out his mad plans: “Work of the Enemy! (...) 
Such deeds he loves: friend against friend, loyalty divided in the confusion of 
hearts.” 118 At one point in Lord of the Rings, the remnant of the Fellowship cannot 
tell Gandalf and Saruman apart: not only do they look alike, but after Gandalf s 


114 Ibid. pp. 276-277. 

115 Ibid, p.277. 

116 Ibid, p.268. 

117 Ibid. The Return of the King, p. 886. 

118 Ibid, p.885. 


84 



assumed death, rumours abound that Saruman is sneaking abroad in the guise of an 
‘old man’ gathering news as though he had assumed the ‘Grey Pilgrim’s’ likeness. 
As a result, Aragorn, Legolas and Gimli mistake the resurrected Gandalf for the 
traitor when he meets up with them again in Fangorn Forest after defeating the 
Balrog, but are surprised to find him promoted to his new role as the White Rider. 
Hence, we see references to prophecies that before the Great Monarch arrives few 
will be able to recognize the True Church from the ‘False’ Church. 

In the end, Good eventually triumphs over Evil in Lord of the Rings, Gandalf 
in his wisdom directs each person on the path they must take in order to further the 
cause of Good, much like an Angelic Pontiff. Frodo and Sam complete their 
mission to destroy the Ring, Sauron as the Evil Eye is obliterated and reduced to 
nothing. Saruman is exiled and eventually is slain by one of his own followers, and 
the New Age of Men begins with the reign of Aragom with Gandalf s blessing, 
obviously inspired by the prophecies of the Great Monarch and the restoration he 
will bring about after Middle Earth has been cleansed. Concerning our own world, 
as the secret societies attempted to destroy both monarchies and Church by 
revolutions, they shall meet the same fate: wars and cataclysmic convulsions of the 
earth shall be used to sweep away all they had set out to accomplish like the 
unfruitful branches mentioned in the Bible. Evil cities shall be toppled by wars and 
counter-revolutions, their ruins left as a warning to future ages. Many prophesies 
declare Paris in particular will meet a terrible fate and will signal the 
commencement of these chastisements: for its crimes it shall be utterly destroyed 
and will never be rebuilt. Fr. Nectou S.J. notes, “Paris will be destroyed so 
completely that twenty years afterwards fathers walking over its ruins with their 
children will be asked by them what kind of place this was; to whom they will 
answer: ‘My child, this was a great city which God has destroyed on account of her 
crimes.” 119 The Abbe Souffrant known as the Cure of Maumusson predicted in 
1828, “Paris will be destroyed, so much destroyed that the plough will pass it by.” 120 
According to another prophecy by Marie-Julie, only twelve survivors will be found 
in Paris. 121 The trouble will commence during the months of June and July with a 
violent civil war started by a handful of conspirators who will purposely set out to 
cause total chaos by setting off explosions under the city, and will incite others to 
revolt throughout the country. 122 The wording of the prophecies seems to suggest 
that it will be a traitorous handful within the government that will start the conflict, 
a manufactured civil war to bring about its own ends. When the government sees 
the revolution begin, it will “be like a bird” and take flight to another country to 
allow free reign to the carnage. 123 Christians will be persecuted and slaughtered, all 
churches will be closed and ransacked. Paris itself will collapse and will be left in 
its desolation. However, it will be in the midst of this turmoil when the Great 


119 We Are Warned, p. 541. 

120 Ibid. p. 553. 

121 Ibid, prophecy dated August 9, 1881, p. 286. 

122 Ibid. April 27, 1877, p. 53-54, June 1, 1877, p. 57, also September 20, 1881, pp. 292-293. 

123 Ibid, prophecy dated April 27, 1877, p. 54. 


85 



Monarch will appear and begin to drive the invading foreigners out of France” and 
restore order in the country before bringing aid to other European nations. 

Concerning the desolation of Paris, Tolkien appears to have included a 
reference with his city of Minas Ithil in the Morgul Vale, once a glorious tower- 
metropolis built by Isildur of the ancient Numenoreans upon their arrival to Middle 
Earth that was eventually captured by the Nazgul Witch-kings. We discover in the 
Appendixes that the last king of Gondor is challenged by the Witch-king not long 
after the city’s capture and he foolishly rides alone to the Morgul Vale to defend his 
honour, but is never heard from again, thus the Southern line of the Kings is 
destroyed and the rule of the Stewards begins, an illegitimate rule that lasts for 
centuries while the security of the kingdom is chipped away little by little. We 
recall the usurpation of the Stewards may symbolise the tumultuous establishment 
of the republic of France and its ‘illegitimate temporal kings’ set up against the 
heaven-blessed monarchy. Over time the once beautiful Morgul Vale ruled by the 
Numenoreans becomes dark and evil under the power of the Nazgul, its very land 
polluted with their black iniquities, very similar to how Paris is described by Marie- 
Julie, a new ‘Sodom’ ruled by the ‘Chamber of Hell’ that will not be rebuilt because 
of its crimes. We find the same fate falls to the Morgul Vale when Aragorn 
assumes the throne as he decrees: “Minas Ithil in the Morgul Vale shall be utterly 
destroyed, and though it may in time come to be made clean, no man may dwell 
there for many long years.” 124 

When will all these catastrophes occur? According to a few time lines 
revealed in some prophecies, the times of chastisements have already started. They 
would begin with plagues, famines, world wars, and natural disasters occurring on 
a more frequent basis and with greater destructive power. Mother Mariana de 
Jesus Torres (1635) warned that hell would be unleashed in the 19 th and 20 th 
centuries. 125 As mentioned earlier, Bl. Catherine Emmerich said Satan would be 
unleashed about fifty or sixty years before the year 2000, while Pope Leo XIII was 
shown the devil would be given about seventy-five to one hundred years to tempt 
the earth, which would make the ‘Age of Satan’ last from about 1950 to 2025, or up 
to 2050 AD. Marie-Julie was told in 1880 that Satan’s reign had already 

Russia is one foreign power that will invade Europe according to the mystic Ven, Sr. Elena 
Aiello. However, in numerous prophecies, it is said that in addition to civil wars, Muslim invasions 
or incursions will once more threaten Europe and that the Great Monarch will eventually drive out 
those who do not convert. Marie-Julie declares France itself will become Muslim before the 
chastisements, a warning that Christians will be outnumbered. (We Are Warned, p. 414) No doubt 
this is another reason why heaven has denounced democracy: majority rule under Muslim 
leadership could be used to suppress or wipe out France’s Christian identity and heritage. Of 
interest, we find in Lord of the Rings that the Dark Lord Sauron has many allies, including men called 
the Haradrim, it appears they are also called Southrons as they come from the south. Dressed in red 
and gold, they are described as having dark faces and eyes, long black hair, and are cruel and fierce. 

(The Two Towers, p. 672). Their weapons are scimitars, (Return of the King, p. 873), and they train 
great elephant-like creatures to use as beast of war, which points to the Arab invasions of the Middle 
Ages: Portugal and Spain in southern Europe were invaded from the south from northern Africa and 
held under Arab dominion for decades. In Lord of the Rings, the Haradrim forces are completely 
destroyed by Aragorn and his Army of the Dead in the Pelennor Fields. Hence, forever more the 
kingdom of the Haradrim lives under the dread of Gondor: “... and to the land of the Haradrim 
came only a tale from far off: a rumour of the wrath and terror of Gondor,” (Return of the King, p. 
882), a detail which may have been inspired by the prophecies concerning the Great Monarch who 
will liberate Europe from the cruelties of militant Islam. 

124 Lord of the Rings, The Return of the King, p. 1005. 

125 We Are Warned, p. 532. 


86 



commenced, 126 which is not out of synch with Bl. Emmerich’s prediction as she 
was also told Satan would prepare the coming of his reign long before the promised 
years. Marie-Julie also warned in 1874 that France would have to pay for its two 
hundred years of democracy: the Revolution occurred in 1789-99, which indicates 
its chastisements would commence sometime around 1989-1999, placing the start 
of its era of punishment within the ‘Age of Satan’ mentioned above. We find a 
similar time of punishment was given to the mystic Sr. Jeanne Royer (Sister of the 
Nativity) (1731-1798) who was shown a sunset in a vision and asked how long it 
would be before nightfall: she calculated about two hours and was told by Christ 
that represented an approximate number of centuries the earth had left before the 
end of time. 127 Considering she died in 1798, we also see another ominous parallel 
with the years given above: two centuries calculated from 1798 gives us 1998. Sr. 
Royer also noted Christ had reserved the exact number of years, so the earth may 
be given more time, obviously if the earth repented, but she was not sure for how 
long. We cannot help but include St. Malachy’s (1094-1148) famous predictions 
concerning the papacy: the saint was shown the successive popes and anti-popes up 
until the end of time and he revealed each of their identities through one-line clues 
written in Latin that are remarkably accurate. According to his time line and 
presuming there is no break in the text, we are already in the pontificate of the last 
mentioned pope: ‘Petrus Romanus’ ~ Peter of Rome, or the ‘Rock of Rome’. The 
last and by far the lengthiest prophecy reads: “In the final persecution of the Holy 
Roman Church there will reign Petrus Romanus, who will feed his flock among 
many tribulations, after which the seven-hilled city will be destroyed and the 
dreadful Judge will judge the people.” 128 

After the various chastisements, if the people refuse to convert, according to 
the mystics there will be one last horrific punishment that will befall the world and 
strip it of two-thirds to three quarters of its godless inhabitants: the Three Days of 
Darkness as foretold in the scriptures when the sun and moon shall be darkened 
and not give their light. Bl. Anna Maria Taigi (1769-1837) revealed: “God will 
send two punishments: one will be in the form of wars, revolutions and other evils; 
it shall originate on earth. The other will be sent from Heaven. There shall come 
over the whole earth an intense darkness lasting three day and three nights. 
Nothing can be seen, and the air will be laden with pestilence which will claim 
mainly, but not only, the enemies of religion.” 129 St. Gaspar del Bufalo (1786-1837) 
stated: “The death of impenitent persecutors of the Church during the three days of 
darkness. He who outlives the darkness and fear of the three days will think that he 
were alone on earth because of the fact the world will be covered everywhere with 


126 Ibid. August 30, 1880, p. 242. 

127 Ibid. p. 544. 

128 St. Malachy, intro. By Peter Bander, The Prophecies of St. Malachy (Rockford: Tan Books and 
Publishers Inc., 1973). Usually, the prophecies reveal the various popes by their family names, or 
by the heraldic devices on their coats of arms when made cardinal or pope. The last prophecies tend 
to be the most ‘metaphysical’ of the list and difficult to interpret. ‘Rock of Rome’ seems the best 
interpretation of this description for Pope Francis as he took the name of St. Francis of Asissi, the 
saint who spiritually saved the Church from crumbling at a dark time in its history through his order, 
the Franciscans. According to tradition, Pope Innocent III saw in a dream in 1207 that the church 
of St. John Lateran, the basilica of the popes, was about to collapse, signifying that the Church itself 
was on the brink of falling apart. However, St. Francis stepped forward and supported the church 
on his shoulder as though he were the comer stone. Impressed with the dream, the pope approved 
the humble friar’s new order. 

129 We Are Warned, p. 550. 


87 



cadavers ... .” 130 Bl. Mary of Jesus Crucified (Marie Baourdi) (1846-1878) warned: 
“All nations will be shaken by war and civil revolutions. During three days of 
darkness, the followers of the evil cause will be annihilated so that only one fourth 
of mankind will survive.” 131 Sr. Palma Maria Adolorata Matarelli d’Oria declared 
in 1863: “There shall be three days of darkness, during which the atmosphere will 
be infected by innumerable devils, who shall cause the death of large multitudes of 
unbelievers and wicked men. Not one demon shall be left in hell.” 132 Ven. Sister 
Elena Aiello (1895-1961) noted: “Clouds with lightning rays of fire and a tempest of 
fire will pass over the whole world and the punishment will be the most terrible ever 
known in the history of mankind. It will last for 70 hours. The wicked will be 
crushed and eliminated. Many will be lost because they stubbornly remained in 
their sins. (...) The hours of darkness are near....Some nations will be purified, 
while other nations will disappear entirely.” 133 Marie-Julie also gives considerable 
details on the Three Days of Darkness. When the punishments begin to fall on 
Paris and the churches are ransacked, that is when the Days of Darkness will 
commence: “There will be three days of devastation, there will not be any more 
Sacrifice, any more Masses (...) it will be three days of Hell. Satan will travel the 
Earth to turn over the shrines, but he will be rejected. (...) In these three days, the 
lights of the heavens will be extinguished and the angels will be dismayed.” 134 In 
another vision Marie-Julie was warned that for three days the sky would be on fire, 
“furrowed by fear of the divine wrath.” 135 The destruction will be so terrible that 
the earth will not be able to produce for many years, France will suffer terribly for 
three years afterwards. 136 She also relates other frightening details; 137 demons shall 
roam the earth and assume horrific forms and the faithful will hear horrible 
blasphemies uttered by them in the air. Blood-red clouds will billow across the sky, 
tumultuous thunder will shake the earth while lightning will sear everywhere and 
even enter people’s homes. Earthquakes will rock the foundations of the earth for 
the entire Three Days, tidal waves will sweep across the continent. Blood will flow 
so greatly that the earth will resemble one gigantic cemetery, the righteous will die 
with the guilty, and the famine afterwards will be great. Three-quarters of mankind 
will perish. Similar forewarnings continue even to our own times. Sr. Agnes 
Sasagawa of Akita was warned by the Mother of God on October 13, 1973: “As I 
told you, if men do not repent and better themselves, the Father will inflict a terrible 
punishment on all humanity. It will be a punishment greater than the deluge, such 
as one will never have seen before. Fire will fall from the sky and will wipe out a 
great part of humanity the good as well as the bad, sparing neither priests or 
faithful. The survivors will find themselves so desolate that they will envy the 
dead.” 138 Concerning the Three Days of Darkness, Marie-Julie was warned they 
would be ‘three days less one night’, and occur on a Thursday, a Friday and a 
Saturday, the Darkness will be lifted on Sunday, God’s day of rest. 139 


130 Ibid. p. 552. 

131 Ibid, p.558. 

132 Ibid, p.561. 

133 Ibid. p. 564. 

134 Ibid., October 27, 1876, pp. 43-44. 

135 Ibid. November 30, 1880, p. 274. 

136 Ibid. 

137 Ibid. January 4, 1884, pp. 342-343. 

138 Ibid, p.570. 

139 Ibid, p.420. 


88 



However, there will be several warnings before it strikes. Marie-Julie notes 
that before the chastisements fall, everyone will feel an interior ‘uneasiness’ and will 
sense that something terrible will not be far away from happening: those who listen 
to the warnings and reform their lives and do penance may be spared. 140 The next 
warning will come in the form of a frightening ‘Two Days’ of partial darkness: the 
sky will turn purple and red, the tops of tall trees will disappear in the ‘lowering’ of 
the sky, trees will also be burned, hail will fall as fire from the sky and leave traces 
of burning, foul rain will fall and blacken the earth, but will not harm the crops of 
the faithful. 141 During these Two Days, no one will be able to look out during the 
day as hot flashes will obscure the vision. 142 These Two Days of warning 
apparently will happen about thirty-seven days before the dreaded Three Days of 
Darkness. 143 There will also be unparalleled signs in nature that will warn humanity 
that something tremendous is about to happen. 

Are there any means of protection against these horrifying days? According 
to a number of mystics, there are, but they are spiritual means and will not avail 
blasphemers. The one sacramental constantly recommended to the faithful is that 
they light a blessed candle in their homes that has been properly blessed by a 
Catholic priest.** In fact, this will be the only thing that will give light in those 
Three Days, electricity will not work, nor will anyone be able to light a fire or lamp. 
Marie-Julie was told that the candles had to be made of 100% pure wax, such as 
beeswax, candles made from any other material would not light. 144 She was also 
told the candles will not give any light in the homes of the wicked. One candle will 
last for the entire Three Days and no storm, wind or earthquake during those Three 
Days will be able to extinguish them. Everything else will shake and topple due to 
the continuous earthquakes, but the table or furniture on which the blessed candle is 
placed will not shake, it will remain perfectly still. Also, these blessed candles will 
be the only thing that will light during the Two Days of warning. 

It is stressed no one should look outside of their houses during the Three 
Days as they will instantly be struck dead. All windows and doors must be well 
covered to prevent the faithful from looking out and seeing God’s wrath. The 
faithful are advised to pray the rosary, and to keep other blessed sacramentals close 
to them such as holy water, the crucifix, and an image of the Blessed Mother as 
these will be the only items that will help dispel the terror for many will die just 
from the shock. The Blessed Mother also promised Marie-Julie that she would 
protect the possessions of the faithful who helped spread devotion to her, remained 
devoted to her, invoked her with devotion, and kept a blessed image of her in their 
homes. 145 According to some prophecies, a handful of unbelievers will be 
permitted to survive so they may recognise the True God and convert, they will be 
witnesses of God’s mercy and justice in future ages. Also, a remnant of the Jews 
will be spared as their final conversion is reserved for the Day of Judgement. 


140 Ibid. August 27, 1878, p. 119. 

141 Ibid. September 20, 1880, p. 246. 

142 Ibid. 

143 Ibid. November 28, 1881, p. 301. 

For example, Bl. Anna Maria Taigi of Rome, Sr. Matarelli d’Oria, and Marie-Julie. 

144 We Are Warned, Sept. 20, (year?), p. 405. 

145 Ibid. p. 405. To preserve the fields, i.e. crops, the faithful are to plant blessed St. Benedict 
medals in the ground in the form of a cross. Ibid., p. 574. Marie-Julie was also shown new 
sacramentals and devotions that would help protect the faithful during the times of the 
chastisements. See pp. 572-588. 


89 



Of course, the punishments foretold sound overly drastic: why would such a 
merciful God destroy the earth in this manner? We read in the Scriptures that God 
will punish the earth by the sins mankind commits: “But the wicked shall be 
punished according to their own devices: who have neglected the just, and have 
revolted from the Lord.” (Wis. 3:10) Also: “That they might know that by what 
things a man sinneth, by the same also he is tormented.” (Wis. 11:17) For this age 
that has ushered in contraception, mass abortions under the pretext of population 
control, not to mention the crimes of genocide and euthanasia, it is just that God 
will punish rebellious mankind and its ‘culture of death’ with what it desires by 
permitting a catastrophic decimation of the human race. Also, as the forces of evil 
brought in revolutions to sweep away and destroy the order He wished to be 
established on earth, God will also tumultuously wipe out everything they 
attempted to build. As we saw earlier, the earth will become so infected by sin, that 
renewal will not be possible by any other means. On many occasions Marie-Julie 
was told that God was preparing the ‘ground’ for the New Seed of the Church, 
hence everything infected by error and sin has to be wiped away to allow the new 
‘seedlings’ to flourish. In fact, she learned Christ does not want to punish the earth 
and had already delayed the chastisements, but if He delayed again and did not 
eventually send the punishments as foretold, not one soul would be saved: every person 
on the face of the earth would be corrupted by sin and there would be no hope of 
salvation. 146 As strange and contradictory as it sounds, the punishment will then be 
an act of mercy for those who survive as they have the opportunity to save their 
souls and become instrumental in the great renewal of the earth. 

After the near destruction of Europe and the horrific calamities that will 
strike the earth, the prophecies state that a miraculous Age of Peace will come, the 
like of which has never nor will be seen again: it will be the last Great Age given to 
mankind before its final test. 


The Great Period of Peace 


Once the chastisements have ended, the Great Monarch shall once more 
establish the Ancient Regime in France and the monarchies of Europe will be 
restored. Schisms and heresies will no longer exist. After the numerous miracles 
that will occur with the arrival of the Monarch and Angelic Pontiff, few will doubt 
which is the true faith. All Christians will convert to the Catholic Church, which 
shall be restored to its ancient traditions under the rule of the Angelic Pontiff. The 
earth will recover from the aftermath of the destruction and enter a period of great 
prosperity, the sciences will grow and be used properly for the benefit of humanity 
while harvests will be abundant. St. Hildegarde (1098-1179) says that during the 
great peace, citizens will be forbidden from carrying weapons, iron will only be 
used to make agricultural tools, the land will become exceedingly fruitful. 147 We 
notice that Tolkien, obviously influenced by the prophecies concerning the Great 
Monarch, includes similar promises regarding times of plenty under Aragorn’s 

146 Ibid. September 18, 1877, p. 60 

147 Ibid, p.524. 


90 



reign as Gandalf declares to Butterbur of Bree: “Then the Greenway will be opened 
again, and his messengers will come north, there will be comings and goings, and 
the evil things will be driven from the waste-lands. Indeed the waste in time will be 
waste no longer, and there will be people and fields where once there was 
wilderness.” 148 We also find that King Aragom reigns “six-score years in glory and 
bliss,” 149 however, the Great Monarch of prophecy will be the last and will leave no 
heirs. 

The Great Monarch will be a king after Christ’s own Heart and will truly 
care for his people and serve them as a virtuous Christian ruler should. 4 He will not 
be pompous and proud, but meek and humble despite his mission as a soldier-king. 
John of Vatiguerro (13 th century) says he will be so humble that he will travel as a 
barefoot pilgrim, yet will be a fearless soldier. 150 St. Andrew of Salos (450-515 AD) 
declares the Great Monarch will be a man of charity and will win the hearts of 
everyone, helping the poor to become rich, bring an end to every war, refuse to take 
bribes, and will abolish taxes for twelve years. 151 There will be no lawsuits in those 
days as everyone will live in charity, there will be no wrong-doers hurting others or 
dragging people into endless litigations. 152 According to Brother John of the Cleft 
Rock (14 th century) the Monarch will establish his capital in Constantinople, 
(currently Istanbul) the former capital of the Christian Emperors founded by 
Constantine. 153 

There is one detailed prophecy by St. Francis of Paola (1416-1507) that the 
Great Monarch will establish the last and greatest order of the Church. They shall 
be called the Cruciferi, or ‘Cross Bearers’ and will “proceed with arms, with prayer, 
and with hospitality.” 154 The Great Monarch shall place the Cross on his standard 
and it will be the symbol of the new order. Apparently the new knights will play a 
major role during and after the chastisements and will be instrumental in 
establishing the Great Peace. Men of great virtue, knowledge, and also skilled in 
war, they will be organised into three groups and resemble the Crusader knights of 
old. The first group will consist of armed horsemen, the second priests and 
religious, the third nurses and healers. The Cruciferi Order will convert the 
Muslims and fallen Christians, and destroy or drive out heretics and tyrants that 
refuse to convert. St. Francis declares many wicked men will be eradicated at their 
hands and they will be the support of the Church both temporally and spiritually 
until the end of time, their reign will not end. Of the Great Monarch himself, St. 
Francis says he will be very holy and will be granted many spiritual gifts, including 
the discernment of souls. We discover Tolkien’s Aragorn possesses a similar gift 
for we read in Appendix A recounting his hidden days as a Ranger: 


148 Lord of the Rings, The Return of the King, p. 1030. 

149 Ibid., Appendix A, p. 1099. 

4 And he said to them: The kings of the Gentiles lord it over them; and they that have power over 
them, are called beneficent. But you not so. but he that is the greater among you, let him become as 
the younger; and he that is the leader, as he that serveth. For which is greater, he that sitteth at 
table, or he that serveth? Is it not he that sitteth at table? But I am in the midst of you, as he that 
serveth:” (Luke 22: 25-27) 

150 Ibid, p.527. 

151 Ibid, p.519. 

152 Ibid. 

153 Ibid, p.528. 

154 Ibid, p.530. 


91 



“ ... he passed out of the knowledge of Men of the West, 
and went alone far into the East and deep into the South, 
exploring the hearts of Men, both evil and good, and uncovering 
the plots and devices of the servants of Sauron. 

Thus he became at last the most hardy of living Men, 
skilled in their crafts and their lore, and was yet more than they; 
for he was elven-wise, and there was a light in his eyes that when 
they were kindled few could endure.” 155 


As Aragorn and his armies arrive at the Black Gates of Mordor for their final 
battle, we see this gift of inner-discernment at work when the Dark Lord’s 
Lieutenant rides forth from Udun, the deep dale of Hell, to relay Sauron’s terms. 
The ‘Mouth of Sauron’ mocks the army that dares to challenge Mordor as nothing 
but an inglorious rabble and insults Aragom as someone less than even a common 
brigand. However, Aragorn stands his ground without raising a finger: 


“Aragorn said naught in answer, but he took the other’s eye 
and held it, and for a moment they strove thus; but soon though 
Aragom did not stir nor move hand to weapon, the other quailed 
and gave back as if menaced with a blow.” 156 


Returning to the new knightly order promised to the Church, Marie-Julie 
was shown that right in her own place of residence at La Lraudais is where the 
Lathers of the Cross will be housed, a great Sanctuary will be built there in honour 
of the Cross and will become a tremendous place of pilgrimage. 157 Marie-Julie was 
shown the exact details of how it would look. It will be a miraculous site with a 
healing spring and will also have houses for widows, orphans and cloisters of nuns. 
The great shrine will also receive miraculous help from Heaven during its 
construction: three times a day the workers will hear the heavenly choirs singing, 
the celestial music will give them relief in their labours. The angels will also help 
build it: workers will put a mark upon the walls only to return from their times of 
rest to discover that the walls will be miraculously taller than the markers. No 
worker will be killed during its construction, there will be no fatal accidents. 
Nobility and the rich will generously donate costly presents to help in its 
construction and adorn the shrine. It appears a great new ‘City of God’ will be 
founded around this great and holy place and will become the capital of the 
Cruciferi. Tolkien once more seems to be inspired or have had an intuitive 
understanding of the prophecies as we find in Lord of the Rings the noble peoples of 
Middle Earth promise to aid Aragorn rebuild his city in a similar fashion. Gimli 
the Dwarf promises on behalf of his people to send the best stone workers to build 
up the houses and roads, while Legolas the Elf notices that they need more 
beautiful living things to bring the heart delight, and promises to send rare singing 
birds and trees that do not die. Their people keep their word as we read: 


155 Lord of the Rings, Appendix A, p. 1097. 

156 Ibid, The Return of the King, p. 923. 

157 We Are Warned, pp. 461-488. 


92 



“In his time (King Aragorn) the City was made more fair 
than it had ever been, even in the days of its first glory; and it was 
filled with trees and with fountains, and its gates were wrought of 
mithril and steel, and its streets were paved with white marble; and 
the Folk of the Mountain laboured in it, and the Folk of the Wood 
rejoiced to come there; and all was healed and made good, and the 
houses filled with men and women and the laughter of children, 
and no window was blind nor any courtyard empty; and after the 
ending of the Third Age of the world into the new age it preserved 
the memory and the glory of the years that were gone.” 158 



Scenes from Apocalypse, English Manuscript (c. 1220). (Top) Christ is honoured by the 
Kings of the earth with St. John as witness. (Bottom) The Wedding Feast of the Lamb with His 
Bride dressed in white. The Great Monarch's kingdom during the Great Peace will be a symbol of 

Christ's Everlasting Kingdom. 

158 Lord of the Rings, The Return ofthe King, p. 1004. 


93 





































King Aragorn proves from the very first days of his reign that he is merciful 
and wise. He pardons all those who had raised the sword against Gondor and 
makes peace with them. He frees the slaves of Mordor and gives them lands to be 
their own and refuses to make slaves of those enemies who surrendered to him, 
sending them back to their homelands as free men. As he is of Numenorean blood, 
his lifespan is longer than those of ordinary men, his reign lasts a glorious 120 
years. Unfortunately, this is one detail with which Tolkien was rather optimistic: 
the reign of the Great Monarch mentioned in the prophesies will last only a quarter 
of Aragorn’s. The Great Monarch will rule approximately thirty-two years 
according to St. Andrew of Salos. Marie-Julie gives an approximation of twenty- 
five to thirty years. 159 

What will happen to the Great Monarch near the end of his reign? The 
prophecies tend to vary. According to many of the early predictions he will die in 
Jerusalem. St. Methodius of Olympus (d. 311 AD) states he will ascend Calvary, 
and taking the crown from his head, will place it on a cross in the exact spot where 
Christ was crucified and will entrust the Christian Kingdom to God the Father 
before his life ends. Since the Cross will be the miraculous sign that will announce 
the coming of the Great Monarch, he will also be granted the grace of directly 
giving up his own spirit, being assumed body and soul into heaven together with 
the cross and the royal crown. 160 Other saints such as St. Augustine of Hippo, St. 
Remy, St. Rabanus, St. Cataldus and St. Anselm of Canterbury state he will die on 
the Mount of Olives. 161 Of interest, Tolkien seems to have known about the 
prophecies concerning the Great Monarch’s death for it seems the Great King will 
be given the grace to hand up his spirit directly to God when his mission on earth is 
over, which is exactly how Aragorn ends his life according to the chronicles 
included in the Appendixes: I am the last of the Numenoreans and the latest 

King of the Elder Days; and to me has been given not only a span thrice that of 
Men of Middle-earth, but also the grace to go at my will, and give back the gift. 
Now, therefore I will sleep.” 162 

What shall happen after the death of the Great Monarch? Sadly, many of 
the prophecies state that the world will not appreciate this Great Period of Peace 
given to it and will take it for granted. The nations will grow lax with the 
fruitfulness of the earth and will fall back into their former errors of gluttony, lust, 
avarice, in fact, all the vices. The faithful will once more be put to the test as the 
last onslaught of the Evil One will begin almost immediately with the appearance of 
the Antichrist who will gather many followers through the preternatural wonders 
he will do through the powers of hell. The Antichrist will seduce many of the 
faithful who will have forgotten the prophecy that Christ will return with his Angels 
from Heaven in glory and will not return via the earth. The Antichrist will also 
convince the Jews he is the Messiah. Some revelations say the Antichrist will 
already appear in the very last days just before the Great Monarch hands his life 
back to God. It is a frightening prospect that after such a time of glory the world 
will be thrown once more into confusion, apostasy and slaughter as the followers of 
the Antichrist will put the faithful and those who oppose him to death in the most 
atrocious ways. However, theologians have stated that the rule of the Antichrist 


159 We Are Warned, p. 386. 

160 Ibid, p.517. 

161 Ibid. pp. 518, 522, 523. 

162 Lord of the Rings, Appendix A, p. 1100. 


94 



will not last long despite the bloodthirsty nature of his reign, his kingdom will last 
for about three to four years before the Final Coming of Christ and the Day of 
Judgement. 

Nevertheless, before the Antichrist there will be much to look forward to 
according to the mystics. It will be the greatest era the world has ever known or 
will know, many miracles will take place that will not be seen again until the End of 
the World. Marie-Julie reveals Heaven declared those who would live to see it and 
take part in the great renewal are indeed a blessed and predestined generation. 
However, only the faithful and righteous may live to see it, for the reign of the 
Great Monarch and the Angelic Pontiff will not come about by any human means 
but by prayer, sacrifice, and accepting Christ as the true King of the Universe of 
whom the Great Monarch and Angelic Pontiff will only be a symbol. Marie-Julie 
was told mankind must accept the Sacred Heart of Christ into their lives if the way 
for the Great Monarch was to be prepared, and that people must pray for his 
coming. We may either live as Christ wishes, repentant and devoted to Him and 
loyal to His Kingdom, or choose the fleeting pleasures of the world, remain blind to 
God’s plan and suffer the consequences. 


“Here is the Sword that was Broken and is forged again! 
Will you aid me or thwart me? Choose swiftly!” 

~ Aragorn, The Two Towers. 



eg ADVENIAT REGNVM TYVM so 


95 


Bibliography 


Bowman, Wayne D. Philosophical Perspectives on Music. New York: Oxford 
University Press, 1998. 


Brentano, Clemens. Schmoger, Carl E. ed. The Life of Jesus Christ and 
Biblical Revelations: From the Visions of the Venerable Anne Catherine Emmerich 
as recorded in the journals of Clemens Brentano. Four Volumes. Illinois: Tan 
Books and Publishers, Inc., 1986. 


Bucchianeri, E.A., 

~ Faust: My Soul be Damned for the World, Vol. 2 Portugal: Batalha 
Publishers, 2010. 

~ Trans., ed. We Are Warned: The Prophecies of Marie-Julie Jahenny. 
December 2011: www.scribd,com/doc/74402052 


Dillon, Rev. Mgr. George. The permanent instruction of the Alta Vendita. 
Dublin: M. H. Gill and Son., Ltd., 1885. Reprint: E-text: 
www.catholicvoice.co.uk/ dillon/text. htm#14 


Eltz, Nicky. Get Us Out of Here!! Medjugorje Web: 2002. 


Goethe, Johann Wolfgang von., 

~ Campaign in France 1792/ Siege of Mainz. Reprint, Saine, Thomas 
P., trans., ed., and Sammons, Jeffrey L., trans. Goethe: The Collected Works, 
Vol. 5. Princeton, New Jersey: Princeton University Press, 1994. 

~ Italian Journey [1786-1788]. Reprint, W.H., Auden and Elizabeth 
Mayer, trans. London: Penguin Classics, 1970. 


Holy Bible, Douay Rheims Version. Rockford, Illinois: Tan Books and Publishers Inc., 
1989. 


Klieger, P. Christian. The Microstates of Europe: Designer Nations in a Post-Modern 
World. United Kingdom: Lexington Books, 2013. 


96 




Kowalska, St. Sr. M. Faustina. Divine Mercy in My Soul: The Diary of the Servant of 
God, Sr. M. Faustina Kowalska. Massachusetts: Marian Press, 1987. 


Malachy, St. Intro. Bander, Peter. The Prophecies of St. Malachy. Rockford: Tan 
Books and Publishers Inc., 1973. 


Millar, Angel. Freemasonry: A History. San Diego: Thunder Bay Press, 2005. 


Spirago, Rev. Francis. The Catechism Explained: An Exhaustive Exposition of the 
Catholic Religion (1899. Reprint: Rockford, Illinois: Tan Books and Publishers, Inc., 


1993. 


Tolkien, J.R.R. The Lord of the Rings: The Fellowship of the Ring, The Two Towers, The 
Return of the King. Great Britain: HarperCollins, 1993. 


Tolkien, Simon. My Grandfather, The Mail on Sunday. February 23, 2003. 

Also: 

http://web.archive.Org/web/20080422072235/http:/www.simontolkien.com/irrto 

1kien.html 


Tolstoy, Leo. War and Peace, Penguin Red Classics. London: Penguin Books, 
2006. 


Waite, Arthur Edward. A New Encyclopaedia of Freemasonry (Ars Magna 
Latomorum), And of Cognate Instituted Mysteries: Their Rites, Literature and History ~ 
Combined Two Volume Edition. New York: Wing Books, 1996. 


97 




Illustrations 


8. Medieval manuscript illumination of King Clovis I Baptised by St. Remi, 
with The Holy Spirit bringing the Sacred Ampulla (1325-1335) by Jacob van Maetant. 
(Public domain) 

8. Artwork from the 15th Century depicting the baptism of Clovis I (upper 
left), and his gift of healing as he touches a subject inflicted with scrofula, (middle). 
(Unknown artist, public domain) 

10. The battle between Clovis I and the Visigoths (Manuscript date c. 1325 
-1335) National Library of the Netherlands. (Public Domain) 

13. Mappa Mundi from the Chronologia Magna (1320) by Paulinus Venetus, 
Creative Commons Licence 1.0. 

29. Royal Standard of Gondor, graphic by 'Kaiser 16', Creative Commons 
Attribution Share Alike 3.0 Unported Licence. (Graphic has been altered for this work 
unknown to the artist.) 

30. “The Tree of Life”, miniature by Pacino di Bonaguida, Florence (1305- 
1310), photo, AA. W., Galleria dell' Accademia, Giunti, Firenze, (1999). (Public 
Domain) 

32. Psalter map (Londoner Psalterkarte): A map of the world, with Jerusalem at 
the centre and the monstrous races on the outermost edge. London BL: Additional 
Ms. 28681 fol-9r detail. Date between 1200 and 1250 A. D. (Public Domain) 

33. World T-O map, 12 th century. From The British Library; Record Number 
- c5933-06; Shelfmark - Royal 12 F. IV; Page Folio Number - f.l35v. (Public 
Domain. (Wikimedia Commons) 


98 



33. Mappa Mundi attributed to Simom Marmion, in La Fleur des Histoires by 
Jean Mansel. Valenciennes, 1459-1463, Bruxelles, Bibliotheque Royale de Belgique, 
MS. 9231, fol. 281v. (Public domain) 

34. Hereford Mappa Mundi, (1300s). Hereford Cathedral. (Public Domain) 


37. Main de Justice, Treasury of St. Denis, (photo attributed to (?) Marie-Lan 
Nguyen. Creative Commons Attribution-Share Alike, 2.0 Generic Licence. 

37. Imperial Holy Spear, photo by Awiok', Creative Commons, 3.0 Unported, 
2.5 Generic, 2.0 Generic, 1.0 Generic. 

37. Imperial Sword of the Holy Roman Empire, photo by 'Url.Unkwill', 
Creative Commons, Unported Licence 3.0. 

38. Charlemagne's sword, Joyeuse. (Louvre), photo by 'Siren-Corn', Creative 
Commons Attributions-Share Alike 3.0 Unported, 2.5 Generic, 2.0 Generic Licences, 

44. “Durin's Bane”, the Balrog of Moria by Markus Roncke (2008), from 
“Flames and Shadows”. Freely listed under the Creative Commons Public Domain 
Dedication. 

48. “The Rider on the White Horse”, early 14 th century manuscript, British 
Library, Creative Commons CC0 1.0 Universal Public Domain Dedication. 

55. Insignia of Lord Sauron, the Red Eye, graphic by 'Rondador', Creative 
Commons Attribution-Share Alike 3.0 Unported licence. 

63. Masonic Steward's Apron, c. 1800s. Photo by, 'Asidemore', Creative 
Commons Attribution-Share Alike 3.0 Unported licence. 


99 



70. Reliquary of the Holy Ampulla at theTau Palace, Rheims, photo by 
'Tangopaso', (2012), public domain listing. 

71. Artistic rendering of the original Holy Ampulla, work by Sergey 
Prokopenko (2012), Creative Commons Attribution-Share Alike 3.0 Unported licence. 

73. Great Seal of the United States, Reverse Side of the Dollar Bill, Photo by, 
'Benutzer:Verwustung'. This work is in the public domain in the United States because 
it is a work prepared by an officer or employee of the United States Government as part 
of that person’s official duties under the terms of Title 17, Chapter 1, Section 105 of the 
US Code. 

93. “Wedding Feast of the Lamb”, Enlish Manuscript, (c. 1220). Trinity 
College, Cambridge. The Yorck Project; 10,000 Meisterwerke der Malerei. DVD- 
ROM, 2002. ISBN 3936122202, DirectMedia Publishing Gmbh, (Public Domain). 


100 




* 

* y -* 


";
    }
}
