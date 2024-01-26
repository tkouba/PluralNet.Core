<img src="https://raw.githubusercontent.com/tkouba/PluralNet.Core/master/Icon.png" height="80" />

# Foreword

Rewrited library [PluralNet](https://github.com/rudyhuyn/PluralNet). Original library is now deprecated, 
all features from PluralNet are now part of a more advanced toolset created/managed by the same team, 
named [ReswPlus](https://github.com/dotnetplus/reswplus), but there are dependencies on WinRT. This library 
rewritten has core functions for RESX files pluralize from code.


# PluralNet.Core - Pluralization for Resx files

__PluralNet.Core__ adds support of pluralization and plural forms to your application. Very easy to use 
and compatible with RESX files. There are no dependecies on any special environment such as WinRT, WPF, 
Xamarin, MAUI or other.

## Support plural forms in your resource files

Instead of one entry in your resource files, you must create one entry for each plural forms used by the language 
(One, Other, Few?, Many?, Zero?, Two?), used the ``_`` symbol to separate the resource name to the plural form id

Example:

English:
* __TimeStampDay_One__     {0} day
* __TimeStampDay_Other__   {0} days

Polish (4 plural forms)
* __TimestampMonth_One__	{0} miesiąc temu
* __TimestampMonth_Few__	{0} miesiące temu
* __TimestampMonth_Many__	{0} miesięcy temu
* __TimestampMonth_Other__	{0} miesiąca temu

Plural form suffix should follow the [Plural Rules](https://cldr.unicode.org/index/cldr-spec/plural-rules)

* __zero__
* __one__ - singular
* __two__ - dual
* __few__ - paucal
* __many__ - also used for fractions if they have a separate class
* __other__ - required—general plural form—also used if the language only has a single form

## Manage plural forms code-behind

Instead of 

```csharp
AppResources.TimeStampDay;
```
use:

```csharp
AppResources.ResourceManager.GetPlural("TimeStampDay", <NUMBER>);
```

You can then use string.Format(...) if your string supports formatting.

## XAML

Not supported yet. Probably will be in separated assemblies.

## Platforms

The library supports:
* NetStandard 2.0

## Language supported

Afrikaans, Akan, Albanian, Amharic, Arabic, Armenian, Assamese, Asturian, Asu, Azerbaijani, Bambara, Basque, 
Belarusian, Bemba, Bena, Bengali, Bihari, Bodo, Bosnian, Breton, Bulgarian, Burmese, Catalan, Central Atlas Tamazight, 
Central Kurdish, Chechen, Cherokee, Chiga, Chinese, Colognian, Cornish, Croatian, Czech, Danish, Divehi, Dutch, 
Dzongkha, English, Esperanto, Estonian, European Portuguese, Ewe, Faroese, Filipino, Finnish, French, Friulian, 
Fulah, Galician, Ganda, Georgian, German, Greek, Gujarati, Gun, Hausa, Hawaiian, Hebrew, Hindi, Hungarian, Icelandic, 
Igbo, Inari Sami, Indonesian, Inuktitut, Irish, Italian, Japanese, Javanese, Jju, Kabuverdianu, Kabyle, Kako, 
Kalaallisut, Kannada, Kashmiri, Kazakh, Khmer, Korean, Koyraboro Senni, Kurdish, Kyrgyz, Lakota, Langi, Lao, Latvian, 
Lingala, Lithuanian, Lojban, Lower Sorbian, Lule Sami, Luxembourgish, Macedonian, Machame, Makonde, Malagasy, Malay, 
Malayalam, Maltese, Manx, Marathi, Masai, Metaʼ, Moldavian, Mongolian, Nahuatl, Nama, Nepali, Ngiemboon, Ngomba, 
North Ndebele, Northern Sami, Northern Sotho, Norwegian, Norwegian Bokmål, Norwegian Nynorsk, Nyanja, Nyankole, 
N’Ko, Oriya, Oromo, Ossetic, Papiamento, Pashto, Persian, Polish, Portuguese, Prussian, Punjabi, Romanian, Romansh, 
Rombo, Root, Russian, Rwa, Saho, Sakha, Samburu, Sami languages [Other], Sango, Scottish Gaelic, Sena, Serbian, 
Serbo-Croatian, Shambala, Shona, Sichuan Yi, Sinhala, Skolt Sami, Slovak, Slovenian, Soga, Somali, South Ndebele, 
Southern Kurdish, Southern Sami, Southern Sotho, Spanish, Swahili, Swati, Swedish, Swiss German, Syriac, Tachelhit, 
Tagalog, Tamil, Telugu, Teso, Thai, Tibetan, Tigre, Tigrinya, Tongan, Tsonga, Tswana, Turkish, Turkmen, Tyap, Ukrainian, 
Upper Sorbian, Urdu, Uyghur, Uzbek, Venda, Vietnamese, Volapük, Vunjo, Walloon, Walser, Welsh, Western Frisian, Wolof, 
Xhosa, Yiddish, Yoruba, Zulu

## Future plans

 - [ ] Add some examples
 - [ ] Add support for XAML
 - [ ] Determine how to add support for `IStringLocalizer` interface

# FAQ

## I already use [Humanizer](https://github.com/Humanizr/Humanizer) - what are the advantages of PluralNet?

The purpose of these 2 libraries are very different.

Humanizer is a library to do operations on strings, one of the operation is to pluralize a word : "man".Pluralize().

To cut a long story short, Humanizer does:

* verify if the word is "man" "woman" "child", etc... and use the correct plural
* verify the ending of the word: potato => potatoES
* verify if the word is uncountable
* else add a S
It only supports english, no sentences and is not related numbers.

PluralNet is totally different, it's a tool for localizations (select the correct resource depends of the number), 
if you want to display:

* you have removed XX item(s), you can restore this file(s) using this link.

You can create 2 resources:

* you have removed 1 item, you can restore this file using this link.
* you have removed {0} items, you can restore these files, using this link.

PluralNet will select the correct string depends of the number and will support all languages.

For example

* 0 is singular in french
* 9999.999991 is singular for some languages cause ending with a 1

Polish has 4 different plural forms
etc...

You can see all [language plural rules](https://www.unicode.org/cldr/charts/44/supplemental/language_plural_rules.html).

# How to help?

If you detect an issue, want to add a language or some language provider tests, 
don't hesitate to submit a pull request!

 
