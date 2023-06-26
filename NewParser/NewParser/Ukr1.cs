using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewParser
{
    public static class Ukr1
    {
		public static string html1 = """
			 <body id="body" class="ukrainian">
			
			
			 
			<!--noindex-->
			<!--bannertop-->
			<script type="text/javascript">
			function doBranding(br) {
					if( $(window).width() < 961 && $(window).width() > 100 ){
						document.getElementById('main-content').style.width="100%";
						document.getElementById('main-content').style.position="relative";
						document.getElementById('header').style.width=$(window).width()+"px";
						document.getElementById('header').style.position="sticky";
						document.getElementById('footer').style.width=$(window).width()+"px";
						document.getElementById('footer').style.position="sticky";
					}
					if(br){
						document.body.style.backgroundPosition = '50% 0%';
						document.body.style.backgroundRepeat= 'no-repeat';
			
						if(br.iu)document.body.style.backgroundImage = 'url('+br.iu+')';   //  br.iu - ссылка на картинку
						if(br.bg_color)document.body.style.backgroundColor = br.bg_color;    // Цвет фона
						if(br.top_margin)document.body.style.paddingTop = br.top_margin;    // Расстояние сверху до контента сайта
						if(br.top_position)document.body.style.backgroundAttachment = br.top_position;
			
						if(br.cu){
							document.body.style.cursor="pointer";
							document.body.setAttribute("onclick", "onlyBodyClick(event||window.event)");
							window.onlyBodyClick = function (e){
								var t = e.target||e.srcElement;
								if (t == document.body){ window.open(br.cu,'_blank'); }
							};
							document.addEventListener('touchstart', function(event) {
								var touch = event.touches[0];
								var t = event.target||event.srcElement;
								if(t == document.body) window.open(br.cu,'_blank');
							}, false);
						}
			
						if(document.getElementById('main-content') && $(window).width() > 960){
							document.getElementById('main-content').style.width="100%";
							document.getElementById('main-content').style.left="50%";
							document.getElementById('main-content').style.marginLeft="-490px";
							document.getElementById('main-content').style.position="relative";
							document.getElementById('main-content').style.cursor="default";
							document.getElementById('main-content').style.backgroundColor="white";
						}
						if(document.getElementById('header') && $(window).width() > 960){
							document.getElementById('header').style.width="980px";
							document.getElementById('header').style.backgroundColor="white";
							document.getElementById('header').style.cursor="default";
							document.getElementById('header').style.position="sticky";
						}
						if(document.getElementById('footer') && $(window).width() > 960){
							document.getElementById('footer').style.width="980px";
							document.getElementById('footer').style.cursor="default";
							document.getElementById('footer').style.backgroundColor="white";
							document.getElementById('footer').style.left="50%";
							document.getElementById('footer').style.position="sticky";
							//document.getElementById('footer').style.marginLeft="452px";
						}
						if(document.getElementById('body')){
							document.getElementById('body').style.backgroundColor='white';
						}
			      }
			  }
			</script> 
			<div id="admixer_8a539a0829134fd9807e076bdffb13e4_zone_3405_sect_226_site_226"></div>
			<script type="text/javascript">
			admixerML.fn.push(function () { admixerML.display('admixer_8a539a0829134fd9807e076bdffb13e4_zone_3405_sect_226_site_226'); });
			</script>   
			 
			<!--bannertop-->
			<!--/noindex-->
			
			
			<!-- Google Tag Manager (noscript) -->
			<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-TDTR4NM"
			height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
			<!-- End Google Tag Manager (noscript) -->
			<div id="fb-root" class=" fb_reset"><div style="position: absolute; top: -10000px; width: 0px; height: 0px;"><div></div></div></div>
			<script>(function(d, s, id) {
			  var js, fjs = d.getElementsByTagName(s)[0];
			  if (d.getElementById(id)) return;
			  js = d.createElement(s); js.id = id;
			  js.src = "//connect.facebook.net/uk_UA/sdk.js#xfbml=1&version=v2.9&appId=178406328912732";
			  fjs.parentNode.insertBefore(js, fjs);
			}(document, 'script', 'facebook-jssdk'));</script>
			
			
				<div class="container">
					<div id="header" class="header">
						<div class="menu-block">
			                <div id="toggler"></div>
			                <div class="authorization-block">
			                    <span class="login nouser"><a href="/users/?do=login" onclick="return false;" title="Вхід">Вхід</a></span>
			                    <span class="profil isuser"><a href="/users/?do=profile" class="username">Профіль</a></span>
			                    <span class="separator"> / </span>
								<span class="logout isuser"><a href="/users/?do=logout" onclick="logout();return false;" title="Вхід">Вихід</a></span>
								<span class="register nouser"><a href="/users/?do=register">Реєстрація</a></span>
			                </div>
							<ul class="main-menu">
								<li><a href="/" class="active" title="ЗНО-онлайн">ЗНО-онлайн</a></li>
								<li><a href="https://osvita.ua/" title="ОСВІТА.UA">ОСВІТА.UA</a></li>
								<li><a href="https://osvita.ua/consultations/" title="Все про вступ на ОСВІТА.UA">Все про вступ</a></li>
								<li><a href="https://osvita.ua/test/" title="Все про ЗНО на ОСВІТА.UA">Все про ЗНО</a></li>
								<li><a href="https://vstup.osvita.ua/" title="Вступ.ОСВІТА.UA">Вступ.ОСВІТА.UA</a></li>
								<li><a href="https://osvita.ua/vnz/rating/" title="Рейтинги ВНЗ на ОСВІТА.UA">Рейтинги ВНЗ</a></li>
							</ul>
						</div>
						
			<!-- news - menu - 1967 -->
					<div class="title-block no-bottom-line">
						<a href="https://zno.osvita.ua" title="ЗНО-ОНЛАЙН"><span class="linkh1">ЗНО-ОНЛАЙН</span></a>
									<div class="description"><h1 class="desc">Завдання за темою з української мови та літератури</h1></div>
								</div>
			<div id="breadcrumbs" class="breadcrumbs" vocab="http://schema.org/" typeof="BreadcrumbList">
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="1">
			<a property="item" typeof="WebPage" href="https://zno.osvita.ua"><span property="name">Тести ЗНО онлайн</span></a></span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="2">
			<a href="https://zno.osvita.ua/ukrainian/tema.html" property="item" typeof="WebPage"><span property="name">Українська мова і література</span></a>
			</span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="3">
			<a href="https://zno.osvita.ua/ukrainian/tag-analiz_tekstu_vysha_osvita/" property="item" typeof="WebPage">
			<meta property="name" content="Склад. Наголос – тести ЗНО/НМТ – завдання з української мови">
			</a>
			<span>Склад. Наголос – тести ЗНО/НМТ – завдання з української мови</span>
			</span>
			<!-- tag --></div>
			
			<!-- curpath = /ukrainian/tag-analiz_tekstu_vysha_osvita/ -->
			
			<!-- menu 0.00381 c. -->
			
			
					</div>
				</div>
				
				<div class="container">
			        <div id="main-content">
			            <div class="col-main">
						
			<!-- znotest - zno_quest_list_by_tag_all - 1968 -->
			<!-- setTitle #### -->
			
			
			<style type="text/css">
			.test-title .label{color: #35866e; font-size:inherit; font-weight:normal;}
			</style>
			
			<script type="text/javascript">
			
			var qfirst = 1;
			var list = 0;
			var cnt = 37;
			var total = 37;
			var test_id = 'tag_27';
			var tag_id = 27;
			var quest_id = 1;
			var section = 3;
			var maxball = 37;
			var tpage = 'tag';
			var freetemp = 1;
			
			
			$(document).ready(function (){ 
				$('.tasks-numbers').on('click','.number', function(){ nextQuest(parseInt($(this).html())); });
				$('.two-buttons-container').on('click','.q-skip', function(){ nextQuest(); });
				$('.two-buttons-container').on('click','.q-next', function(){ saveResult(); });
				$('.select-answers-variants').on('click','.marker', function(){ showButNxt($(this)); });
				$('.q-test').on('click','.inptext', function(){ showButNxt($(this)); });
				$('.answer').on('click','.inptext', function(){ showButNxt($(this)); });
				$('.two-buttons-container').on('click','.q-final', function(){
					if( $(this).hasClass("q-savetemp") ){
						if (!checkUser()) {
							var refpath = getCurPath();
							var data = getSessionStorageItems();
							setCookie('temp'+test_id, data.length, {path:refpath[2], expires: 7*86400});
							saveStorageItems('test'+test_id, resultsToAnswers(data));
							alert("Ви не є зареєстрованим/авторизованим користувачем, але \nвідповіді збережено для продовження наступного разу!");
							return ;
						}else{
							window.savetemp = test_id;
							if (!isPrem()){
								var refpath = getCurPath();
								var data = getSessionStorageItems();
								setCookie('temp'+test_id, data.length, {path:refpath[2], expires: 7*86400});
								saveStorageItems('test'+test_id, resultsToAnswers(data));
								alert("Відповіді збережено для продовження наступного разу!");
								return ; 
							}
						}
					}
					endResult(); 
				});
				if(isPrem()){$.get('/users/checkpr.php',function(data){if(data&&(!data.ok||data.err)){if(data.delpr){setCookie('nopr',1,{'path':'/'});deleteCookie('premium');deleteCookie('order');}}});}
				var prz = getCookie('t'+test_id);
				if( prz && prz < total - 3 && prz > 2){
					$('#waiting2').html('Минулого разу останнім було завдання № '+getCookie('t'+test_id)+'.').show();
				}
				clearSessionStorageItem();
				if (checkUser()) {
					if( location.hash ){
						var res = location.hash.match(/tmp_id/);	
					}
					if( location.hash && res){
						console.log('location.hash: '+location.hash);
						getTempResult(location.hash);
					}else if( getCookie('tmp'+test_id) ){
						console.log('tmp'+test_id);
						getTempResult(test_id);
					}else if ( getCookie('temp'+test_id) ){
						console.log('temp'+test_id);
						var refpath = getCurPath();
						setCookie('temp'+test_id, 0, {path:refpath[2], expires: -86400});
						var data = getStorageItems('test'+test_id);
						clearStorageItems('test'+test_id);
						resultTempExit(data);
					}else{
						var prs = getStorageItems('section_temp_tag_pr_'+section);
						console.log('temp_tag_'+tag_id+'='+prs[tag_id]);
						if(prs[tag_id]){
							getTempResult(tag_id);
						}
					}
				}else{
					if ( getCookie('temp'+test_id) ){
						var refpath = getCurPath();
						setCookie('temp'+test_id, 0, {path:refpath[2], expires: -86400});
						var data = getStorageItems('test'+test_id);
						clearStorageItems('test'+test_id);
						resultTempExit(data);
						if (data){
							setCookie('t'+test_id, 0, {path:refpath[2], expires: -86400});
							$('#waiting2').html('Минулого разу було збережено відповіді, тому можете продовжити.').show();
						}
					}
				}
				progressBar();
			});
			
			
			
			
			Array.prototype.associate = function (keys) {
				var result = {};
				this.forEach(function (el, i) {
					result[keys[i]] = el;
				});
				return result;
			};
			
			function resultsToAnswers(data){
				var qid = [], ans = [];
				for(var i in data){
					qid.push(data[i]['q']['id']);
					ans.push(data[i]['a']);
				}
				console.log(ans.associate(qid));
				return ans.associate(qid);
			}
			
			function getTempResult(tmp_id){
				if(!tmp_id){ return;}
				window.mysend['do'] = 'get_savetemp';
				window.mysend['section'] = section;
				window.mysend['tmp_id'] = tmp_id;
				if(typeof window.tag_id !== "undefined"){ 
					var action_url = '/users/znotest/tag/';
					window.mysend['tag_id'] = tag_id;
				}else{
					var action_url = '/users/znotest/';
					window.mysend['znotest'] = test_id;
				}
				console.log(action_url);
				$.ajax({
					url: action_url,
					type: "POST",
			        data: window.mysend,
			        'timeout': 20000,
					dataType: 'json', 
					success: function(data){
						if( data.ok && data.ok=='ok' ){
							resultTempExit(data.answers);
							//var refpath = getCurPath();
							//setCookie('tmp'+test_id, 0, {path:refpath[2], expires: -86400});
							$('.err_msg').remove();
						}else{
							if( data.error ){
								console.log('Помилка 1, немає збереженого результату. Error: ' + data.error);
								//$('#wrap').before('<p>Помилка 1, немає збереженого результату... ' + data.error + '</p>' );
							}else{
								console.log('Помилка 2, немає збереженого результату.');
								//$('#wrap').before('<p>Помилка 2, немає збереженого результату...</p>');
							}
						}
					},
					error: function(jqXHR, textStatus, errorThrown){
						$('#wrap').before('<p class="err_msg">'+res+'</p>' );	
						$('#waiting').hide();
					},
				});	
			}
			
			function resultTempExit(data){
				$('.tasks-numbers').show();
				$('#waiting').hide();
				if(data){
					$('.number.q1').removeClass('current');
					//console.log(data);
					var isres = false;
					for(var i in data){
						var id = $('.card_'+i).attr('id');
						isres = false;
						console.log(id+': '+i+': '+data[i]);
						$('.task-card').hide();
						$('#'+id ).show();
						var items = $('.card_'+i).find(".q-radio");
						if(items.length){
							items.each( function() {
								if((data[i]).match(/;/)){
									var patt = new RegExp($(this).val());
									if( patt.test(data[i]) ){
										$(this).prop("checked", true);
										isres = true;
									}
								}else{
									if( $(this).val() == data[i] ){
										$(this).prop("checked", true);
										isres = true;
									}
								}
							});
						}else{
							items = $('.card_'+i).find(".inptext");
							var res = []; 
							var j = 0;
							if((data[i]).match(/;/)){ res = (data[i]).split(";"); }
							if(items.length){
								items.each( function() {
									console.log(j+': '+res[j]);
									if(res){
										if(res.length > 1){
											$(this).val(res[j]);
										}else{
											$(this).val(data[i]);
										}
										isres = true;
									}else{
										$('.number.'+id).addClass('good');
									}
									j++;
								});
							}else{
								$('.number.'+id).addClass('good');
							}				
						}
						if(isres){
							window.quest_id = parseInt(id.replace("q", ""));
							saveResult();
						}
					}
					nextQuest(window.quest_id-1);
				}
				window.scrollTo(0, $('#tasks-numbers').offset().top - 20);
			}
			</script>
			
			
			<div class="q-progress-bar"><div class="q-progress" style="width: 2%;"></div></div>
			<div title="Приховати таймер" class="q-timer"><span class="q-timer-txt"></span></div>
			
			<div class="test-title">
			<!-- 1 - 0 - Українська мова і література -->
			<span class="label">Предмет:</span>&nbsp;<span class="row">УКРАЇНСЬКА МОВА</span><br><!-- 2 - 1 - УКРАЇНСЬКА МОВА -->
			<span class="label">Розділ:</span>&nbsp;<span class="row">Фонетика. Графіка. Орфоепія</span><br><!-- 3 - 23 - Фонетика. Графіка. Орфоепія -->
			<span class="label">Тема:</span>&nbsp;<span class="row">Склад. Наголос</span><br><!-- 4 - 24 - Склад. Наголос -->
			<span class="label">Кількість завдань:</span>&nbsp;<span class="row">37</span> <!-- 37 -->
			</div>
			
			<div class="tasks-numbers" id="tasks-numbers"><span class="q1 number  current">1</span><span class="q2 number ">2</span><span class="q3 number ">3</span><span class="q4 number ">4</span><span class="q5 number ">5</span><span class="q6 number ">6</span><span class="q7 number ">7</span><span class="q8 number ">8</span><span class="q9 number ">9</span><span class="q10 number ">10</span><span class="q11 number ">11</span><span class="q12 number ">12</span><span class="q13 number ">13</span><span class="q14 number ">14</span><span class="q15 number ">15</span><span class="q16 number ">16</span><span class="q17 number ">17</span><span class="q18 number ">18</span><span class="q19 number ">19</span><span class="q20 number ">20</span><span class="q21 number ">21</span><span class="q22 number ">22</span><span class="q23 number ">23</span><span class="q24 number ">24</span><span class="q25 number ">25</span><span class="q26 number ">26</span><span class="q27 number ">27</span><span class="q28 number ">28</span><span class="q29 number ">29</span><span class="q30 number ">30</span><span class="q31 number ">31</span><span class="q32 number ">32</span><span class="q33 number ">33</span><span class="q34 number ">34</span><span class="q35 number ">35</span><span class="q36 number ">36</span><span class="q37 number bad">37</span><span class="num_all" onclick="questExp(); return false;">&nbsp;Всі&nbsp;завдання&nbsp;</span></div>
			
			<div id="waiting" style="display: none;"><center>Зачекайте, йде розрахунок...<br><div id="wait"> </div></center></div>
			<div id="waiting2" style="display:none;"></div>
			
			<div id="wrap">
					
			<!-- 
			сохраню если отвечал дольше 5с.
			сохраню если ответов больше 5%
			все старые записи по тегу удалю.
			 -->
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
			
					<div class="test-bal">Максимальна кількість балів: <strong>37</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
						
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
			<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/ukrainian/tema.html">до списку тем</a>.</small></em></div>
				</div>
				<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/tag-sklad_nagolos/?1673691138">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			
			<!-- abc=0 -->
			<div id="q1" class="task-card current" style="display: inline-block;">
			<div class="counter">Завдання 1</div>
			<div class="question"><p>Правильно підкреслено літеру на позначення наголошеного звука в слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>ол<b><u>е</u></b>нь</div><div class="answer"><span class="marker">Б</span>к<b><u>о</u></b>лесо</div><div class="answer"><span class="marker">В</span>ч<b><u>и</u></b>тання</div><div class="answer"><span class="marker">Г</span>вип<b><u>а</u></b>док</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7" onclick="showComment(7)">Читати коментар</span>
					<div id="commentar_7" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>Олень (а не олЕнь), читАння (а не чИтання), вИпадок (а не випАдок). </em>Наголошений звук у слові <em>кОлесо </em>визначений правильно.</p>
			
			<p><strong>Відповідь – Б.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q2" class="task-card" style="display: none;">
			<div class="counter">Завдання 2</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>черговий</div><div class="answer"><span class="marker">Б</span>псевдонім</div><div class="answer"><span class="marker">В</span>ознака</div><div class="answer"><span class="marker">Г</span>осока</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_65" onclick="showComment(65)">Читати коментар</span>
					<div id="commentar_65" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><b>ТЕМА: </b><strong>Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>черговИй, псевдонІм, ознАка, осокА.</em></p>
			
			<p><strong>Відповідь – В.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q3" class="task-card" style="display: none;">
			<div class="counter">Завдання 3</div>
			<div class="question"><p>На третій склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>кропива</div><div class="answer"><span class="marker">Б</span>периметр</div><div class="answer"><span class="marker">В</span>підошва</div><div class="answer"><span class="marker">Г</span>однаковий</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_186" onclick="showComment(186)">Читати коментар</span>
					<div id="commentar_186" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>кропивА, перИметр, підОшва, однАковий.</em></p>
			
			<p><strong>Відповідь – А.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q4" class="task-card" style="display: none;">
			<div class="counter">Завдання 4</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>однаковий</div><div class="answer"><span class="marker">Б</span>добовий</div><div class="answer"><span class="marker">В</span>щовесни</div><div class="answer"><span class="marker">Г</span>сантиметр</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_250" onclick="showComment(250)">Читати коментар</span>
					<div id="commentar_250" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>однАковий, добовИй, щовеснИ, сантимЕтр.</em></p>
			
			<p><strong>Відповідь: А.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q5" class="task-card" style="display: none;">
			<div class="counter">Завдання 5</div>
			<div class="question"><p>На перший склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>жалюзі</div><div class="answer"><span class="marker">Б</span>чіткий</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>деякий</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_310" onclick="showComment(310)">Читати коментар</span>
					<div id="commentar_310" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>жалюзІ, чіткИй, перЕпис, дЕякий.</em></p>
			
			<p><strong>Відповідь: Г.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q6" class="task-card" style="display: none;">
			<div class="counter">Завдання 6</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>одинадцять</div><div class="answer"><span class="marker">Б</span>черговий</div><div class="answer"><span class="marker">В</span>цемент</div><div class="answer"><span class="marker">Г</span>кидати</div><div class="answer"><span class="marker">Д</span>поки</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_377" onclick="showComment(377)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_377" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q7" class="task-card" style="display: none;">
			<div class="counter">Завдання 7</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>кропива</div><div class="answer"><span class="marker">Б</span>псевдонім</div><div class="answer"><span class="marker">В</span>запитання</div><div class="answer"><span class="marker">Г</span>ознака</div><div class="answer"><span class="marker">Д</span>осока</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_458" onclick="showComment(458)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_458" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q8" class="task-card" style="display: none;">
			<div class="counter">Завдання 8</div>
			<div class="question"><p>На перший склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>ожеледь</div><div class="answer"><span class="marker">Б</span>деінде</div><div class="answer"><span class="marker">В</span>перекис</div><div class="answer"><span class="marker">Г</span>експерт</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_754" onclick="showComment(754)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_754" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q9" class="task-card" style="display: none;">
			<div class="counter">Завдання 9</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>листопад</div><div class="answer"><span class="marker">Б</span>новина</div><div class="answer"><span class="marker">В</span>столяр</div><div class="answer"><span class="marker">Г</span>літопис</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1391" onclick="showComment(1391)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1391" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q10" class="task-card" style="display: none;">
			<div class="counter">Завдання 10</div>
			<div class="question"><p>Перший склад наголошений у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>розвал</div><div class="answer"><span class="marker">Б</span>тонкий</div><div class="answer"><span class="marker">В</span>разом</div><div class="answer"><span class="marker">Г</span>люблю</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6421" onclick="showComment(6421)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6421" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q11" class="task-card" style="display: none;">
			<div class="counter">Завдання 11</div>
			<div class="question"><p>Другий склад наголошений у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>приятель</div><div class="answer"><span class="marker">Б</span>недруг</div><div class="answer"><span class="marker">В</span>відгомін</div><div class="answer"><span class="marker">Г</span>обранець</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6480" onclick="showComment(6480)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6480" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q12" class="task-card" style="display: none;">
			<div class="counter">Завдання 12</div>
			<div class="question"><p>Другий склад наголошений у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>запитання</div><div class="answer"><span class="marker">Б</span>сантиметр</div><div class="answer"><span class="marker">В</span>одинадцять</div><div class="answer"><span class="marker">Г</span>завдання</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6545" onclick="showComment(6545)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6545" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q13" class="task-card" style="display: none;">
			<div class="counter">Завдання 13</div>
			<div class="question"><p>На перший склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>жалюзі</div><div class="answer"><span class="marker">Б</span>чіткий</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>випадок</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6906" onclick="showComment(6906)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6906" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q14" class="task-card" style="display: none;">
			<div class="counter">Завдання 14</div>
			<div class="question"><p>Перший склад наголошений у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>дрова</div><div class="answer"><span class="marker">Б</span>жалюзі</div><div class="answer"><span class="marker">В</span>жаркий</div><div class="answer"><span class="marker">Г</span>дочка</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7093" onclick="showComment(7093)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7093" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q15" class="task-card" style="display: none;">
			<div class="counter">Завдання 15</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>котрий</div><div class="answer"><span class="marker">Б</span>кілометр</div><div class="answer"><span class="marker">В</span>одинадцять</div><div class="answer"><span class="marker">Г</span>привезти</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7717" onclick="showComment(7717)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7717" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q16" class="task-card" style="display: none;">
			<div class="counter">Завдання 16</div>
			<div class="question">Другий склад наголошений у слові</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>обранець</div><div class="answer"><span class="marker">Б</span>недруг</div><div class="answer"><span class="marker">В</span>відгомін</div><div class="answer"><span class="marker">Г</span>приятель</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_8257" onclick="showComment(8257)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_8257" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q17" class="task-card" style="display: none;">
			<div class="counter">Завдання 17</div>
			<div class="question"><p>Правильно підкреслено літеру на позначення наголошеного звука в слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>дочк<strong><span style="text-decoration: underline;">а</span></strong></div><div class="answer"><span class="marker">Б</span>завданн<strong><span style="text-decoration: underline;">я</span></strong></div><div class="answer"><span class="marker">В</span>н<strong><span style="text-decoration: underline;">о</span></strong>вий</div><div class="answer"><span class="marker">Г</span>р<strong><span style="text-decoration: underline;">о</span></strong>блю</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_8616" onclick="showComment(8616)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_8616" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q18" class="task-card" style="display: none;">
			<div class="counter">Завдання 18</div>
			<div class="question"><p>Позначте рядок, у якому в усіх словах наголошений другий склад:</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>дочка, подруга, вимова, гуртожиток, русло</div><div class="answer"><span class="marker">Б</span>новий, спина, виразно, завдання, попереду</div><div class="answer"><span class="marker">В</span>предмет, рукопис, ненавидіти, фартух, в’язкий</div><div class="answer"><span class="marker">Г</span>середина, дефіс, старий, горошина, каталог</div><div class="answer"><span class="marker">Д</span>легкий, олень, несла, добуток, партер</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_8737" onclick="showComment(8737)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_8737" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q19" class="task-card" style="display: none;">
			<div class="counter">Завдання 19</div>
			<div class="question"><p>На другий склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>однаковий</div><div class="answer"><span class="marker">Б</span>добовий</div><div class="answer"><span class="marker">В</span>щовесни</div><div class="answer"><span class="marker">Г</span>сантиметр</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9992" onclick="showComment(9992)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9992" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q20" class="task-card" style="display: none;">
			<div class="counter">Завдання 20</div>
			<div class="question"><p>На другий склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>центнер</div><div class="answer"><span class="marker">Б</span>селянин</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>листопад</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10160" onclick="showComment(10160)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10160" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q21" class="task-card" style="display: none;">
			<div class="counter">Завдання 21</div>
			<div class="question">На перший склад падає наголос у слові </div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>цінник </div><div class="answer"><span class="marker">Б</span>течія </div><div class="answer"><span class="marker">В</span>русло</div><div class="answer"><span class="marker">Г</span>випадок</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_11673" onclick="showComment(11673)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_11673" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q22" class="task-card" style="display: none;">
			<div class="counter">Завдання 22</div>
			<div class="question">На третій склад падає наголос у слові</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>каталог </div><div class="answer"><span class="marker">Б</span>завдання </div><div class="answer"><span class="marker">В</span>феномен  </div><div class="answer"><span class="marker">Г</span>камбала</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12405" onclick="showComment(12405)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12405" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q23" class="task-card" style="display: none;">
			<div class="counter">Завдання 23</div>
			<div class="question"><p>На перший склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>щавель </div><div class="answer"><span class="marker">Б</span>злегка </div><div class="answer"><span class="marker">В</span>жаркий </div><div class="answer"><span class="marker">Г</span>звести</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_13725" onclick="showComment(13725)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_13725" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q24" class="task-card" style="display: none;">
			<div class="counter">Завдання 24</div>
			<div class="question">На другий склад падає наголос у слові</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>позначка </div><div class="answer"><span class="marker">Б</span>центнер </div><div class="answer"><span class="marker">В</span>довідник </div><div class="answer"><span class="marker">Г</span>каталог</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14633" onclick="showComment(14633)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14633" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q25" class="task-card" style="display: none;">
			<div class="counter">Завдання 25</div>
			<div class="question">На другий склад падає наголос у слові</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>читання </div><div class="answer"><span class="marker">Б</span>солодощі </div><div class="answer"><span class="marker">В</span>обіцянка </div><div class="answer"><span class="marker">Г</span>донька</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_15181" onclick="showComment(15181)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_15181" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q26" class="task-card" style="display: none;">
			<div class="counter">Завдання 26</div>
			<div class="question"><p>На другий склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>начинка </div><div class="answer"><span class="marker">Б</span>позначка </div><div class="answer"><span class="marker">В</span>травестія </div><div class="answer"><span class="marker">Г</span>рівнина</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_16483" onclick="showComment(16483)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_16483" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q27" class="task-card" style="display: none;">
			<div class="counter">Завдання 27</div>
			<div class="question"><p>На перший склад падає наголос у всіх словах, ОКРІМ</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>причіп </div><div class="answer"><span class="marker">Б</span>косий </div><div class="answer"><span class="marker">В</span>жалюзі</div><div class="answer"><span class="marker">Г</span>випадок</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17094" onclick="showComment(17094)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17094" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q28" class="task-card" style="display: none;">
			<div class="counter">Завдання 28</div>
			<div class="question"><p>На перший склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>віршовий </div><div class="answer"><span class="marker">Б</span>підлітковий </div><div class="answer"><span class="marker">В</span>корисний </div><div class="answer"><span class="marker">Г</span>фаховий</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17936" onclick="showComment(17936)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17936" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q29" class="task-card" style="display: none;">
			<div class="counter">Завдання 29</div>
			<div class="question"><p>На другий склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>бешкет</div><div class="answer"><span class="marker">Б</span>вимога </div><div class="answer"><span class="marker">В</span>колесо </div><div class="answer"><span class="marker">Г</span>донька</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_19309" onclick="showComment(19309)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_19309" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q30" class="task-card" style="display: none;">
			<div class="counter">Завдання 30</div>
			<div class="question">На перший склад падає наголос у слові</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>текстовий </div><div class="answer"><span class="marker">Б</span>зручний </div><div class="answer"><span class="marker">В</span>визвольний </div><div class="answer"><span class="marker">Г</span>фаховий</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_19985" onclick="showComment(19985)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_19985" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q31" class="task-card" style="display: none;">
			<div class="counter">Завдання 31</div>
			<div class="question"><p>На другий склад падає наголос у слові</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>листопад </div><div class="answer"><span class="marker">Б</span>поняття </div><div class="answer"><span class="marker">В</span>вантажівка </div><div class="answer"><span class="marker">Г</span>горошина</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_21247" onclick="showComment(21247)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_21247" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q32" class="task-card" style="display: none;">
			<div class="counter">Завдання 32</div>
			<div class="question"><p>Прочитайте речення (<em>цифра позначає наступне слово</em>).</p>
			
			<p><strong><em>(1)</em></strong><em>Чотирн<strong><u>а</u></strong>дцятого <strong>(2)</strong>лист<strong><u>о</u></strong>пада трапився курйозний <strong>(3)</strong>вип<strong><u>а</u></strong>док: <strong>(4)</strong>мер<strong><u>е</u></strong>жа магазинів <strong>(5)</strong>«Р<strong><u>е</u></strong>шето» продала покупцям цілий <strong>(6)</strong>центн<strong><u>е</u></strong>р <strong>(7)</strong>к<strong><u>у</u></strong>рятини всього за <strong>(8)</strong>сімдес<strong><u>я</u></strong>т гривень, про що свідчив <strong>(9)</strong>в<strong><u>и</u></strong>разний <strong>(10)</strong>цінн<strong><u>и</u></strong>к.</em></p>
			
			<p>НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1,3,6,8 </div><div class="answer"><span class="marker">Б</span>1,4, 7,10 </div><div class="answer"><span class="marker">В</span>2,3,6,9 </div><div class="answer"><span class="marker">Г</span>2,4,5,10</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_21817" onclick="showComment(21817)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_21817" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q33" class="task-card" style="display: none;">
			<div class="counter">Завдання 33</div>
			<div class="question"><p>Прочитайте речення (цифра позначає наступне слово).</p>
			
			<p><em>Психологиня, (1)доньк<b><u>а</u></b> моєї (2)п<b><u>о</u></b>други, пообіцяла (3)прин<b><u>е</u></b>сти (4)чергов<b><u>и</u></b>й&nbsp;(5)ф<b><u>а</u></b>ховий журнал, де зробила (6)п<b><u>о</u></b>значки щодо цікавих (7)в<b><u>и</u></b>падків (8)п<b><u>і</u></b>дліткових (9)уподоб<b><u>а</u></b>нь.</em></p>
			
			<p><br>
			НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1, 4, 6, 9</div><div class="answer"><span class="marker">Б</span>2, 3, 5, 7</div><div class="answer"><span class="marker">В</span>1, 3, 5, 9</div><div class="answer"><span class="marker">Г</span>2, 4, 6, 8</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22755" onclick="showComment(22755)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22755" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q34" class="task-card" style="display: none;">
			<div class="counter">Завдання 34</div>
			<div class="question"><p>Прочитайте речення <em>(цифра позначає наступне слово).</em></p>
			
			<p><strong><em>(1)</em></strong><em>Відг<strong><u>о</u></strong>мін перелітних птахів, глибокі <strong>(2)</strong>к<strong><u>о</u></strong>лії на розмитому дощами <strong>(3)</strong>чорноз<strong><u>е</u></strong>мі, перший <strong>(4)</strong>пр<strong><u>и</u></strong>морозок, <strong>(5)</strong>бурштин<strong><u>о</u></strong>ве й багряне листя, струшене <strong>(6)</strong>листоп<strong><u>а</u></strong>дом, – усе це <strong>(7)<u>о</u></strong>знаки <strong>(8)</strong>чарівн<strong><u>о</u></strong>ї осені.</em></p>
			
			<p>НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1, 3, 7</div><div class="answer"><span class="marker">Б</span>4, 5, 8</div><div class="answer"><span class="marker">В</span>1, 2, 6</div><div class="answer"><span class="marker">Г</span>4, 7, 8</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_23722" onclick="showComment(23722)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_23722" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q35" class="task-card" style="display: none;">
			<div class="counter">Завдання 35</div>
			<div class="question"><p>
			        Прочитайте речення (цифра позначає наступне слово).
			    </p>
			    <p>
			        <i>Ще в (<b>1</b>)п<b><u>і</u></b>длітковому віці (<b>2</b>)впод<b><u>о</u></b>баннями Андрія були (<b>3</b>)ч<b><u>и</u></b>тання (<b>4</b>)довідник<b><u>і</u></b>в, (<b>5</b>)фахов<b><u>и</u></b>х журналів з історії та пошук (<b>6</b>)від<b><u>о</u></b>мостей про (<b>7</b>)укра<b><u>ї</u></b>нський (<b>8</b>)в<b><u>и</u></b>звольний рух.</i>
			    </p>
			    <p>
			    НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами
			    </p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1 ,4, 7</div><div class="answer"><span class="marker">Б</span>3 ,5, 6</div><div class="answer"><span class="marker">В</span>1, 2, 8</div><div class="answer"><span class="marker">Г</span>3, 4, 8</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_24779" onclick="showComment(24779)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_24779" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q36" class="task-card" style="display: none;">
			<div class="counter">Завдання 36</div>
			<div class="question"><p>На другий склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>начинка</div><div class="answer"><span class="marker">Б</span>випадок</div><div class="answer"><span class="marker">В</span>дрова</div><div class="answer"><span class="marker">Г</span>загадка</div><div class="answer"><span class="marker">Д</span>русло</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_25978" onclick="showComment(25978)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_25978" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q37" class="task-card" style="display: none;">
			<div class="counter">Завдання 37</div>
			<div class="question"><p>На перший склад падає наголос у слові</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>зручний</div><div class="answer"><span class="marker">Б</span>проміжок</div><div class="answer"><span class="marker">В</span>перекис</div><div class="answer"><span class="marker">Г</span>експерт</div><div class="answer"><span class="marker">Д</span>фаховий</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_26098" onclick="showComment(26098)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_26098" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => 0</span> -->
			</div>
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
					<div class="test-bal">Максимальна кількість балів: <strong>37</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
					<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/ukrainian/tema.html">до списку тем</a>.</small></em></div>
				</div>
					<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/tag-sklad_nagolos/?1673691138">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukrainian/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			</div>
			<div class="q-info question res"><span class="q-btn button-gray q-up" onclick="window.scrollTo(0,150);">На початок сторінки</span></div></div></div>
			
			<div class="clear"></div>
			
			<!-- zno_quest_list_by_tag_all 0.33088 c. -->
			
			
			<!-- banners - banner_multimob - 1969 -->
			<!--noindex-->
			<div class="banner-wrapper">
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?141101.1664532469" border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?141101.1669048925" border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?141101.1669049035" border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?141101.1668508411" border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?141101.1671209018" border="0" alt=""></a>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner_multimob 0.00063 c. -->
			
			
			<!-- banners - banner620 - 1970 -->
			<!-- id=5 -->
			<!--noindex-->
			<div class="artbanner videoad w620 hauto txtcntr">
			<div class="txtcntr">
			<center>
			<div id="admixer_b192d298027042deada9da507fa129f8_zone_1010_sect_226_site_226"></div><script type="text/javascript" src="https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=87252397-7105-4764-a755-8652df76a6e3"></script>
			
			</center>
			</div>
			</div>
			<div class="clear"></div>
			<!--/noindex-->
			
			<!-- banner620 0.00045 c. -->
			
			
			<!-- znotest - fb_comments - 1971 -->
			<div class="clear"></div>
			
			<div class="bcont">
			<div class="fb-comments fb_iframe_widget fb_iframe_widget_fluid_desktop" data-href="https://zno.osvita.ua/ukrainian/tag-sklad_nagolos/" data-width="620" data-numposts="10" fb-xfbml-state="rendered" fb-iframe-plugin-query="app_id=178406328912732&amp;container_width=620&amp;height=100&amp;href=https%3A%2F%2Fzno.osvita.ua%2Fukrainian%2Ftag-sklad_nagolos%2F&amp;locale=uk_UA&amp;numposts=10&amp;sdk=joey&amp;version=v2.9&amp;width=620"><span style="vertical-align: bottom; width: 620px; height: 2492px;"><iframe name="f24bd58b84040f" width="620px" height="100px" data-testid="fb:comments Facebook Social Plugin" title="fb:comments Facebook Social Plugin" frameborder="0" allowtransparency="true" allowfullscreen="true" scrolling="no" allow="encrypted-media" src="https://web.facebook.com/v2.9/plugins/comments.php?app_id=178406328912732&amp;channel=https%3A%2F%2Fstaticxx.facebook.com%2Fx%2Fconnect%2Fxd_arbiter%2F%3Fversion%3D46%23cb%3Df14a09c88efaae%26domain%3Dzno.osvita.ua%26is_canvas%3Dfalse%26origin%3Dhttps%253A%252F%252Fzno.osvita.ua%252Ff2c3df80257cda4%26relation%3Dparent.parent&amp;container_width=620&amp;height=100&amp;href=https%3A%2F%2Fzno.osvita.ua%2Fukrainian%2Ftag-sklad_nagolos%2F&amp;locale=uk_UA&amp;numposts=10&amp;sdk=joey&amp;version=v2.9&amp;width=620" style="border: none; visibility: visible; width: 620px; height: 2492px;" class=""></iframe></span></div>
			</div>
			
			<div class="clear"></div>
			<!-- fb_comments 0.00015 c. -->
			
			
			            </div>
			            <div class="col-right homepage-right-hide">
						
			<!-- banners - banner_multi_300 - 1972 -->
			<!--noindex-->
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?141101.1664532469" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?141101.1669048925" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?141101.1669049035" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?141101.1668508411" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?141101.1671209018" width="300" height="100" border="0" alt=""></a>
			</div>
			<!--/noindex-->
			<!-- banner_multi_300 0.00148 c. -->
			
			
			<!-- banners - banner300 - 1973 -->
			<!--noindex-->
			<div class="block w300 wrapbanner" style="height:600px;">
			<div class="banner" style="height:600px;">
			<!-- id=1 -->
			<div id="admixer_741839645c2346e68867b1f3f0e96a5e_zone_20646_sect_226_site_226"></div><script type="text/javascript" src="https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=74a1f9e1-65c3-4075-a988-90d4b6350625"></script>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner300 0.00052 c. -->
			
			
						<div class="clear"></div>
			            </div>
			            <div class="hr-line-wrapper">
			                <div class="hr-line"></div>
			            </div>
			        </div>
				</div>
				
			    <div class="container">
			        <div id="footer" class="footer">
			            <div class="col-footer-left">
			                <div class="copyright">
			                    ©&nbsp;2007–2023 «Освіта.ua».<br>
			                    Сайт "ЗНО-ОНЛАЙН" створений та підтримується інтернет-ресурсом "Освіта.ua"<br>
			                    <a href="https://osvita.ua/advert.html">Реклама на сайті</a><br>
								<a href="https://zno.osvita.ua/agreement.html" target="_blank">Угода користувача</a>
			                </div>
			            </div>
			            <div class="col-footer-right">
			                E-mail: <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script><a href="mailto:office@osvita.ua">office@osvita.ua</a> <br>
			                Соціальні мережі: <br>
							<a href="https://www.facebook.com/abiturients/">Ми у Facebook</a>&nbsp; &nbsp; 
							<a href="https://t.me/vstuposvita">Ми у Telegram</a><br>
							
			<div class="counter bigmir">
			
			
			<!--bigmir)net TOP 100-->
			<script type="text/javascript" language="javascript"><!--
			bmN=navigator,bmD=document,bmD.cookie='b=b',i=0,bs=[],bm={v:16796306,s:16796306,t:29,c:bmD.cookie?1:0,n:Math.round((Math.random()* 1000000)),w:0};
			for(var f=self;f!=f.parent;f=f.parent)bm.w++;
			try{if(bmN.plugins&&bmN.mimeTypes.length&&(x=bmN.plugins['Shockwave Flash']))bm.m=parseInt(x.description.replace(/([a-zA-Z]|\s)+/,''));
			else for(var f=3;f<20;f++)if(eval('new ActiveXObject("ShockwaveFlash.ShockwaveFlash.'+f+'")'))bm.m=f}catch(e){;}
			try{bm.y=bmN.javaEnabled()?1:0}catch(e){;}
			try{bmS=screen;bm.v^=bm.d=bmS.colorDepth||bmS.pixelDepth;bm.v^=bm.r=bmS.width}catch(e){;}
			r=bmD.referrer.replace(/^w+:\/\//,'');if(r&&r.split('/')[0]!=window.location.host){bm.f=escape(r).slice(0,400);bm.v^=r.length}
			bm.v^=window.location.href.length;for(var x in bm) if(/^[vstcnwmydrf]$/.test(x)) bs[i++]=x+bm[x];
			bmD.write('<a href="http://www.bigmir.net/" target="_blank" onClick="img=new Image();img.src="//www.bigmir.net/?cl=16796306";"><img src="//c.bigmir.net/?'+bs.join('&')+'"  width="160" height="19" border="0" alt="bigmir)net TOP 100" title="bigmir)net TOP 100"></a>');
			//-->
			</script><a href="http://www.bigmir.net/" target="_blank" onclick="img=new Image();img.src=" www.bigmir.net="" ?cl="16796306&quot;;&quot;"><img src="//c.bigmir.net/?v16796817&amp;s16796306&amp;t29&amp;c1&amp;n927942&amp;w0&amp;y0&amp;d24&amp;r1536&amp;fhttps%3A//zno.osvita.ua/ukrainian/tema.html" width="160" height="19" border="0" alt="bigmir)net TOP 100" title="bigmir)net TOP 100"></a>
			<noscript>
			<a href="http://www.bigmir.net/" target="_blank"><img src="//c.bigmir.net/?v16796306&s16796306&t29" width="160" height="19" alt="bigmir)net TOP 100" title="bigmir)net TOP 100" border="0" /></a>
			</noscript>
			<!--bigmir)net TOP 100-->
			
			
			</div> 
			            </div>
			        </div>
			    </div>
			
			
			
			
			    <div class="modal">
			        <div class="modal-content">
			            <span class="close-button">×</span>
			            <div class="title">Вхід</div>
						<form action="/users/?do=login" method="post">
			            <div class="auth-block">
			                <div id="floatContainer01" class="email-block float-container active notactive">
			                    <label for="floatField01">Email</label>
			                    <input type="email" name="email" id="floatField01" data-placeholder="">
			                </div>
			                <div id="floatContainer02" class="email-block float-container active notactive">
			                    <label for="floatField02">Пароль</label>
			                    <input type="password" name="pass" id="floatField02" data-placeholder="">
			                </div>
			            </div>
			            <input type="submit" class="button-green button-green-registry" value="Увійти"><br>
						</form>
			            <a class="restore-password" href="/users/?do=recall">Нагадати пароль!</a>
			            <div class="hr-line"></div>
			            <div class="register-text">
			                Не маєте облікового запису?<br>
			                Зареєструйтеся зараз
			            </div>
			            <a class="button-green" href="/users/?do=register">Зареєструватися</a>
			        </div>
			    </div>
			
			<div class="scroll-up" style="display: none;"><div class="clk"></div></div>
			
			
			<!-- тег ремаркетинга Google -->
			<script type="text/javascript">
			/* <![CDATA[ */
			var google_conversion_id = 976915692;
			var google_custom_params = window.google_tag_params;
			var google_remarketing_only = true;
			/* ]]> */
			</script>
			<script type="text/javascript" src="https://www.googleadservices.com/pagead/conversion.js">
			</script><iframe name="google_cookie_match_frame" title="Google cookie match frame" width="1" height="1" src="https://bid.g.doubleclick.net/xbbe/pixel?d=KAE" frameborder="0" marginwidth="0" marginheight="0" vspace="0" hspace="0" allowtransparency="true" style="display:none" scrolling="no"></iframe>
			<noscript>
			<div style="display:inline;">
			<img height="1" width="1" style="border-style:none;" alt="" src="https://googleads.g.doubleclick.net/pagead/viewthroughconversion/976915692/?value=0&amp;guid=ON&amp;script=0"/>
			</div>
			</noscript>
			
			<!-- банер Rich Media -->
			<div id="admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226"></div>
			<script type="text/javascript">
			    admixerML.fn.push(function () { admixerML.display('admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226'); });
			</script>
			
			<!-- Mobile банер Rich Media -->
			<div id="admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226"></div>
			<script type="text/javascript">
			    admixerML.fn.push(function () { admixerML.display('admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226'); });
			</script>
			
			<!-- link to Premium -->
			<a class="btn_uho nopremium" href="https://bit.ly/34MLWoO" rel="nofollow">ПРЕМІУМ ДОСТУП</a>
			<style>
			.btn_uho{
			display: block;
			position: fixed;
			width: 25px;
			height: 170px;
			background-color: #35866e;
			color:#fff;
			box-shadow: 2px -2px 5px #35876f;
			border-top-left-radius:10px;
			border-bottom-left-radius:10px;
			letter-spacing: 1px;
			writing-mode: vertical-rl;
			line-height: 25px;
			font-size: 16px;
			font-weight: 700;
			text-align: center;
			text-decoration: none;
			padding: 10px;
			left: 0;
			top: 30%;
			transform: rotate(180deg);
			transition: all .2s .1s;
			z-index: 99999;
			}
			.btn_uho:hover{color:#fff;text-decoration:none;box-shadow:3px -3px 6px #35876f;padding:12px 20px 12px 10px;margin-top:-3px;}
			@media screen and (max-width:1000px){.btn_uho{display:none;}}
			</style>
			
			
			
			<script src="https://zno.osvita.ua/doc/js/common.js?v0105"></script>
			<script src="https://zno.osvita.ua/doc/js/social-likes.min.js"></script>
			
			<!-- simple -->
			
			
			
			
			<div style="display: none; visibility: hidden;"><script data-ad-client="ca-pub-7936802855264727" async="null" src="https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script></div><div style="display: none; visibility: hidden;"></div></body> 
			""";

		public static string html2 = """
			 
			<!DOCTYPE html>
			<html lang="uk" prefix="fb: http://ogp.me/ns/fb# og: http://ogp.me/ns#">
			<head>
				<meta charset="utf-8">
			    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no, minimum-scale=1, user-scalable=no">
				<title>Склад. Наголос – тести ЗНО/НМТ – завдання з української мови – сайт ЗНО.Освіта.UA</title>
				<!-- 0.3417489528656 server 3-->
			<meta name="title" content="Склад. Наголос – тести ЗНО/НМТ – завдання з української мови – сайт ЗНО.Освіта.UA" />
			<meta http-equiv="Expires" content="Thu, Jan 1 1970 00:00:00 GMT">
			<meta http-equiv="Pragma" content="no-cache">
			<meta http-equiv="Cache-Control" content="no-cache">
			<meta name="referrer" content="origin-when-cross-origin">
			<meta name="format-detection" content="telephone=no">
			<meta http-equiv="Content-language" content="uk" />
			<meta name="description" content="Завдання та тести з теми &quot;Склад. Наголос&quot; зовнішнього незалежного оцінювання (ЗНО), національного мультипредметного тесту (НМТ) з української мови" />
			<meta name="keywords" content="" />
			<meta property="og:title" content="Склад. Наголос – тести ЗНО/НМТ – завдання з української мови – сайт ЗНО.Освіта.UA" />
			<meta property="og:description" content="Завдання та тести з теми &quot;Склад. Наголос&quot; зовнішнього незалежного оцінювання (ЗНО), національного мультипредметного тесту (НМТ) з української мови" />
			<meta property="og:url" content="https://zno.osvita.ua/ukrainian/tag-sklad_nagolos/" />
			<meta property="og:type" content="article" />
			<meta property="og:locale" content="uk_UA" />
			<meta property="og:site_name" content="сайт ЗНО.Освіта.UA" />
			<meta property="og:image" content="https://zno.osvita.ua/doc/i/zno_200x200.png" />
			<meta property="og:image:width" content="200" />
			<meta property="og:image:height" content="200" />
			<meta property="fb:app_id" content="178406328912732" />
			
			<link rel="shortcut icon" type="image/x-icon" href="https://zno.osvita.ua/doc/i/favicons/favicon.ico" />
			<link rel="apple-touch-icon" sizes="114x114" href="/doc/i/favicons/icon_114x114_zno.png" />
			<link rel="apple-touch-icon" sizes="120x120" href="/doc/i/favicons/icon_120x120_zno.png" />
			<link rel="apple-touch-icon" sizes="144x144" href="/doc/i/favicons/icon_144x144_zno.png" />
			<link rel="apple-touch-icon" sizes="152x152" href="/doc/i/favicons/icon_152x152_zno.png" />
			<link rel="apple-touch-icon" sizes="180x180" href="/doc/i/favicons/icon_180x180_zno.png" />
			<link rel="apple-touch-icon" sizes="192x192" href="/doc/i/favicons/icon_192x192_zno.png" />
			<link rel="apple-touch-icon" sizes="256x256" href="/doc/i/favicons/icon_256x256_zno.png" />
			<link rel="icon" type="image/png" sizes="64x64" href="/doc/i/favicons/icon_64x64_zno.png"/>
			<link rel="icon" type="image/png" sizes="96x96" href="/doc/i/favicons/icon_96x96_zno.png"/>
			<link rel="icon" type="image/png" sizes="16x16" href="/doc/i/favicons/icon_16x16_zno.png" />
			<link rel="icon" type="image/png" sizes="32x32" href="/doc/i/favicons/icon_32x32_zno.png" />
			<link rel="manifest" href="/doc/i/favicons/manifest.json" />
			<meta name="msapplication-config" content="/doc/i/favicons/browserconfig.xml" />
			
			<base href="//zno.osvita.ua/" />
				<!--<link rel="stylesheet" href="css/libs.min.css">-->
				<link rel="stylesheet" href="https://zno.osvita.ua/doc/css/normalize.css">
				<link rel="stylesheet" href="https://zno.osvita.ua/doc/css/main.min.css?v=17032020">
				<link rel="stylesheet" href="https://zno.osvita.ua/doc/css/fonts.css">
			    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/social-likes/dist/social-likes_birman.css">
			
			
				<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js"></script>
				<script>window.jQuery || document.write('<script src="https://zno.osvita.ua/doc/js/jquery-1.8.0.min.js"><\/script>')</script>
				<script type="text/javascript" src="https://zno.osvita.ua/doc/js/znoscript8.js?v=02052022"></script>
			
			
			<!--START Admixer-->
			<script type="text/javascript">
			    (function () {
			        var w = window,
						d = document,
						protocol = /https/i.test(w.location.protocol) ? 'https:' : 'http:',
						aml = typeof admixerML !== 'undefined' ? admixerML : {};
			        aml.fn = aml.fn || [];
			        aml.invPath = aml.invPath || (protocol + '//inv-nets.admixer.net/');
			        aml.cdnPath = aml.cdnPath || (protocol + '//cdn.admixer.net/');
			        if (!w.admixerML) {
			            var lodash = document.createElement('script');
			            lodash.id = 'amlScript';
			            lodash.async = true;
			            lodash.type = 'text/javascript';
			            lodash.src = aml.cdnPath + 'scripts3/loader2.js';
			            var node = d.getElementsByTagName('script')[0];
			            node.parentNode.insertBefore(lodash, node);
			            w.admixerML = aml;
			        }
			    })();
			</script>
			<script type="text/javascript">
			admixerML.fn.push(function () {
				// CatFish bottom
				admixerML.defineSlot({
					z: '7b98aa89-284f-4b35-a32a-f6f334259573',
					ph: 'admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226',
					i: 'inv-nets'
				});
			
			    // CatFish mobile
				admixerML.defineSlot({
					z: '5fce274d-5435-45a5-b87f-69de1b4043c8',
					ph: 'admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226',
					i: 'inv-nets'
				});
			
			
			    // id = 4 - Брендирование admixer 1000х100
			        admixerML.defineSlot({
			            z: '8a539a08-2913-4fd9-807e-076bdffb13e4',
			            ph: 'admixer_8a539a0829134fd9807e076bdffb13e4_zone_3405_sect_226_site_226',
			            i: 'inv-nets',
			            renderedCallback:function(slot){doBranding(slot.pageBranding)}
			        });
			
			    admixerML.singleRequest();
			});
			</script>
			
			
			<!--END Admixer-->
			
			
			
			<!-- Google Tag Manager -->
			<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
			new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
			j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
			'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
			})(window,document,'script','dataLayer','GTM-TDTR4NM');</script>
			<!-- End Google Tag Manager -->
			
			
			
			
			</head>
			<body id="body" class="ukrainian">
			
			
			 
			<!--noindex-->
			<!--bannertop-->
			<script type="text/javascript">
			function doBranding(br) {
					if( $(window).width() < 961 && $(window).width() > 100 ){
						document.getElementById('main-content').style.width="100%";
						document.getElementById('main-content').style.position="relative";
						document.getElementById('header').style.width=$(window).width()+"px";
						document.getElementById('header').style.position="sticky";
						document.getElementById('footer').style.width=$(window).width()+"px";
						document.getElementById('footer').style.position="sticky";
					}
					if(br){
						document.body.style.backgroundPosition = '50% 0%';
						document.body.style.backgroundRepeat= 'no-repeat';
			
						if(br.iu)document.body.style.backgroundImage = 'url('+br.iu+')';   //  br.iu - ссылка на картинку
						if(br.bg_color)document.body.style.backgroundColor = br.bg_color;    // Цвет фона
						if(br.top_margin)document.body.style.paddingTop = br.top_margin;    // Расстояние сверху до контента сайта
						if(br.top_position)document.body.style.backgroundAttachment = br.top_position;
			
						if(br.cu){
							document.body.style.cursor="pointer";
							document.body.setAttribute("onclick", "onlyBodyClick(event||window.event)");
							window.onlyBodyClick = function (e){
								var t = e.target||e.srcElement;
								if (t == document.body){ window.open(br.cu,'_blank'); }
							};
							document.addEventListener('touchstart', function(event) {
								var touch = event.touches[0];
								var t = event.target||event.srcElement;
								if(t == document.body) window.open(br.cu,'_blank');
							}, false);
						}
			
						if(document.getElementById('main-content') && $(window).width() > 960){
							document.getElementById('main-content').style.width="100%";
							document.getElementById('main-content').style.left="50%";
							document.getElementById('main-content').style.marginLeft="-490px";
							document.getElementById('main-content').style.position="relative";
							document.getElementById('main-content').style.cursor="default";
							document.getElementById('main-content').style.backgroundColor="white";
						}
						if(document.getElementById('header') && $(window).width() > 960){
							document.getElementById('header').style.width="980px";
							document.getElementById('header').style.backgroundColor="white";
							document.getElementById('header').style.cursor="default";
							document.getElementById('header').style.position="sticky";
						}
						if(document.getElementById('footer') && $(window).width() > 960){
							document.getElementById('footer').style.width="980px";
							document.getElementById('footer').style.cursor="default";
							document.getElementById('footer').style.backgroundColor="white";
							document.getElementById('footer').style.left="50%";
							document.getElementById('footer').style.position="sticky";
							//document.getElementById('footer').style.marginLeft="452px";
						}
						if(document.getElementById('body')){
							document.getElementById('body').style.backgroundColor='white';
						}
			      }
			  }
			</script> 
			<div id='admixer_8a539a0829134fd9807e076bdffb13e4_zone_3405_sect_226_site_226'></div>
			<script type="text/javascript">
			admixerML.fn.push(function () { admixerML.display('admixer_8a539a0829134fd9807e076bdffb13e4_zone_3405_sect_226_site_226'); });
			</script>   
			 
			<!--bannertop-->
			<!--/noindex-->
			
			
			<!-- Google Tag Manager (noscript) -->
			<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-TDTR4NM"
			height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
			<!-- End Google Tag Manager (noscript) -->
			<div id="fb-root"></div>
			<script>(function(d, s, id) {
			  var js, fjs = d.getElementsByTagName(s)[0];
			  if (d.getElementById(id)) return;
			  js = d.createElement(s); js.id = id;
			  js.src = "//connect.facebook.net/uk_UA/sdk.js#xfbml=1&version=v2.9&appId=178406328912732";
			  fjs.parentNode.insertBefore(js, fjs);
			}(document, 'script', 'facebook-jssdk'));</script>
			
			
				<div class="container">
					<div id="header" class="header">
						<div class="menu-block">
			                <div id="toggler"></div>
			                <div class="authorization-block">
			                    <span class="login nouser"><a href="/users/?do=login" onclick="return false;" title="Вхід">Вхід</a></span>
			                    <span class="profil isuser"><a href="/users/?do=profile" class="username">Профіль</a></span>
			                    <span class="separator"> / </span>
								<span class="logout isuser"><a href="/users/?do=logout" onclick="logout();return false;" title="Вхід">Вихід</a></span>
								<span class="register nouser"><a href="/users/?do=register">Реєстрація</a></span>
			                </div>
							<ul class="main-menu">
								<li><a href="/" class="active" title="ЗНО-онлайн">ЗНО-онлайн</a></li>
								<li><a href="https://osvita.ua/" title="ОСВІТА.UA">ОСВІТА.UA</a></li>
								<li><a href="https://osvita.ua/consultations/" title="Все про вступ на ОСВІТА.UA">Все про вступ</a></li>
								<li><a href="https://osvita.ua/test/" title="Все про ЗНО на ОСВІТА.UA">Все про ЗНО</a></li>
								<li><a href="https://vstup.osvita.ua/" title="Вступ.ОСВІТА.UA">Вступ.ОСВІТА.UA</a></li>
								<li><a href="https://osvita.ua/vnz/rating/" title="Рейтинги ВНЗ на ОСВІТА.UA">Рейтинги ВНЗ</a></li>
							</ul>
						</div>
						
			<!-- news - menu - 1967 -->
					<div class="title-block no-bottom-line">
						<a href="https://zno.osvita.ua" title="ЗНО-ОНЛАЙН"><span class="linkh1">ЗНО-ОНЛАЙН</span></a>
									<div class="description"><h1 class="desc">Завдання за темою з української мови та літератури</h1></div>
								</div>
			<div id="breadcrumbs" class="breadcrumbs" vocab="http://schema.org/" typeof="BreadcrumbList">
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="1" />
			<a property="item" typeof="WebPage" href="https://zno.osvita.ua"><span property="name">Тести ЗНО онлайн</span></a></span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="2" />
			<a href="https://zno.osvita.ua/ukrainian/tema.html" property="item" typeof="WebPage"><span property="name">Українська мова і література</span></a>
			</span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="3" />
			<a href="https://zno.osvita.ua/ukrainian/tag-analiz_tekstu_vysha_osvita/" property="item" typeof="WebPage">
			<meta property="name" content="Склад. Наголос – тести ЗНО/НМТ – завдання з української мови" />
			</a>
			<span>Склад. Наголос – тести ЗНО/НМТ – завдання з української мови</span>
			</span>
			<!-- tag --></div>
			
			<!-- curpath = /ukrainian/tag-analiz_tekstu_vysha_osvita/ -->
			
			<!-- menu 0.00381 c. -->
			
			
					</div>
				</div>
				
				<div class="container">
			        <div id="main-content">
			            <div class="col-main">
						
			<!-- znotest - zno_quest_list_by_tag_all - 1968 -->
			<!-- setTitle #### -->
			
			
			<style type="text/css">
			.test-title .label{color: #35866e; font-size:inherit; font-weight:normal;}
			</style>
			
			<script type="text/javascript">
			
			var qfirst = 1;
			var list = 0;
			var cnt = 37;
			var total = 37;
			var test_id = 'tag_27';
			var tag_id = 27;
			var quest_id = 1;
			var section = 3;
			var maxball = 37;
			var tpage = 'tag';
			var freetemp = 1;
			
			
			$(document).ready(function (){ 
				$('.tasks-numbers').on('click','.number', function(){ nextQuest(parseInt($(this).html())); });
				$('.two-buttons-container').on('click','.q-skip', function(){ nextQuest(); });
				$('.two-buttons-container').on('click','.q-next', function(){ saveResult(); });
				$('.select-answers-variants').on('click','.marker', function(){ showButNxt($(this)); });
				$('.q-test').on('click','.inptext', function(){ showButNxt($(this)); });
				$('.answer').on('click','.inptext', function(){ showButNxt($(this)); });
				$('.two-buttons-container').on('click','.q-final', function(){
					if( $(this).hasClass("q-savetemp") ){
						if (!checkUser()) {
							var refpath = getCurPath();
							var data = getSessionStorageItems();
							setCookie('temp'+test_id, data.length, {path:refpath[2], expires: 7*86400});
							saveStorageItems('test'+test_id, resultsToAnswers(data));
							alert("Ви не є зареєстрованим/авторизованим користувачем, але \nвідповіді збережено для продовження наступного разу!");
							return ;
						}else{
							window.savetemp = test_id;
							if (!isPrem()){
								var refpath = getCurPath();
								var data = getSessionStorageItems();
								setCookie('temp'+test_id, data.length, {path:refpath[2], expires: 7*86400});
								saveStorageItems('test'+test_id, resultsToAnswers(data));
								alert("Відповіді збережено для продовження наступного разу!");
								return ; 
							}
						}
					}
					endResult(); 
				});
				if(isPrem()){$.get('/users/checkpr.php',function(data){if(data&&(!data.ok||data.err)){if(data.delpr){setCookie('nopr',1,{'path':'/'});deleteCookie('premium');deleteCookie('order');}}});}
				var prz = getCookie('t'+test_id);
				if( prz && prz < total - 3 && prz > 2){
					$('#waiting2').html('Минулого разу останнім було завдання № '+getCookie('t'+test_id)+'.').show();
				}
				clearSessionStorageItem();
				if (checkUser()) {
					if( location.hash ){
						var res = location.hash.match(/tmp_id/);	
					}
					if( location.hash && res){
						console.log('location.hash: '+location.hash);
						getTempResult(location.hash);
					}else if( getCookie('tmp'+test_id) ){
						console.log('tmp'+test_id);
						getTempResult(test_id);
					}else if ( getCookie('temp'+test_id) ){
						console.log('temp'+test_id);
						var refpath = getCurPath();
						setCookie('temp'+test_id, 0, {path:refpath[2], expires: -86400});
						var data = getStorageItems('test'+test_id);
						clearStorageItems('test'+test_id);
						resultTempExit(data);
					}else{
						var prs = getStorageItems('section_temp_tag_pr_'+section);
						console.log('temp_tag_'+tag_id+'='+prs[tag_id]);
						if(prs[tag_id]){
							getTempResult(tag_id);
						}
					}
				}else{
					if ( getCookie('temp'+test_id) ){
						var refpath = getCurPath();
						setCookie('temp'+test_id, 0, {path:refpath[2], expires: -86400});
						var data = getStorageItems('test'+test_id);
						clearStorageItems('test'+test_id);
						resultTempExit(data);
						if (data){
							setCookie('t'+test_id, 0, {path:refpath[2], expires: -86400});
							$('#waiting2').html('Минулого разу було збережено відповіді, тому можете продовжити.').show();
						}
					}
				}
				progressBar();
			});
			
			
			
			
			Array.prototype.associate = function (keys) {
				var result = {};
				this.forEach(function (el, i) {
					result[keys[i]] = el;
				});
				return result;
			};
			
			function resultsToAnswers(data){
				var qid = [], ans = [];
				for(var i in data){
					qid.push(data[i]['q']['id']);
					ans.push(data[i]['a']);
				}
				console.log(ans.associate(qid));
				return ans.associate(qid);
			}
			
			function getTempResult(tmp_id){
				if(!tmp_id){ return;}
				window.mysend['do'] = 'get_savetemp';
				window.mysend['section'] = section;
				window.mysend['tmp_id'] = tmp_id;
				if(typeof window.tag_id !== "undefined"){ 
					var action_url = '/users/znotest/tag/';
					window.mysend['tag_id'] = tag_id;
				}else{
					var action_url = '/users/znotest/';
					window.mysend['znotest'] = test_id;
				}
				console.log(action_url);
				$.ajax({
					url: action_url,
					type: "POST",
			        data: window.mysend,
			        'timeout': 20000,
					dataType: 'json', 
					success: function(data){
						if( data.ok && data.ok=='ok' ){
							resultTempExit(data.answers);
							//var refpath = getCurPath();
							//setCookie('tmp'+test_id, 0, {path:refpath[2], expires: -86400});
							$('.err_msg').remove();
						}else{
							if( data.error ){
								console.log('Помилка 1, немає збереженого результату. Error: ' + data.error);
								//$('#wrap').before('<p>Помилка 1, немає збереженого результату... ' + data.error + '</p>' );
							}else{
								console.log('Помилка 2, немає збереженого результату.');
								//$('#wrap').before('<p>Помилка 2, немає збереженого результату...</p>');
							}
						}
					},
					error: function(jqXHR, textStatus, errorThrown){
						$('#wrap').before('<p class="err_msg">'+res+'</p>' );	
						$('#waiting').hide();
					},
				});	
			}
			
			function resultTempExit(data){
				$('.tasks-numbers').show();
				$('#waiting').hide();
				if(data){
					$('.number.q1').removeClass('current');
					//console.log(data);
					var isres = false;
					for(var i in data){
						var id = $('.card_'+i).attr('id');
						isres = false;
						console.log(id+': '+i+': '+data[i]);
						$('.task-card').hide();
						$('#'+id ).show();
						var items = $('.card_'+i).find(".q-radio");
						if(items.length){
							items.each( function() {
								if((data[i]).match(/;/)){
									var patt = new RegExp($(this).val());
									if( patt.test(data[i]) ){
										$(this).prop("checked", true);
										isres = true;
									}
								}else{
									if( $(this).val() == data[i] ){
										$(this).prop("checked", true);
										isres = true;
									}
								}
							});
						}else{
							items = $('.card_'+i).find(".inptext");
							var res = []; 
							var j = 0;
							if((data[i]).match(/;/)){ res = (data[i]).split(";"); }
							if(items.length){
								items.each( function() {
									console.log(j+': '+res[j]);
									if(res){
										if(res.length > 1){
											$(this).val(res[j]);
										}else{
											$(this).val(data[i]);
										}
										isres = true;
									}else{
										$('.number.'+id).addClass('good');
									}
									j++;
								});
							}else{
								$('.number.'+id).addClass('good');
							}				
						}
						if(isres){
							window.quest_id = parseInt(id.replace("q", ""));
							saveResult();
						}
					}
					nextQuest(window.quest_id-1);
				}
				window.scrollTo(0, $('#tasks-numbers').offset().top - 20);
			}
			</script>
			
			
			<div class="q-progress-bar"><div class="q-progress" style=""></div></div>
			<div title="Приховати таймер" class="q-timer"><span class="q-timer-txt"></span></div>
			
			<div class="test-title">
			<!-- 1 - 0 - Українська мова і література -->
			<span class="label">Предмет:</span>&nbsp;<span class="row">УКРАЇНСЬКА МОВА</span><br><!-- 2 - 1 - УКРАЇНСЬКА МОВА -->
			<span class="label">Розділ:</span>&nbsp;<span class="row">Фонетика. Графіка. Орфоепія</span><br><!-- 3 - 23 - Фонетика. Графіка. Орфоепія -->
			<span class="label">Тема:</span>&nbsp;<span class="row">Склад. Наголос</span><br><!-- 4 - 24 - Склад. Наголос -->
			<span class="label">Кількість завдань:</span>&nbsp;<span class="row">37</span> <!-- 37 -->
			</div>
			
			<div class="tasks-numbers" id="tasks-numbers">
			<span class="number q1 current">1</span><span class="number q2">2</span><span class="number q3">3</span><span class="number q4">4</span><span class="number q5">5</span><span class="number q6">6</span><span class="number q7">7</span><span class="number q8">8</span><span class="number q9">9</span><span class="number q10">10</span><span class="number q11">11</span><span class="number q12">12</span><span class="number q13">13</span><span class="number q14">14</span><span class="number q15">15</span><span class="number q16">16</span><span class="number q17">17</span><span class="number q18">18</span><span class="number q19">19</span><span class="number q20">20</span><span class="number q21">21</span><span class="number q22">22</span><span class="number q23">23</span><span class="number q24">24</span><span class="number q25">25</span><span class="number q26">26</span><span class="number q27">27</span><span class="number q28">28</span><span class="number q29">29</span><span class="number q30">30</span><span class="number q31">31</span><span class="number q32">32</span><span class="number q33">33</span><span class="number q34">34</span><span class="number q35">35</span><span class="number q36">36</span><span class="number q37">37</span></div>
			
			<div id="waiting" style="display:none;"><center>Зачекайте, йде розрахунок...<br><div id="wait"> </div></center></div>
			<div id="waiting2" style="display:none;"></div>
			
			<div id="wrap">
			
			<!-- abc=0 --><!-- out_order=1 --> 
			 
			<div class="task-card current card_7" style="" id="q1">
			<div class="counter">Завдання 1 з 37</div>
			<form class="q-test" id="q_form_1" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="1">
			<input type="hidden" name="q[tip]" id="q1-tip" value="1">
			<input type="hidden" name="q[id]" value="7">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Правильно підкреслено літеру на позначення наголошеного звука в слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>ол<b><u>е</u></b>нь</div><div class="answer"><span class="marker">Б</span>к<b><u>о</u></b>лесо</div><div class="answer"><span class="marker">В</span>ч<b><u>и</u></b>тання</div><div class="answer"><span class="marker">Г</span>вип<b><u>а</u></b>док</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7" onclick="showComment(7)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>Олень (а не олЕнь), читАння (а не чИтання), вИпадок (а не випАдок). </em>Наголошений звук у слові <em>кОлесо </em>визначений правильно.</p>
			
			<p><strong>Відповідь &ndash; Б.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 4. Завдання: <b>7</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_65" style="display:none;" id="q2">
			<div class="counter">Завдання 2 з 37</div>
			<form class="q-test" id="q_form_2" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="2">
			<input type="hidden" name="q[tip]" id="q2-tip" value="1">
			<input type="hidden" name="q[id]" value="65">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>черговий</div><div class="answer"><span class="marker">Б</span>псевдонім</div><div class="answer"><span class="marker">В</span>ознака</div><div class="answer"><span class="marker">Г</span>осока</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_65" onclick="showComment(65)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_65" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><b>ТЕМА: </b><strong>Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>черговИй, псевдонІм, ознАка, осокА.</em></p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 6. Завдання: <b>65</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_186" style="display:none;" id="q3">
			<div class="counter">Завдання 3 з 37</div>
			<form class="q-test" id="q_form_3" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="3">
			<input type="hidden" name="q[tip]" id="q3-tip" value="1">
			<input type="hidden" name="q[id]" value="186">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На третій склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>кропива</div><div class="answer"><span class="marker">Б</span>периметр</div><div class="answer"><span class="marker">В</span>підошва</div><div class="answer"><span class="marker">Г</span>однаковий</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_186" onclick="showComment(186)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_186" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>кропивА, перИметр, підОшва, однАковий.</em></p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 10. Завдання: <b>186</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_250" style="display:none;" id="q4">
			<div class="counter">Завдання 4 з 37</div>
			<form class="q-test" id="q_form_4" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="4">
			<input type="hidden" name="q[tip]" id="q4-tip" value="1">
			<input type="hidden" name="q[id]" value="250">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>однаковий</div><div class="answer"><span class="marker">Б</span>добовий</div><div class="answer"><span class="marker">В</span>щовесни</div><div class="answer"><span class="marker">Г</span>сантиметр</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_250" onclick="showComment(250)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_250" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>однАковий, добовИй, щовеснИ, сантимЕтр.</em></p>
			
			<p><strong>Відповідь: А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 11. Завдання: <b>250</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_310" style="display:none;" id="q5">
			<div class="counter">Завдання 5 з 37</div>
			<form class="q-test" id="q_form_5" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="5">
			<input type="hidden" name="q[tip]" id="q5-tip" value="1">
			<input type="hidden" name="q[id]" value="310">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>жалюзі</div><div class="answer"><span class="marker">Б</span>чіткий</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>деякий</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_310" onclick="showComment(310)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_310" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>жалюзІ, чіткИй, перЕпис, дЕякий.</em></p>
			
			<p><strong>Відповідь: Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 12. Завдання: <b>310</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=8 --> 
			<div class="task-card card_377" style="display:none;" id="q6">
			<div class="counter">Завдання 6 з 37</div>
			<form class="q-test" id="q_form_6" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="6">
			<input type="hidden" name="q[tip]" id="q6-tip" value="1">
			<input type="hidden" name="q[id]" value="377">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>одинадцять</div><div class="answer"><span class="marker">Б</span>черговий</div><div class="answer"><span class="marker">В</span>цемент</div><div class="answer"><span class="marker">Г</span>кидати</div><div class="answer"><span class="marker">Д</span>поки</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_377" onclick="showComment(377)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q8" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_377" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>один<strong>А</strong>дцять, чергов<strong>И</strong>й, цем<strong>Е</strong>нт, к<strong>И</strong>дати, п<strong>О</strong>ки.</em></p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 13. Завдання: <b>377</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=8 --> 
			<div class="task-card card_458" style="display:none;" id="q7">
			<div class="counter">Завдання 7 з 37</div>
			<form class="q-test" id="q_form_7" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="7">
			<input type="hidden" name="q[tip]" id="q7-tip" value="1">
			<input type="hidden" name="q[id]" value="458">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>кропива</div><div class="answer"><span class="marker">Б</span>псевдонім</div><div class="answer"><span class="marker">В</span>запитання</div><div class="answer"><span class="marker">Г</span>ознака</div><div class="answer"><span class="marker">Д</span>осока</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_458" onclick="showComment(458)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q8" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_458" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>кропивА, псевдонІм, запитАння, ознАка, осокА.</em></p>
			
			<p><strong>Відповідь: Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 14. Завдання: <b>458</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_754" style="display:none;" id="q8">
			<div class="counter">Завдання 8 з 37</div>
			<form class="q-test" id="q_form_8" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="8">
			<input type="hidden" name="q[tip]" id="q8-tip" value="1">
			<input type="hidden" name="q[id]" value="754">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>ожеледь</div><div class="answer"><span class="marker">Б</span>деінде</div><div class="answer"><span class="marker">В</span>перекис</div><div class="answer"><span class="marker">Г</span>експерт</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_754" onclick="showComment(754)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_754" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>Ожеледь, деІнде, перЕкис, екпЕрт.</em></p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 19. Завдання: <b>754</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_1391" style="display:none;" id="q9">
			<div class="counter">Завдання 9 з 37</div>
			<form class="q-test" id="q_form_9" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="9">
			<input type="hidden" name="q[tip]" id="q9-tip" value="1">
			<input type="hidden" name="q[id]" value="1391">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>листопад</div><div class="answer"><span class="marker">Б</span>новина</div><div class="answer"><span class="marker">В</span>столяр</div><div class="answer"><span class="marker">Г</span>літопис</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_1391" onclick="showComment(1391)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_1391" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>листопАд, новинА, стОляр, літОпис.</em></p>
			
			<p><strong>Відповідь: Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 30. Завдання: <b>1391</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_6421" style="display:none;" id="q10">
			<div class="counter">Завдання 10 з 37</div>
			<form class="q-test" id="q_form_10" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="10">
			<input type="hidden" name="q[tip]" id="q10-tip" value="1">
			<input type="hidden" name="q[id]" value="6421">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Перший склад наголошений у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>розвал</div><div class="answer"><span class="marker">Б</span>тонкий</div><div class="answer"><span class="marker">В</span>разом</div><div class="answer"><span class="marker">Г</span>люблю</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6421" onclick="showComment(6421)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6421" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання традиційно пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>розв<strong>А</strong>л, тонк<strong>И</strong>й, р<strong>А</strong>зом, любл<strong>Ю</strong>.</em></p>
			
			<p><strong>Відповідь &ndash; В. </strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 130. Завдання: <b>6421</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_6480" style="display:none;" id="q11">
			<div class="counter">Завдання 11 з 37</div>
			<form class="q-test" id="q_form_11" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="11">
			<input type="hidden" name="q[tip]" id="q11-tip" value="1">
			<input type="hidden" name="q[id]" value="6480">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Другий склад наголошений у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>приятель</div><div class="answer"><span class="marker">Б</span>недруг</div><div class="answer"><span class="marker">В</span>відгомін</div><div class="answer"><span class="marker">Г</span>обранець</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6480" onclick="showComment(6480)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6480" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують &nbsp;поширені &nbsp;слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>прИятель, нЕдруг, вІдгомін, обрАнець</em></p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 132. Завдання: <b>6480</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_6545" style="display:none;" id="q12">
			<div class="counter">Завдання 12 з 37</div>
			<form class="q-test" id="q_form_12" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="12">
			<input type="hidden" name="q[tip]" id="q12-tip" value="1">
			<input type="hidden" name="q[id]" value="6545">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Другий склад наголошений у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>запитання</div><div class="answer"><span class="marker">Б</span>сантиметр</div><div class="answer"><span class="marker">В</span>одинадцять</div><div class="answer"><span class="marker">Г</span>завдання</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6545" onclick="showComment(6545)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6545" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання традиційно пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>запит<strong>А</strong>ння, сантим<strong>Е</strong>тр, один<strong>А</strong>дцять,завд<strong>А</strong>ння</em>.</p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 133. Завдання: <b>6545</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6906" style="display:none;" id="q13">
			<div class="counter">Завдання 13 з 37</div>
			<form class="q-test" id="q_form_13" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="13">
			<input type="hidden" name="q[tip]" id="q13-tip" value="1">
			<input type="hidden" name="q[id]" value="6906">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>жалюзі</div><div class="answer"><span class="marker">Б</span>чіткий</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>випадок</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6906" onclick="showComment(6906)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6906" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>жалю<strong>зІ</strong> ( а не жАлюзі), чіткИй ( а не чІткий), перЕпис ( а не пЕрепис), вИпадок ( а не випАдок).</em></p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 139. Завдання: <b>6906</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_7093" style="display:none;" id="q14">
			<div class="counter">Завдання 14 з 37</div>
			<form class="q-test" id="q_form_14" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="14">
			<input type="hidden" name="q[tip]" id="q14-tip" value="1">
			<input type="hidden" name="q[id]" value="7093">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Перший склад наголошений у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>дрова</div><div class="answer"><span class="marker">Б</span>жалюзі</div><div class="answer"><span class="marker">В</span>жаркий</div><div class="answer"><span class="marker">Г</span>дочка</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7093" onclick="showComment(7093)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7093" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Це завдання перевіряє знання наголосу та вміння правильно наголошувати слова.</p>
			
			<p>Запропоновані приклади є проблемними щодо наголошування, оскільки часто мовці неправильно вимовляють їх.</p>
			
			<p>Ці слова правильно вимовляти так:</p>
			
			<p><em>дрова </em>&ndash; з наголосом на першому складі,</p>
			
			<p><em>жалюзі </em>&ndash; з наголосом на третьому складі (слово французького походження. а у французькій мові наголос фіксований на останньому складі),</p>
			
			<p><em>жаркий </em>&ndash; з наголосом на другому складі,</p>
			
			<p><em>дочка </em>&ndash; з наголосом на другому складі.</p>
			
			<p><strong>Відповідь &ndash;&nbsp;А.</strong></p>
			<script></script>
			<script></script>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 143. Завдання: <b>7093</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_7717" style="display:none;" id="q15">
			<div class="counter">Завдання 15 з 37</div>
			<form class="q-test" id="q_form_15" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="15">
			<input type="hidden" name="q[tip]" id="q15-tip" value="1">
			<input type="hidden" name="q[id]" value="7717">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>котрий</div><div class="answer"><span class="marker">Б</span>кілометр</div><div class="answer"><span class="marker">В</span>одинадцять</div><div class="answer"><span class="marker">Г</span>привезти</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7717" onclick="showComment(7717)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7717" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: </strong><strong>Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Неправильне наголошування слів &ndash; дуже поширена мовна помилка. Треба запам&rsquo;ятати правильний наголос у проблемних словах.</p>
			
			<p>На другий склад падає наголос у слові &laquo;<em>котр<strong>&uacute;</strong>й</em>&raquo; (а не &laquo;<em>к<strong>&oacute;</strong>трий</em>&raquo;, як часто вимовляють).</p>
			
			<p>На третьому складі треба наголошувати слова &laquo;<em>кілом<strong>&eacute;</strong>тр</em>&raquo; (а не &laquo;<em>кіл<strong>&oacute;</strong>метр</em>&raquo;), &laquo;<em>один<strong>&aacute;</strong>дцять</em>&raquo; (а не &laquo;<em>од<strong>&uacute;</strong>надцять</em>&raquo;), &laquo;<em>привезт<strong>&uacute;</strong></em>&raquo; (а не &laquo;<em>прив<strong>&eacute;</strong>зти</em>&raquo;).</p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 157. Завдання: <b>7717</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_8257" style="display:none;" id="q16">
			<div class="counter">Завдання 16 з 37</div>
			<form class="q-test" id="q_form_16" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="16">
			<input type="hidden" name="q[tip]" id="q16-tip" value="1">
			<input type="hidden" name="q[id]" value="8257">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			Другий склад наголошений у слові
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>обранець</div><div class="answer"><span class="marker">Б</span>недруг</div><div class="answer"><span class="marker">В</span>відгомін</div><div class="answer"><span class="marker">Г</span>приятель</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_8257" onclick="showComment(8257)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_8257" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА:</strong> <strong>Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок. У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно вимовляти наведені слова треба так: <em>обр<strong>А</strong>нець </em>(а не <em>обран<strong>Е</strong>ць</em>)<em>, н<strong>Е</strong>друг (</em>а не<em> недр<strong>У</strong>г), в<strong>І</strong>дгомін (</em>а не<em> відг<strong>О</strong>мін), пр<strong>И</strong>ятель (</em>а не<em> при<strong>Я</strong>тель).</em></p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 168. Завдання: <b>8257</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_8616" style="display:none;" id="q17">
			<div class="counter">Завдання 17 з 37</div>
			<form class="q-test" id="q_form_17" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="17">
			<input type="hidden" name="q[tip]" id="q17-tip" value="1">
			<input type="hidden" name="q[id]" value="8616">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Правильно підкреслено літеру на позначення наголошеного звука в слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>дочк<strong><span style="text-decoration: underline;">а</span></strong></div><div class="answer"><span class="marker">Б</span>завданн<strong><span style="text-decoration: underline;">я</span></strong></div><div class="answer"><span class="marker">В</span>н<strong><span style="text-decoration: underline;">о</span></strong>вий</div><div class="answer"><span class="marker">Г</span>р<strong><span style="text-decoration: underline;">о</span></strong>блю</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_8616" onclick="showComment(8616)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_8616" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання традиційно пропонують часто вживані&nbsp;слова, у яких трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>дочк<strong>А</strong>, завд<strong>А</strong>ння, нов<strong>И</strong>й, робл<strong>Ю</strong></em>.</p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 175. Завдання: <b>8616</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_8737" style="display:none;" id="q18">
			<div class="counter">Завдання 18 з 37</div>
			<form class="q-test" id="q_form_18" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="18">
			<input type="hidden" name="q[tip]" id="q18-tip" value="1">
			<input type="hidden" name="q[id]" value="8737">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Позначте рядок, у якому в усіх словах наголошений другий склад:</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>дочка, подруга, вимова, гуртожиток, русло</div><div class="answer"><span class="marker">Б</span>новий, спина, виразно, завдання, попереду</div><div class="answer"><span class="marker">В</span>предмет, рукопис, ненавидіти, фартух, в’язкий</div><div class="answer"><span class="marker">Г</span>середина, дефіс, старий, горошина, каталог</div><div class="answer"><span class="marker">Д</span>легкий, олень, несла, добуток, партер</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_8737" onclick="showComment(8737)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_8737" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><b>ТЕМА: Орфоепія</b></p>
			
			<p>Це завдання перевіряє ваші вміння правильно наголошувати слова.</p>
			
			<p>В усіх словах наголошений другий склад у рядку <em><b>В</b></em>: <i>предм</i><b><i>е</i></b><i>т, рук</i><b><i>о</i></b><i>пис, нен</i><b><i>а</i></b><i>видіти, фарт</i><b><i>у</i></b><i>х, в&rsquo;язк</i><b><i>и</i></b><i>й</i>.</p>
			
			<p>В інших варіантах слова мають такі наголоси:</p>
			
			<ul>
				<li><i>дочк</i><b><i>а</i></b><i>, п</i><b><i>о</i></b><i>друга, вим</i><b><i>о</i></b><i>ва, гурт</i><b><i>о</i></b><i>житок, русл</i><b><i>о</i></b><i>; </i></li>
				<li><i>нов</i><b><i>и</i></b><i>й, сп</i><b><i>и</i></b><i>на, вир</i><b><i>а</i></b><i>зно, завд</i><b><i>а</i></b><i>ння, поп</i><b><i>е</i></b><i>реду; </i></li>
				<li><i>сер</i><b><i>е</i></b><i>дина, деф</i><b><i>і</i></b><i>с, стар</i><b><i>и</i></b><i>й, горош</i><b><i>и</i></b><i>на, катал</i><b><i>о</i></b><i>г; </i></li>
				<li><i>легк</i><b><i>и</i></b><i>й, </i><b><i>о</i></b><i>лень, несл</i><b><i>а</i></b><i>, доб</i><b><i>у</i></b><i>ток, парт</i><b><i>е</i></b><i>р</i>.</li>
			</ul>
			
			<p><b>Відповідь &ndash; В.</b></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 177. Завдання: <b>8737</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=6 --> 
			<div class="task-card card_9992" style="display:none;" id="q19">
			<div class="counter">Завдання 19 з 37</div>
			<form class="q-test" id="q_form_19" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="19">
			<input type="hidden" name="q[tip]" id="q19-tip" value="1">
			<input type="hidden" name="q[id]" value="9992">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>однаковий</div><div class="answer"><span class="marker">Б</span>добовий</div><div class="answer"><span class="marker">В</span>щовесни</div><div class="answer"><span class="marker">Г</span>сантиметр</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_9992" onclick="showComment(9992)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q6" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_9992" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання традиційно пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>однАковий, добовИй, щовеснИ, сантимЕтр.</em></p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 203. Завдання: <b>9992</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_10160" style="display:none;" id="q20">
			<div class="counter">Завдання 20 з 37</div>
			<form class="q-test" id="q_form_20" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="20">
			<input type="hidden" name="q[tip]" id="q20-tip" value="1">
			<input type="hidden" name="q[id]" value="10160">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>центнер</div><div class="answer"><span class="marker">Б</span>селянин</div><div class="answer"><span class="marker">В</span>перепис</div><div class="answer"><span class="marker">Г</span>листопад</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_10160" onclick="showComment(10160)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_10160" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>цЕнтнер, селянИн, перЕпис, листопАд.</em></p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 206. Завдання: <b>10160</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=2 --> 
			<div class="task-card card_11673" style="display:none;" id="q21">
			<div class="counter">Завдання 21 з 37</div>
			<form class="q-test" id="q_form_21" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="21">
			<input type="hidden" name="q[tip]" id="q21-tip" value="1">
			<input type="hidden" name="q[id]" value="11673">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			На перший склад падає наголос у слові 
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>цінник </div><div class="answer"><span class="marker">Б</span>течія </div><div class="answer"><span class="marker">В</span>русло</div><div class="answer"><span class="marker">Г</span>випадок</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_11673" onclick="showComment(11673)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q2" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_11673" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>ціннИк, течіЯ, руслО, вИпадок.</em></p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 240. Завдання: <b>11673</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_12405" style="display:none;" id="q22">
			<div class="counter">Завдання 22 з 37</div>
			<form class="q-test" id="q_form_22" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="22">
			<input type="hidden" name="q[tip]" id="q22-tip" value="1">
			<input type="hidden" name="q[id]" value="12405">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			На третій склад падає наголос у слові
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>каталог </div><div class="answer"><span class="marker">Б</span>завдання </div><div class="answer"><span class="marker">В</span>феномен  </div><div class="answer"><span class="marker">Г</span>камбала</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12405" onclick="showComment(12405)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12405" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання традиційно пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>каталОг, завдАння, фенОмен, кАмбала.</em></p>
			
			<p><strong>Відповідь &ndash; А. </strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 254. Завдання: <b>12405</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_13725" style="display:none;" id="q23">
			<div class="counter">Завдання 23 з 37</div>
			<form class="q-test" id="q_form_23" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="23">
			<input type="hidden" name="q[tip]" id="q23-tip" value="1">
			<input type="hidden" name="q[id]" value="13725">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>щавель </div><div class="answer"><span class="marker">Б</span>злегка </div><div class="answer"><span class="marker">В</span>жаркий </div><div class="answer"><span class="marker">Г</span>звести</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_13725" onclick="showComment(13725)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_13725" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <strong><em>щавЕль, злЕгка, жаркИй, звестИ.</em></strong></p>
			
			<p><strong>Відповідь &ndash; Б.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 281. Завдання: <b>13725</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_14633" style="display:none;" id="q24">
			<div class="counter">Завдання 24 з 37</div>
			<form class="q-test" id="q_form_24" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="24">
			<input type="hidden" name="q[tip]" id="q24-tip" value="1">
			<input type="hidden" name="q[id]" value="14633">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			На другий склад падає наголос у слові
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>позначка </div><div class="answer"><span class="marker">Б</span>центнер </div><div class="answer"><span class="marker">В</span>довідник </div><div class="answer"><span class="marker">Г</span>каталог</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14633" onclick="showComment(14633)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14633" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>п<strong>О</strong>значка,ц<strong>Е</strong>нтнер, дов<strong>І</strong>дник, катал<strong>О</strong>г.</em></p>
			
			<p>Учасникам ЗНО рекомендовано перелік слів з наголосами. Цей своєрідний словник наголосів було розміщено на сайті Міністерства освіти і науки, також він був уміщений у посібник &laquo;Українська мова та література. Довідник. Завдання в тестовій формі. І частина&raquo;, автори &ndash; О.&nbsp;М.&nbsp;Авраменко, М. Б. Блажко (2018).</p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 299. Завдання: <b>14633</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_15181" style="display:none;" id="q25">
			<div class="counter">Завдання 25 з 37</div>
			<form class="q-test" id="q_form_25" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="25">
			<input type="hidden" name="q[tip]" id="q25-tip" value="1">
			<input type="hidden" name="q[id]" value="15181">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			На другий склад падає наголос у слові
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>читання </div><div class="answer"><span class="marker">Б</span>солодощі </div><div class="answer"><span class="marker">В</span>обіцянка </div><div class="answer"><span class="marker">Г</span>донька</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_15181" onclick="showComment(15181)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_15181" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>с<strong>О</strong>лодощі, обіц<strong>Я</strong>нка, д<strong>О</strong>нька, чит<strong>А</strong>ння. </em></p>
			
			<p>У цьому році вперше учасникам ЗНО було рекомендовано перелік слів з наголосами. Цей своєрідний словник наголосів було надруковано в журналі &laquo;Дивослово&raquo; та розміщено в Інтернеті (наприклад: <a href="http://xn--80aafnzkijm.xn--j1amh/main/520-korotkiy-slovnik-nagolosv.html">http://xn--80aafnzkijm.xn--j1amh/main/520-korotkiy-slovnik-nagolosv.html</a>).</p>
			
			<p><strong>Відповідь &ndash; А.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 309. Завдання: <b>15181</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_16483" style="display:none;" id="q26">
			<div class="counter">Завдання 26 з 37</div>
			<form class="q-test" id="q_form_26" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="26">
			<input type="hidden" name="q[tip]" id="q26-tip" value="1">
			<input type="hidden" name="q[id]" value="16483">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>начинка </div><div class="answer"><span class="marker">Б</span>позначка </div><div class="answer"><span class="marker">В</span>травестія </div><div class="answer"><span class="marker">Г</span>рівнина</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_16483" onclick="showComment(16483)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_16483" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Правильно наголошені слова треба вимовляти так: <em>н<strong>А</strong>чинка, п<strong>О</strong>значка, травест<strong>І</strong>я, рівн<strong>И</strong>на. </em></p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 335. Завдання: <b>16483</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_17094" style="display:none;" id="q27">
			<div class="counter">Завдання 27 з 37</div>
			<form class="q-test" id="q_form_27" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="27">
			<input type="hidden" name="q[tip]" id="q27-tip" value="1">
			<input type="hidden" name="q[id]" value="17094">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у всіх словах, ОКРІМ</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>причіп </div><div class="answer"><span class="marker">Б</span>косий </div><div class="answer"><span class="marker">В</span>жалюзі</div><div class="answer"><span class="marker">Г</span>випадок</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_17094" onclick="showComment(17094)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_17094" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. У 2018 році вперше учасникам ЗНО було рекомендовано <a href="http://osvita.ua/test/advice/65116/" target="_blank">перелік слів з наголосами</a>. Цей своєрідний словник розміщено в <a href="http://osvita.ua/test/program_zno/946/" target="_blank">програмі ЗНО</a>.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>пр<strong>И</strong>чіп, ,к<strong>О</strong>сий, в<strong>И</strong>падок, жалюз<strong>І</strong>.</em></p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 347. Завдання: <b>17094</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_17936" style="display:none;" id="q28">
			<div class="counter">Завдання 28 з 37</div>
			<form class="q-test" id="q_form_28" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="28">
			<input type="hidden" name="q[tip]" id="q28-tip" value="1">
			<input type="hidden" name="q[id]" value="17936">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>віршовий </div><div class="answer"><span class="marker">Б</span>підлітковий </div><div class="answer"><span class="marker">В</span>корисний </div><div class="answer"><span class="marker">Г</span>фаховий</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_17936" onclick="showComment(17936)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_17936" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують&nbsp;часто вживані слова, у яких трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>віршовИй, пІдлітковий, корИсний, фаховИй.</em></p>
			
			<p>Учасникам ЗНО було рекомендовано&nbsp;перелік слів з наголосами. Цей своєрідний словник є в <a href="http://osvita.ua/doc/files/news/10/1006/History.pdf">Програмі зовнішнього незалежного оцінювання з української мови</a>.</p>
			
			<p><strong>Відповідь &ndash; Б.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 363. Завдання: <b>17936</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_19309" style="display:none;" id="q29">
			<div class="counter">Завдання 29 з 37</div>
			<form class="q-test" id="q_form_29" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="29">
			<input type="hidden" name="q[tip]" id="q29-tip" value="1">
			<input type="hidden" name="q[id]" value="19309">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>бешкет</div><div class="answer"><span class="marker">Б</span>вимога </div><div class="answer"><span class="marker">В</span>колесо </div><div class="answer"><span class="marker">Г</span>донька</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_19309" onclick="showComment(19309)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_19309" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>б<strong>Е</strong>шкет, вим<strong>О</strong>га, к<strong>О</strong>лесо, д<strong>О</strong>нька. </em></p>
			
			<p>Учасникам&nbsp;ЗНО рекомендовано перелік слів з наголосами (уміщений наприкінці <a href="http://osvita.ua/test/program_zno/946/">Програми ЗНО</a>).</p>
			
			<p><strong>Відповідь &ndash; Б.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 389. Завдання: <b>19309</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=6 --> 
			<div class="task-card card_19985" style="display:none;" id="q30">
			<div class="counter">Завдання 30 з 37</div>
			<form class="q-test" id="q_form_30" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="30">
			<input type="hidden" name="q[tip]" id="q30-tip" value="1">
			<input type="hidden" name="q[id]" value="19985">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			На перший склад падає наголос у слові
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>текстовий </div><div class="answer"><span class="marker">Б</span>зручний </div><div class="answer"><span class="marker">В</span>визвольний </div><div class="answer"><span class="marker">Г</span>фаховий</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_19985" onclick="showComment(19985)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q6" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_19985" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені і ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок. У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <em>фаховИй, текстовИй, зрУчний, визвОльний. </em></p>
			
			<p>У 2018 році вперше учасникам ЗНО було рекомендовано перелік слів з наголосами.</p>
			
			<p>Цей своєрідний словник є в <a href="http://osvita.ua/test/program_zno/946/">програмі зовнішнього незалежного оцінювання</a>.</p>
			
			<p><strong>Відповідь &ndash; Б</strong>.</p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 401. Завдання: <b>19985</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=6 --> 
			<div class="task-card card_21247" style="display:none;" id="q31">
			<div class="counter">Завдання 31 з 37</div>
			<form class="q-test" id="q_form_31" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="31">
			<input type="hidden" name="q[tip]" id="q31-tip" value="1">
			<input type="hidden" name="q[id]" value="21247">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>листопад </div><div class="answer"><span class="marker">Б</span>поняття </div><div class="answer"><span class="marker">В</span>вантажівка </div><div class="answer"><span class="marker">Г</span>горошина</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_21247" onclick="showComment(21247)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q6" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_21247" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені і ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: понЯття, вантажІвка, горошИна, листопАд.</p>
			
			<p>У <a href="http://osvita.ua/test/program_zno/946/">програмі ЗНО</a> учасникам рекомендовано перелік слів з наголосами.</p>
			
			<p><strong>Відповідь &ndash; Б.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 429. Завдання: <b>21247</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_21817" style="display:none;" id="q32">
			<div class="counter">Завдання 32 з 37</div>
			<form class="q-test" id="q_form_32" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="32">
			<input type="hidden" name="q[tip]" id="q32-tip" value="1">
			<input type="hidden" name="q[id]" value="21817">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Прочитайте речення (<em>цифра позначає наступне слово</em>).</p>
			
			<p><strong><em>(1)</em></strong><em>Чотирн<strong><u>а</u></strong>дцятого <strong>(2)</strong>лист<strong><u>о</u></strong>пада трапився курйозний <strong>(3)</strong>вип<strong><u>а</u></strong>док: <strong>(4)</strong>мер<strong><u>е</u></strong>жа магазинів <strong>(5)</strong>&laquo;Р<strong><u>е</u></strong>шето&raquo; продала покупцям цілий <strong>(6)</strong>центн<strong><u>е</u></strong>р <strong>(7)</strong>к<strong><u>у</u></strong>рятини всього за <strong>(8)</strong>сімдес<strong><u>я</u></strong>т гривень, про що свідчив <strong>(9)</strong>в<strong><u>и</u></strong>разний <strong>(10)</strong>цінн<strong><u>и</u></strong>к.</em></p>
			
			<p>НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>1,3,6,8 </div><div class="answer"><span class="marker">Б</span>1,4, 7,10 </div><div class="answer"><span class="marker">В</span>2,3,6,9 </div><div class="answer"><span class="marker">Г</span>2,4,5,10</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_21817" onclick="showComment(21817)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_21817" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок. У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Учасникам ЗНО рекомендовано <a href="https://osvita.ua/test/program_zno/946/">перелік слів з наголосами</a>.</p>
			
			<p>У демонстраційному тесті це завдання дещо іншої форми, як було в минулих сертифікаційних роботах: слова, у яких потрібно перевірити правильність наголосу, утворюють речення.</p>
			
			<p>У запропонованому реченні неправильно підкреслено літери на позначення наголошених голосних у таких словах: <em>лист<u>о</u>пада, вип<u>а</u>док, центн<u>е</u>р, в<u>и</u>разний</em> (правильні наголоси такі: <em>листоп<strong><u>а</u></strong>да, в<strong><u>и</u></strong>падок, ц<strong><u>е</u></strong>нтнер, вир<strong><u>а</u></strong>зний</em>).</p>
			
			<p><strong>Відповідь &ndash; В.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 436. Завдання: <b>21817</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_22755" style="display:none;" id="q33">
			<div class="counter">Завдання 33 з 37</div>
			<form class="q-test" id="q_form_33" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="33">
			<input type="hidden" name="q[tip]" id="q33-tip" value="1">
			<input type="hidden" name="q[id]" value="22755">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Прочитайте речення (цифра позначає наступне слово).</p>
			
			<p><em>Психологиня, (1)доньк<b><u>а</u></b> моєї (2)п<b><u>о</u></b>други, пообіцяла (3)прин<b><u>е</u></b>сти (4)чергов<b><u>и</u></b>й&nbsp;(5)ф<b><u>а</u></b>ховий журнал, де зробила (6)п<b><u>о</u></b>значки щодо цікавих (7)в<b><u>и</u></b>падків (8)п<b><u>і</u></b>дліткових (9)уподоб<b><u>а</u></b>нь.</em></p>
			
			<p><br />
			НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>1, 4, 6, 9</div><div class="answer"><span class="marker">Б</span>2, 3, 5, 7</div><div class="answer"><span class="marker">В</span>1, 3, 5, 9</div><div class="answer"><span class="marker">Г</span>2, 4, 6, 8</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_22755" onclick="showComment(22755)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_22755" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><b>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</b></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. У цьому завданні такі слова запропоновано в реченні, адже наголос має значеннєво-розрізнювальну функцію, важливий для мовців лише в контексті.&nbsp;</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <i>дОнька, принестИ, фаховИх, уподОбань. </i></p>
			
			<p>Учасникам ЗНО рекомендовано перелік слів з наголосами. Цей своєрідний словник є в <a href="http://osvita.ua/test/program_zno/946/">Програмі зовнішнього незалежного оцінювання</a>.</p>
			
			<p><b>Відповідь &ndash; В.</b></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 452. Завдання: <b>22755</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_23722" style="display:none;" id="q34">
			<div class="counter">Завдання 34 з 37</div>
			<form class="q-test" id="q_form_34" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="34">
			<input type="hidden" name="q[tip]" id="q34-tip" value="1">
			<input type="hidden" name="q[id]" value="23722">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Прочитайте речення <em>(цифра позначає наступне слово).</em></p>
			
			<p><strong><em>(1)</em></strong><em>Відг<strong><u>о</u></strong>мін перелітних птахів, глибокі <strong>(2)</strong>к<strong><u>о</u></strong>лії на розмитому дощами <strong>(3)</strong>чорноз<strong><u>е</u></strong>мі, перший <strong>(4)</strong>пр<strong><u>и</u></strong>морозок, <strong>(5)</strong>бурштин<strong><u>о</u></strong>ве й багряне листя, струшене <strong>(6)</strong>листоп<strong><u>а</u></strong>дом, &ndash; усе це <strong>(7)<u>о</u></strong>знаки <strong>(8)</strong>чарівн<strong><u>о</u></strong>ї осені.</em></p>
			
			<p>НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами</p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>1, 3, 7</div><div class="answer"><span class="marker">Б</span>4, 5, 8</div><div class="answer"><span class="marker">В</span>1, 2, 6</div><div class="answer"><span class="marker">Г</span>4, 7, 8</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_23722" onclick="showComment(23722)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_23722" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><b>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</b></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Учасникам ЗНО рекомендовано <a href="https://osvita.ua/test/advice/65116/">перелік</a> таких слів з наголосами.</p>
			
			<p>У запропонованому реченні неправильно підкреслено літери на позначення наголошених голосних у таких словах: <em>відгомін, чорноземі, ознаки</em> (правильні наголоси такі: <em>в<u><b>і</b></u>дгомін, чорн<u><b>о</b></u>земі, озн<u><b>а</b></u>ки</em>)</p>
			
			<p><b>Відповідь &ndash; А.</b></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 471. Завдання: <b>23722</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_24779" style="display:none;" id="q35">
			<div class="counter">Завдання 35 з 37</div>
			<form class="q-test" id="q_form_35" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="35">
			<input type="hidden" name="q[tip]" id="q35-tip" value="1">
			<input type="hidden" name="q[id]" value="24779">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>
			        Прочитайте речення (цифра позначає наступне слово).
			    </p>
			    <p>
			        <i>Ще в (<b>1</b>)п<b><u>і</u></b>длітковому віці (<b>2</b>)впод<b><u>о</u></b>баннями Андрія були (<b>3</b>)ч<b><u>и</u></b>тання (<b>4</b>)довідник<b><u>і</u></b>в, (<b>5</b>)фахов<b><u>и</u></b>х журналів з історії та пошук (<b>6</b>)від<b><u>о</u></b>мостей про (<b>7</b>)укра<b><u>ї</u></b>нський (<b>8</b>)в<b><u>и</u></b>звольний рух.</i>
			    </p>
			    <p>
			    НЕПРАВИЛЬНО підкреслено букви на позначення наголошених голосних у всіх словах, позначених цифрами
			    </p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>1 ,4, 7</div><div class="answer"><span class="marker">Б</span>3 ,5, 6</div><div class="answer"><span class="marker">В</span>1, 2, 8</div><div class="answer"><span class="marker">Г</span>3, 4, 8</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_24779" onclick="showComment(24779)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_24779" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади</strong></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Учасникам ЗНО рекомендовано <a href="https://osvita.ua/test/advice/65116/">перелік слів з наголосами</a>.</p>
			
			<p>У запропонованому реченні неправильно підкреслено літери на позначення наголошених голосних у таких словах: <em>ч</em><i><b><u>и</u></b></i><em>тання, довідник</em><i><b><u>і</u></b></i><em>в, в</em><i><b><u>и</u></b></i><em>звольний</em> (правильні наголоси такі:<em> чит<strong><u>а</u></strong>ння, дов<strong><u>і</u></strong>дників, визв<strong><u>о</u></strong>льний</em>).</p>
			
			<p><strong>Відповідь &ndash; Г.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 491. Завдання: <b>24779</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_25978" style="display:none;" id="q36">
			<div class="counter">Завдання 36 з 37</div>
			<form class="q-test" id="q_form_36" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="36">
			<input type="hidden" name="q[tip]" id="q36-tip" value="1">
			<input type="hidden" name="q[id]" value="25978">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На другий склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>начинка</div><div class="answer"><span class="marker">Б</span>випадок</div><div class="answer"><span class="marker">В</span>дрова</div><div class="answer"><span class="marker">Г</span>загадка</div><div class="answer"><span class="marker">Д</span>русло</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_25978" onclick="showComment(25978)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_25978" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><strong>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</strong></p>
			
			<p>Завдання скеровано на перевірку орфоепічних навичок.</p>
			
			<p>У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують поширені слова, у яких часто трапляються помилки в наголошуванні. Готуючись до НМТ, <strong>опрацюйте перелік слів із нормативним наголосом</strong>, наведений у додатку до Програми ЗНО з української мови.</p>
			
			<p>Правильно наголошені слова треба вимовляти так:&nbsp;<em>нАчинка, вИпадок, дрОва, зАгадка, руслО.</em></p>
			
			<p><strong>Відповідь:</strong>&nbsp;<strong>Д.</strong></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 515. Завдання: <b>25978</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_26098" style="display:none;" id="q37">
			<div class="counter">Завдання 37 з 37</div>
			<form class="q-test" id="q_form_37" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="37">
			<input type="hidden" name="q[tip]" id="q37-tip" value="1">
			<input type="hidden" name="q[id]" value="26098">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>На перший склад падає наголос у слові</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			<div class="answer"><span class="marker">А</span>зручний</div><div class="answer"><span class="marker">Б</span>проміжок</div><div class="answer"><span class="marker">В</span>перекис</div><div class="answer"><span class="marker">Г</span>експерт</div><div class="answer"><span class="marker">Д</span>фаховий</div>
			</div>
			
			
			
			
			<div class="clear mb10"></div>
			
			<div class="select-answers-title">Позначте відповіді:</div>
				
			<table class="select-answers-variants">
			<tr>
			<th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<td><label><input type="radio" value="a" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="b" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="c" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="d" name="a" class="q-radio" /><span class="marker"></span></label></td><td><label><input type="radio" value="e" name="a" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
							<span class="q-btn button-gray explan_open" id="btn_show_26098" onclick="showComment(26098)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final">Завершити тест</span>
						</div>
			</div>
			 
				<input type="hidden" id="do-q5" name="do" value="result" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_26098" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><b>ТЕМА: Орфоепія. Наголос, наголошені й ненаголошені склади.</b></p>
			
			<p>Завдання перевіряє рівень ваших орфоепічних навичок. У подібних завданнях зовнішнього незалежного оцінювання завжди пропонують слова, у яких часто трапляються помилки в наголошуванні.</p>
			
			<p>Правильно наголошені слова треба вимовляти так: <i>зрУчний, промІжок, перЕкис, екпЕрт, фаховИй.</i></p>
			
			<p>Учасникам ЗНО / НМТ рекомендовано певний&nbsp;перелік слів з наголосами. Цей своєрідний словник наголосів розміщено в нашій <a href="https://osvita.ua/test/advice/65116/">публікації</a>.</p>
			
			<p><b>Відповідь &ndash; А.</b></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 519. Завдання: <b>26098</b></div>
			</div>
			
			
			
			
			<script type="text/javascript">
			window.onload = function() {
				if( window.zStat ){ zStat(); }
				setTimeout(function(){ if( getCookie('osname') === undefined ){$('.explanation').html('<p>Коментарі для зареєстрованих користувачів!</p>').hide();} }, 10000);
			}
			</script>
			
			
			
			
			<div class="links-card links">
			<div class="links-header">Інформація</div>
			<ul class="links">
			<li><a href="https://zno.osvita.ua/ukrainian/tema.html" title="Усі завдання ЗНО з української мови і літератури за темами" target="_blank">Усі завдання ЗНО з української мови і літератури за темами</a></li>
			<li><a href="https://zno.osvita.ua/ukrainian/" title="Усі тести ЗНО з української мови і літератури онлайн" target="_blank">Усі тести ЗНО з української мови і літератури онлайн</a></li>
			<li><a href="http://osvita.ua/test/answers/ukr-mova.html" title="Завдання й відповіді ЗНО з української мови і літератури минулих років" target="_blank">Завдання й відповіді ЗНО з української мови і літератури минулих років</a></li>
			<li><a href="http://bit.ly/2UDhes9" title="Усе про тест ЗНО з української мови і літератури" target="_blank">Усе про тест ЗНО з української мови і літератури</a></li>
			<li><a href="http://osvita.ua/test/program_zno/946/" title="Програма ЗНО з української мови і літератури" target="_blank">Програма ЗНО з української мови і літератури</a></li>
			<li><a href="http://bit.ly/2UFXSTo" title="Усе про власне висловлення на ЗНО з української мови" target="_blank">Усе про власне висловлення на ЗНО з української мови</a></li>
			<li><a href="http://osvita.ua/test/training/ptyklad-vv/" title="Приклади написання власного висловлення з української мови" target="_blank">Приклади написання власного висловлення з української мови</a></li>
			<li><a href="https://osvita.ua/test/57770/" title="Перелік творів ЗНО з української літератури" target="_blank">Перелік творів ЗНО з української літератури</a></li>
			<li><a href="http://osvita.ua/test/training/skorocheni-tvory/" title="Скорочені версії творів ЗНО з української літератури" target="_blank">Скорочені версії творів ЗНО з української літератури</a></li>
			<li><a href="http://bit.ly/37w2bSF" title="Подкасти для підготовки до ЗНО з української літератури" target="_blank">Подкасти для підготовки до ЗНО з української літератури</a></li>
			<li><a href="http://zno.osvita.ua/" title="Тести ЗНО онлайн з інших предметів" target="_blank">Тести ЗНО онлайн з інших предметів</a></li>
			<li><a href="http://osvita.ua/test/advice/" title="Дорожня карта учасника ЗНО" target="_blank">Дорожня карта учасника ЗНО</a></li>
			<li><a href="https://osvita.ua/consultations/bachelor/" title="Дорожня карта вступника на бакалавра" target="_blank">Дорожня карта вступника на бакалавра</a></li>
			<li><a href="https://zno.osvita.ua/ukrainian/tema.html" title="Українська мова і література: завдання за темами" target="_blank">Українська мова і література: завдання за темами</a></li>
			</ul>
			</div>
			
			<!--noindex-->
			<div id="soc2" class="all social-likes">
				<div class="facebook" title="Поділитися посиланням у Фейсбук">Facebook</div>
				<div class="twitter" data-via="Osvita" title="Поділитися посиланням у Твіттері">Twitter</div>
			</div>
			<!--/noindex-->
			
			<div class="clear"></div>
			<div class="clear"></div>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- zno_quest_list_by_tag_all 0.33088 c. -->
			
			
			<!-- banners - banner_multimob - 1969 -->
			<!--noindex-->
			<div class="banner-wrapper">
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?141101.1664532469"  border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?141101.1669048925"  border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?141101.1669049035"  border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?141101.1668508411"  border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?141101.1671209018"  border="0" alt=""></a>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner_multimob 0.00063 c. -->
			
			
			<!-- banners - banner620 - 1970 -->
			<!-- id=5 -->
			<!--noindex-->
			<div class="artbanner videoad w620 hauto txtcntr">
			<div class="txtcntr">
			<center>
			<div id='admixer_b192d298027042deada9da507fa129f8_zone_1010_sect_226_site_226'></div><script type='text/javascript' src='https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=87252397-7105-4764-a755-8652df76a6e3'></script>
			
			</center>
			</div>
			</div>
			<div class="clear"></div>
			<!--/noindex-->
			
			<!-- banner620 0.00045 c. -->
			
			
			<!-- znotest - fb_comments - 1971 -->
			<div class="clear"></div>
			
			<div class="bcont">
			<div class="fb-comments" data-href="https://zno.osvita.ua/ukrainian/tag-sklad_nagolos/" data-width="620" data-numposts="10"></div>
			</div>
			
			<div class="clear"></div>
			<!-- fb_comments 0.00015 c. -->
			
			
			            </div>
			            <div class="col-right homepage-right-hide">
						
			<!-- banners - banner_multi_300 - 1972 -->
			<!--noindex-->
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?141101.1664532469" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?141101.1669048925" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?141101.1669049035" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?141101.1668508411" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?141101.1671209018" width="300" height="100" border="0" alt=""></a>
			</div>
			<!--/noindex-->
			<!-- banner_multi_300 0.00148 c. -->
			
			
			<!-- banners - banner300 - 1973 -->
			<!--noindex-->
			<div class="block w300 wrapbanner" style="height:600px;">
			<div class="banner" style="height:600px;">
			<!-- id=1 -->
			<div id='admixer_741839645c2346e68867b1f3f0e96a5e_zone_20646_sect_226_site_226'></div><script type='text/javascript' src='https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=74a1f9e1-65c3-4075-a988-90d4b6350625'></script>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner300 0.00052 c. -->
			
			
						<div class="clear"></div>
			            </div>
			            <div class="hr-line-wrapper">
			                <div class="hr-line"></div>
			            </div>
			        </div>
				</div>
				
			    <div class="container">
			        <div id="footer" class="footer">
			            <div class="col-footer-left">
			                <div class="copyright">
			                    &copy;&nbsp;2007&ndash;2023 «Освіта.ua».<br>
			                    Сайт "ЗНО-ОНЛАЙН" створений та підтримується інтернет-ресурсом "Освіта.ua"<br>
			                    <a href="https://osvita.ua/advert.html">Реклама на сайті</a><br>
								<a href="https://zno.osvita.ua/agreement.html" target="_blank">Угода користувача</a>
			                </div>
			            </div>
			            <div class="col-footer-right">
			                E-mail: <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> <br>
			                Соціальні мережі: <br>
							<a href="https://www.facebook.com/abiturients/">Ми у Facebook</a>&nbsp; &nbsp; 
							<a href="https://t.me/vstuposvita">Ми у Telegram</a><br>
							
			<div class="counter bigmir">
			
			
			<!--bigmir)net TOP 100-->
			<script type="text/javascript" language="javascript"><!--
			bmN=navigator,bmD=document,bmD.cookie='b=b',i=0,bs=[],bm={v:16796306,s:16796306,t:29,c:bmD.cookie?1:0,n:Math.round((Math.random()* 1000000)),w:0};
			for(var f=self;f!=f.parent;f=f.parent)bm.w++;
			try{if(bmN.plugins&&bmN.mimeTypes.length&&(x=bmN.plugins['Shockwave Flash']))bm.m=parseInt(x.description.replace(/([a-zA-Z]|\s)+/,''));
			else for(var f=3;f<20;f++)if(eval('new ActiveXObject("ShockwaveFlash.ShockwaveFlash.'+f+'")'))bm.m=f}catch(e){;}
			try{bm.y=bmN.javaEnabled()?1:0}catch(e){;}
			try{bmS=screen;bm.v^=bm.d=bmS.colorDepth||bmS.pixelDepth;bm.v^=bm.r=bmS.width}catch(e){;}
			r=bmD.referrer.replace(/^w+:\/\//,'');if(r&&r.split('/')[0]!=window.location.host){bm.f=escape(r).slice(0,400);bm.v^=r.length}
			bm.v^=window.location.href.length;for(var x in bm) if(/^[vstcnwmydrf]$/.test(x)) bs[i++]=x+bm[x];
			bmD.write('<a href="http://www.bigmir.net/" target="_blank" onClick="img=new Image();img.src="//www.bigmir.net/?cl=16796306";"><img src="//c.bigmir.net/?'+bs.join('&')+'"  width="160" height="19" border="0" alt="bigmir)net TOP 100" title="bigmir)net TOP 100"></a>');
			//-->
			</script>
			<noscript>
			<a href="http://www.bigmir.net/" target="_blank"><img src="//c.bigmir.net/?v16796306&s16796306&t29" width="160" height="19" alt="bigmir)net TOP 100" title="bigmir)net TOP 100" border="0" /></a>
			</noscript>
			<!--bigmir)net TOP 100-->
			
			
			</div> 
			            </div>
			        </div>
			    </div>
			
			
			
			
			    <div class="modal">
			        <div class="modal-content">
			            <span class="close-button">×</span>
			            <div class="title">Вхід</div>
						<form action="/users/?do=login" method="post">
			            <div class="auth-block">
			                <div id="floatContainer01" class="email-block float-container">
			                    <label for="floatField01">Email</label>
			                    <input type="email" name="email" id="floatField01" data-placeholder="">
			                </div>
			                <div id="floatContainer02" class="email-block float-container">
			                    <label for="floatField02">Пароль</label>
			                    <input type="password" name="pass" id="floatField02" data-placeholder="">
			                </div>
			            </div>
			            <input type="submit" class="button-green button-green-registry" value="Увійти"><br>
						</form>
			            <a class="restore-password" href="/users/?do=recall">Нагадати пароль!</a>
			            <div class="hr-line"></div>
			            <div class="register-text">
			                Не маєте облікового запису?<br>
			                Зареєструйтеся зараз
			            </div>
			            <a class="button-green" href="/users/?do=register">Зареєструватися</a>
			        </div>
			    </div>
			
			<div class="scroll-up"><div class="clk"></div></div>
			
			
			<!-- тег ремаркетинга Google -->
			<script type="text/javascript">
			/* <![CDATA[ */
			var google_conversion_id = 976915692;
			var google_custom_params = window.google_tag_params;
			var google_remarketing_only = true;
			/* ]]> */
			</script>
			<script type="text/javascript" src="https://www.googleadservices.com/pagead/conversion.js">
			</script>
			<noscript>
			<div style="display:inline;">
			<img height="1" width="1" style="border-style:none;" alt="" src="https://googleads.g.doubleclick.net/pagead/viewthroughconversion/976915692/?value=0&amp;guid=ON&amp;script=0"/>
			</div>
			</noscript>
			
			<!-- банер Rich Media -->
			<div id='admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226'></div>
			<script type="text/javascript">
			    admixerML.fn.push(function () { admixerML.display('admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226'); });
			</script>
			
			<!-- Mobile банер Rich Media -->
			<div id='admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226'></div>
			<script type="text/javascript">
			    admixerML.fn.push(function () { admixerML.display('admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226'); });
			</script>
			
			<!-- link to Premium -->
			<a class="btn_uho nopremium" href="https://bit.ly/34MLWoO" rel="nofollow">ПРЕМІУМ ДОСТУП</a>
			<style>
			.btn_uho{
			display: block;
			position: fixed;
			width: 25px;
			height: 170px;
			background-color: #35866e;
			color:#fff;
			box-shadow: 2px -2px 5px #35876f;
			border-top-left-radius:10px;
			border-bottom-left-radius:10px;
			letter-spacing: 1px;
			writing-mode: vertical-rl;
			line-height: 25px;
			font-size: 16px;
			font-weight: 700;
			text-align: center;
			text-decoration: none;
			padding: 10px;
			left: 0;
			top: 30%;
			transform: rotate(180deg);
			transition: all .2s .1s;
			z-index: 99999;
			}
			.btn_uho:hover{color:#fff;text-decoration:none;box-shadow:3px -3px 6px #35876f;padding:12px 20px 12px 10px;margin-top:-3px;}
			@media screen and (max-width:1000px){.btn_uho{display:none;}}
			</style>
			
			
			
			<script src="https://zno.osvita.ua/doc/js/common.js?v0105"></script>
			<script src="https://zno.osvita.ua/doc/js/social-likes.min.js"></script>
			
			<!-- simple -->
			</body>
			</html>
			<!-- page_id=99 tag | z=0 -->
			<!-- /ukrainian/tag-sklad_nagolos/index.html от 14-01-2023 11:08:19 replace /ukrainian/tag-sklad_nagolos/index.html_1157 -->
			 
			""";
    }
}
