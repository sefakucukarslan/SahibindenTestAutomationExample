Feature: DetailSearchPage

Sahibinden Detail Search Page Tests

@tag1
Scenario: DetailPageOpeningControl
	* Main page open
	* Click detail search button
	* Is visible 'Detaylı Arama' text
	* Is category selected all
	* Is visible all category elements
	* Is city dropdown enable
	* Is district dropdown disable
	* Is visible Advert date All
	* Is visible Search word
	* Is Sort by dropdown enable 
	* Is visible 'Arama Yap' button
	
@tag1
Scenario: DetailSearchControl
	* Main page open
	* Click detail search button
	* The first section of the category is 'Vasıta'
	* The second section of the category is 'Otomobil'
	* The third section of the category is 'Audi'
	* Fourth part of the category is 'Tümü' selected
	* Click to city
	* City search bar write 'Sakarya'
	* Choose 'Sakarya' section
	* Close city search bar
	* Is true search city 'Sakarya'
	* Click to District
	* District search bar write 'Adapazarı'
	* Choose 'Adapazarı' section
	* Close district search bar
	* Is true search city 'Adapazarı'
	* Click Search Button

