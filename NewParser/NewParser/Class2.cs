using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Class2
    {
        public static string html = """
			<body id="body" class="ukraine-history">
			
			
			 
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
			                    <span class="login nouser" style="display: none;"><a href="/users/?do=login" onclick="return false;" title="Вхід">Вхід</a></span>
			                    <span class="profil isuser" style="display: inline;"><a href="/users/?do=profile" class="username">Профіль</a></span>
			                    <span class="separator"> / </span>
								<span class="logout isuser" style="display: inline;"><a href="/users/?do=logout" onclick="logout();return false;" title="Вхід">Вихід</a></span>
								<span class="register nouser" style="display: none;"><a href="/users/?do=register">Реєстрація</a></span>
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
						
			<!-- news - menu - 1961 -->
					<div class="title-block no-bottom-line">
						<a href="https://zno.osvita.ua" title="ЗНО-ОНЛАЙН"><span class="linkh1">ЗНО-ОНЛАЙН</span></a>
									<div class="description"><h1 class="desc">Завдання за темою з історії України</h1></div>
								</div>
			<div id="breadcrumbs" class="breadcrumbs" vocab="http://schema.org/" typeof="BreadcrumbList">
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="1">
			<a property="item" typeof="WebPage" href="https://zno.osvita.ua"><span property="name">Тести ЗНО онлайн</span></a></span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="2">
			<a href="https://zno.osvita.ua/ukraine-history/tema.html" property="item" typeof="WebPage"><span property="name">Історія України</span></a>
			</span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="3">
			<a href="https://zno.osvita.ua/ukraine-history/tag-korolivstvo_ruske_mongolska_navala/" property="item" typeof="WebPage">
			<meta property="name" content="Завдання за темою з історії України">
			</a>
			<span>Завдання за темою з історії України</span>
			</span>
			<!-- tag --></div>
			
			<!-- curpath = /ukraine-history/tag-korolivstvo_ruske_mongolska_navala/ -->
			
			<!-- menu 0.00362 c. -->
			
			
					</div>
				</div>
				
				<div class="container">
			        <div id="main-content">
			            <div class="col-main">
						
			<!-- znotest - zno_quest_list_by_tag_all - 1962 -->
			<!-- setTitle #### -->
			
			
			<style type="text/css">
			.test-title .label{color: #35866e; font-size:inherit; font-weight:normal;}
			</style>
			
			<script type="text/javascript">
			
			var qfirst = 1;
			var list = 0;
			var cnt = 52;
			var total = 52;
			var test_id = 'tag_149';
			var tag_id = 149;
			var quest_id = 1;
			var section = 4;
			var maxball = 67;
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
			
			
			<div class="q-progress-bar"><div class="q-progress" style="width: 100%;"></div></div>
			<div title="Приховати таймер" class="q-timer"><span class="q-timer-txt"></span></div>
			
			<div class="test-title">
			<span class="label">Кількість завдань:</span>&nbsp;<span class="row">52</span> <!-- 52 -->
			</div>
			
			<div class="tasks-numbers" id="tasks-numbers"><span class="q1 number ">1</span><span class="q2 number ">2</span><span class="q3 number ">3</span><span class="q4 number ">4</span><span class="q5 number ">5</span><span class="q6 number ">6</span><span class="q7 number ">7</span><span class="q8 number ">8</span><span class="q9 number ">9</span><span class="q10 number ">10</span><span class="q11 number ">11</span><span class="q12 number ">12</span><span class="q13 number ">13</span><span class="q14 number ">14</span><span class="q15 number ">15</span><span class="q16 number ">16</span><span class="q17 number ">17</span><span class="q18 number ">18</span><span class="q19 number ">19</span><span class="q20 number ">20</span><span class="q21 number ">21</span><span class="q22 number ">22</span><span class="q23 number ">23</span><span class="q24 number ">24</span><span class="q25 number ">25</span><span class="q26 number ">26</span><span class="q27 number ">27</span><span class="q28 number ">28</span><span class="q29 number ">29</span><span class="q30 number ">30</span><span class="q31 number ">31</span><span class="q32 number ">32</span><span class="q33 number ">33</span><span class="q34 number ">34</span><span class="q35 number ">35</span><span class="q36 number ">36</span><span class="q37 number ">37</span><span class="q38 number ">38</span><span class="q39 number ">39</span><span class="q40 number ">40</span><span class="q41 number ">41</span><span class="q42 number ">42</span><span class="q43 number ">43</span><span class="q44 number ">44</span><span class="q45 number ">45</span><span class="q46 number ">46</span><span class="q47 number ">47</span><span class="q48 number ">48</span><span class="q49 number ">49</span><span class="q50 number ">50</span><span class="q51 number ">51</span><span class="q52 number bad">52</span><span class="num_all" onclick="questExp(); return false;">&nbsp;Всі&nbsp;завдання&nbsp;</span></div>
			
			<div id="waiting" style="display: none;"><center>Зачекайте, йде розрахунок...<br><div id="wait"> </div></center></div>
			<div id="waiting2" style="display:none;"></div>
			
			<div id="wrap">
					
			<!-- 
			сохраню если отвечал дольше 10с.
			сохраню если ответов больше 5%
			все старые записи по тегу удалю.
			 -->
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
			
					<div class="test-bal">Максимальна кількість балів: <strong>67</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
						
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
			<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/ukraine-history/tema.html">до списку тем</a>.</small></em></div>
				</div>
				<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/tag-ukrayina_v_roki_pershoyi_svitovoyi_vijni/?1669654387">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			
			<!-- abc=0 -->
			<div id="q1" class="task-card">
			<div class="counter">Завдання 1</div>
			<div class="question"><p>Перебіг яких подій Першої світової війни відображено на карті?</p><p><img width="325" height="432" src="/doc/images/znotest/7/728/5.png" alt=""></p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Галицької битви (1914 р.)</div><div class="answer"><span class="marker">Б</span>Карпатської операції (1915 р.)</div><div class="answer"><span class="marker">В</span>Горлицької операції (1915 р.)</div><div class="answer"><span class="marker">Г</span>Брусиловського прориву (1916 р.)</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_728" onclick="showComment(728)">Читати коментар</span>
					<div id="commentar_728" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Україна в Першій світовій війні. Перебіг воєнних дій на території України.</strong></p>
			
			<p>Завдання спрямоване на перевірку сформованості картографічних умінь (локалізувати історико-географічні об’єкти та історичні факти на карті), уміння отримувати інформацію з карти та застосовувати набуті знання у зв’язку з її змістом.</p>
			
			<p>Алгоритмом виконання завдання можуть бути такі кроки.</p>
			
			<p>Перший. Визначаємо та узагальнюємо подану на карті&nbsp;інформацію з позиції поставленого до неї запитання.</p>
			
			<p>Другий крок. Установлюємо відповідність отриманої з карти інформації з кожним запропонованим варіантом відповіді.</p>
			
			<p>Отже, на карті зображені події Першої світової війни на українських землях 1916 р. На це вказують напрями дій військ і лінії фронтів. Зокрема, на схемі відображено успішний наступ російського Південно-Західного фронту, що отримав назву Брусиловський прорив, коли російські війська повернули собі частину території, яку втратили в 1915 р.</p>
			
			<p><strong>Відповідь – Г.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q2" class="task-card">
			<div class="counter">Завдання 2</div>
			<div class="question"><p>Політична організація емігрантів із Наддніпрянської України, створена у  Львові на початку Першої світової війни, що проголосила метою своєї  діяльності побудову самостійної соборної Української держави,&nbsp;— це</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Головна українська рада.</div><div class="answer"><span class="marker">Б</span>Союз визволення України.</div><div class="answer"><span class="marker">В</span>Карпато-руський визвольний комітет.</div><div class="answer"><span class="marker">Г</span>Товариство українських поступовців.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_786" onclick="showComment(786)">Читати коментар</span>
					<div id="commentar_786" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Україна в Першій світовій війні. Позиції українських політичних сил Наддніпрянської України та західноукраїнських земель щодо війни. «Союз визволення України».</strong></p>
			
			<p>Завдання передбачає перевірку сформованості знань про вплив Першої світової війни на український рух.</p>
			
			<p>Серед запропонованих організацій лише Союз визволення України (СВУ) проголосив метою своєї діяльності побудову самостійної соборної України.</p>
			
			<p>Учасники СВУ вважали себе репрезентантами інтересів українців, які перебували під російським пануванням. СВУ, проголосивши своєю метою боротьбу за самостійність України, прагнув використати для цього війну Австро-Угорщини й Німеччини проти Росії. Майбутній устрій української держави мав бути заснованим як конституційна монархія з однопалатним парламентом.</p>
			
			<p><strong>Відповідь – Б.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q3" class="task-card">
			<div class="counter">Завдання 3</div>
			<div class="question"><p>Що стало наслідком подій, перебіг яких відображено на карті?</p><p><img width="504" height="597" src="/doc/images/znotest/8/846/7.jpg" alt=""></p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>капітуляція Австро-Угорщини та проголошення ЗУНР</div><div class="answer"><span class="marker">Б</span>вступ у світову війну Німеччини на боці Австро-Угорщини</div><div class="answer"><span class="marker">В</span>демократична революція та повалення самодержавства в Росії</div><div class="answer"><span class="marker">Г</span>створення Галицько-Буковинського генерал-губернаторства</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_846" onclick="showComment(846)">Читати коментар</span>
					<div id="commentar_846" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Україна в Першій світовій війні</strong></p>
			
			<p>Завдання спрямоване на перевірку сформованості картографічних умінь (локалізувати історико-географічні об’єкти та історичні факти на карті), уміння отримувати інформацію з карти та застосовувати набуті знання у зв’язку з її змістом.</p>
			
			<p>Алгоритмом виконання завдання можуть бути такі кроки.</p>
			
			<p>Перший. Визначаємо та узагальнюємо інформацію, подану на карті, з позиції поставленого до неї запитання.</p>
			
			<p>Другий крок. Увідповіднюємо інформацію, отриману з карти, з кожним запропонованим варіантом відповіді.</p>
			
			<p>На картосхемі зображено події Першої світової війни 1914 р., які розгорталися на українських землях. Стрілка позначає&nbsp;наступ російської армії проти австро-угорської, що ввійшов в історію під назвою «Галицька битва». У результаті цих подій на захоплених Росією західноукраїнських землях було створено Галицько-Буковинське генерал-губернаторство.</p>
			
			<p><strong>Правильна відповідь –</strong><strong> Г.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q4" class="task-card">
			<div class="counter">Завдання 4</div>
			<div class="question"><p>Головна українська рада в серпні 1914 р. закликала українців Галичини</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>підтримати Австро-Угорщину, «...бо ідучи війною, Росія грозить загином українському життю, яке знайшло охорону в австрійській державі...»</div><div class="answer"><span class="marker">Б</span>бути нейтральними, тому що жодна з воюючих сторін «...не може викликати співчуття ні цілями, ні способами боротьби...»</div><div class="answer"><span class="marker">В</span>виступити проти Австро-Угорщини та Росії, щоб вибороти «...єдину, самостійну Україну від Карпатів аж по Кавказ...»</div><div class="answer"><span class="marker">Г</span>підтримати Росію й чесно, «...не піддаючись на провокації, виконати свій обов’язок громадян Росії до кінця...»</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_941" onclick="showComment(941)">Читати коментар</span>
					<div id="commentar_941" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Україна в Першій світовій війні</strong></p>
			
			<p>Завдання спрямоване на перевірку знань основних подій на українських землях у роки Першої світової війни.</p>
			
			<p>Головна українська рада, утворена українськими політичними партіями Галичини, виступала за підтримку&nbsp;Австро-Угорщини, <em>«...бо ідучи війною, Росія грозить загином українському життю, яке знайшло охорону в австрійській державі...»</em></p>
			
			<p><strong>Правильна відповідь – А.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q5" class="task-card">
			<div class="counter">Завдання 5</div>
			<div class="question"><p>Про яку операцію російських військ Південно-Західного фронту часів Першої світової війни йдеться в цитованому документі: <em>«У порівнянні з надіями, що покладалися на цей фронт навесні 1916  р., його наступ перевершив усі очікування. Він виконав поставлене  завдання&nbsp;— врятувати Італію від розгрому... полегшив становище англійців  і французів на фронті, змусив Румунію стати на наш бік і зіпсував усі  плани й наміри австро-угорців і німців на цей рік»</em>?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Галицьку битву</div><div class="answer"><span class="marker">Б</span>Горліцький прорив</div><div class="answer"><span class="marker">В</span>Перемишльську битву</div><div class="answer"><span class="marker">Г</span>Брусиловський прорив</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1002" onclick="showComment(1002)">Читати коментар</span>
					<div id="commentar_1002" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><strong>ТЕМА: Україна в Першій світовій війні.</strong></p>
			
			<p>Завдання скеровано на перевірку знання основних подій Першої світової війни на українських землях і сформованості вміння здобувати інформацію із джерела й застосовувати набуті знання з огляду на його зміст, а також уміння встановлювати причиново-наслідкові зв’язки.</p>
			
			<p>Алгоритм виконання завдання такий:</p>
			
			<ul>
				<li>з’ясувати, що потрібно ідентифікувати (саме джерело, описану в ньому подію чи явище, персонаж тощо);</li>
				<li>у тексті джерела виділити <strong>маркери</strong> – ключові слова, словосполучення, речення тощо, які дають змогу впізнати предмет ідентифікації;</li>
				<li>проаналізувати їх, узагальнити й вибрати варіант відповіді, переконавшись, що він не суперечить виділеним маркерам.</li>
			</ul>
			
			<p>Предмет ідентифікації в завданні – назва операції російських військ Південно-Західного фронту під час Першої світової війни.</p>
			
			<p>Маркери – «У порівнянні з надіями, що покладалися на цей фронт навесні 1916&nbsp;року, його наступ перевершив усі очікування», «Він… врятувати Італію від розгрому... полегшив становище англійців і французів на фронті, змусив Румунію стати на наш бік і зіпсував усі плани й наміри австро-угорців і німців на цей рік» – указують на успішні дії росіян під час <strong>Брусиловського прориву</strong>. Проте позитивні наслідки для ходу війни цієї операції є перебільшеними. Успіх був досягнутий значними втратами російської армії (особливо на інших фронтах), після відбулося стрімке зниження її боєздатності й революціонізація.</p>
			
			<p><strong>Правильна відповідь</strong> – <strong>Г.</strong></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q6" class="task-card">
			<div class="counter">Завдання 6</div>
			<div class="question"><div class="b-question__text i-clearfix b-static-text"><p>Про кого з історичних діячів йдеться:</p><p><em>«Співзасновник  Української національно-демократичної  партії (УНДП), згодом її  голова. Обирався послом до австрійського парламенту та галицького   крайового сейму. У роки Першої світової війни очолював Головну  українську раду, а згодом  Загальну українську раду. Після  проголошення ЗУНР став головою її першого уряду»</em>?</p></div></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>А. Шептицького</div><div class="answer"><span class="marker">Б</span>К. Левицького</div><div class="answer"><span class="marker">В</span>О. Бобринського</div><div class="answer"><span class="marker">Г</span>К. Трильовського</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q7" class="task-card">
			<div class="counter">Завдання 7</div>
			<div class="question"><div class="b-question__text i-clearfix b-static-text"><p>Яка країна на початку XX ст. визначила свої зовнішньополітичні пріоритети таким чином:</p><p><em>«...твердо  приймаються такі завдання на найближчі роки: 1) приєднати західні землі  та належною поступовістю викорінити тут мазепинський дух; 2) заволодіти  протоками, які мають для нас виключне стратегічне значення для виходу  нашого флоту з Чорного моря до Середземного»</em>?</p></div></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Росія</div><div class="answer"><span class="marker">Б</span>Румунія</div><div class="answer"><span class="marker">В</span>Німеччина</div><div class="answer"><span class="marker">Г</span>Австро-Угорщина</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1173" onclick="showComment(1173)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1173" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q8" class="task-card">
			<div class="counter">Завдання 8</div>
			<div class="question"><p>«Галицько-Буковинське генерал-губернаторство»&nbsp;— це адміністративно-територіальна одиниця, створена</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>владою Австро-Угорщини на початку Першої світової війни на вимогу Головної української ради та Союзу визволення України.</div><div class="answer"><span class="marker">Б</span>урядом Російської імперії для управління окупованими російською армією під час Першої світової війни землями Австро-Угорщини.</div><div class="answer"><span class="marker">В</span>командуванням Німеччини та Австро-Угорщини, оборона якої в роки Першої світової війни покладалася на Українських січових стрільців.</div><div class="answer"><span class="marker">Г</span>урядом Німеччини на українських землях Австро-Угорської та Російської імперій після завершення Першої світової війни.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1603" onclick="showComment(1603)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1603" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q9" class="task-card">
			<div class="counter">Завдання 9</div>
			<div class="question"><p>Формування в роки Першої світової війни легіону Українських січових стрільців засвідчило</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>лояльність українців Галичини до австро-угорської монархії.</div><div class="answer"><span class="marker">Б</span>впливовість москвофілів у політичному житті Галичини.</div><div class="answer"><span class="marker">В</span>непідготованість Австро-Угорщини до ведення війни на два фронти.</div><div class="answer"><span class="marker">Г</span>приєднання України до Четверного союзу Центральних держав.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1663" onclick="showComment(1663)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1663" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q10" class="task-card">
			<div class="counter">Завдання 10</div>
			<div class="question"><p>Напередодні Першої світової війни Австро-Угорщина претендувала на володіння</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Волинню та Поділлям.</div><div class="answer"><span class="marker">Б</span>Донбасом і Придніпров’ям.</div><div class="answer"><span class="marker">В</span>Північною Буковиною та Бессарабією.</div><div class="answer"><span class="marker">Г</span>Східною Галичиною та Північною Буковиною.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1722" onclick="showComment(1722)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1722" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q11" class="task-card">
			<div class="counter">Завдання 11</div>
			<div class="question"><div class="b-question__text i-clearfix b-static-text"><p>Коли відбувалися події, згадувані в уривку з історичного документа?</p><p><em>«...Наші  праві націоналісти в особі графа Бобринського, посівши адміністративні  посади в «П’ємонті українства», почали переслідувати український  національний рух і силоміць навертати уніатів до православ’я. Тяжке  враження справив арешт митрополита А. Шептицького… Все сприяло  наростанню ворожості місцевого населення до переможців»</em>.</p></div></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1905—1907 рр.</div><div class="answer"><span class="marker">Б</span>1908—1913 рр.</div><div class="answer"><span class="marker">В</span>1914—1915 рр.</div><div class="answer"><span class="marker">Г</span>1916—1917 рр.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1723" onclick="showComment(1723)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1723" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q12" class="task-card">
			<div class="counter">Завдання 12</div>
			<div class="question"><p>Легіон Українських січових стрільців&nbsp;— це військова частина, створена за ініціативи</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Союзу визволення України у складі німецької армії, що діяла проти румунської армії у 1914—1916 рр.</div><div class="answer"><span class="marker">Б</span>Головної української ради у складі австрійської армії, що діяла проти російської армії у 1914—1918 рр.</div><div class="answer"><span class="marker">В</span>Карпато-руського визвольного комітету у складі російської армії, що діяла проти австрійської армії у 1915—1917 рр.</div><div class="answer"><span class="marker">Г</span>Товариства українських поступовців, що діяла як проти російської, так і проти німецької армій у 1916—1918 рр.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_1781" onclick="showComment(1781)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_1781" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q13" class="task-card">
			<div class="counter">Завдання 13</div>
			<div class="question"><p>Яка подія дала поштовх до створення легіону Українських січових стрільців?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>початок Першої світової війни</div><div class="answer"><span class="marker">Б</span>утворення Української Центральної Ради</div><div class="answer"><span class="marker">В</span>повалення самодержавства в Російській імперії</div><div class="answer"><span class="marker">Г</span>проголошення Української Народної Республіки</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_4963" onclick="showComment(4963)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_4963" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q14" class="task-card">
			<div class="counter">Завдання 14</div>
			<div class="question"><p>Які українські землі під час Першої світової війни було окуповано російськими військами в 1914 р.?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Холмщину, Західну Волинь</div><div class="answer"><span class="marker">Б</span>Східну Галичину, Північну Буковину</div><div class="answer"><span class="marker">В</span>Західне Поділля, Східну Волинь</div><div class="answer"><span class="marker">Г</span>Закарпаття, Марморощину</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6662" onclick="showComment(6662)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6662" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q15" class="task-card">
			<div class="counter">Завдання 15</div>
			<div class="question"><p>У якому році в ході Першої світової війни російськими військами було захоплено Львів?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1914 р.</div><div class="answer"><span class="marker">Б</span>1915 р.</div><div class="answer"><span class="marker">В</span>1916 р.</div><div class="answer"><span class="marker">Г</span>1917 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6997" onclick="showComment(6997)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6997" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q16" class="task-card">
			<div class="counter">Завдання 16</div>
			<div class="question"><p>Яка організація в роки Першої світової війни виступила з такою відозвою:</p> <p><em>«…Перемога Австро-Угорської монархії буде нашою перемогою. І чим більша буде поразка Росії, тим швидше проб’є година визволення України… Нехай на руїнах царської імперії зійде сонце вільної України!..»</em>?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Революційна українська партія</div><div class="answer"><span class="marker">Б</span>Товариство українських поступовців</div><div class="answer"><span class="marker">В</span>Карпато-руський визвольний комітет</div><div class="answer"><span class="marker">Г</span>Головна українська рада</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7896" onclick="showComment(7896)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7896" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q17" class="task-card">
			<div class="counter">Завдання 17</div>
			<div class="question"><p>Напередодні Першої світової війни українські землі перебували в складі</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Росії та Румунії.</div><div class="answer"><span class="marker">Б</span>Румунії та Польщі.</div><div class="answer"><span class="marker">В</span>Польщі та Австро-Угорщини.</div><div class="answer"><span class="marker">Г</span>Австро-Угорщини та Росії.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_8222" onclick="showComment(8222)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_8222" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q18" class="task-card">
			<div class="counter">Завдання 18</div>
			<div class="question"><p>У ході Першої світової війни Товариство українських поступовців закликало українців</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>підтримати Троїстий союз, «...бо ідучи війною, Росія грозить загином українському життю,  яке знайшло охорону в австрійській державі».</div><div class="answer"><span class="marker">Б</span>бути нейтральними, тому що жодна з воюючих сторін «...не може викликати співчуття ні  цілями, ні способами боротьби».</div><div class="answer"><span class="marker">В</span>виступити проти Антанти й Троїстого союзу, щоб вибороти «...єдину, самостійну Україну  від Карпатів аж по Кавказ».</div><div class="answer"><span class="marker">Г</span>підтримати Антанту й чесно, «...не піддаючись на провокації, виконати свій обов’язок  громадян Росії до кінця».</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q19" class="task-card">
			<div class="counter">Завдання 19</div>
			<div class="question"><p>Яким було ставлення російської влади до українського національного руху на Наддніпрянській Україні під час Першої світової війни?</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>підтримувала його патріотичні настрої</div><div class="answer"><span class="marker">Б</span>не звертала уваги на його існування</div><div class="answer"><span class="marker">В</span>посилювала репресії проти нього</div><div class="answer"><span class="marker">Г</span>надавала додаткові можливості для його розвитку</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q20" class="task-card">
			<div class="counter">Завдання 20</div>
			<div class="question"><p>Укажіть період, протягом якого німецькі та австро-угорські війська здійснили Горлицький прорив.</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>вересень 1914 р.</div><div class="answer"><span class="marker">Б</span>травень 1915 р.</div><div class="answer"><span class="marker">В</span>червень 1916 р.</div><div class="answer"><span class="marker">Г</span>серпень 1917 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q21" class="task-card">
			<div class="counter">Завдання 21</div>
			<div class="question"><p>Укажіть мету, якої прагнула досягти Росія в ході Першої світової війни.</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>загарбання Данцига та контроль над узбережжям Балтійського моря</div><div class="answer"><span class="marker">Б</span>приєднання Бессарабії та контроль над дельтою Дунаю</div><div class="answer"><span class="marker">В</span>контроль над нафтовими родовищами Румунії</div><div class="answer"><span class="marker">Г</span>приєднання Закарпаття, Північної Буковини та Східної Галичини</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q22" class="task-card">
			<div class="counter">Завдання 22</div>
			<div class="question"><p>У який період Першої світової війни граф Г. Бобринський мав можливість реалізувати свою обіцянку: <em>«…Галичина і Лемківщина – споконвічно частина єдиної великої Русі… Я буду вводити тут російську мову, закон і устрій…»</em>?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>серпень 1914 р. – червень 1915 р.</div><div class="answer"><span class="marker">Б</span>серпень 1915 р. – липень 1916 р.</div><div class="answer"><span class="marker">В</span>липень 1916 р. – лютий 1917 р.</div><div class="answer"><span class="marker">Г</span>березень 1917 р. – квітень 1918 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9174" onclick="showComment(9174)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9174" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q23" class="task-card">
			<div class="counter">Завдання 23</div>
			<div class="question"><p>Укажіть один із напрямів діяльності Союзу визволення України, що існував у 1914-1918 рр.</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>формування легіону Українських січових стрільців</div><div class="answer"><span class="marker">Б</span>координація акцій української громади в Державній Думі</div><div class="answer"><span class="marker">В</span>створення громадських організацій з допомоги біженцям</div><div class="answer"><span class="marker">Г</span>допомога військовополоненим українцям</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9369" onclick="showComment(9369)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9369" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q24" class="task-card">
			<div class="counter">Завдання 24</div>
			<div class="question"><p>Створення добровольчого легіону Українських січових стрільців у складі австро-угорської армії ініціювала</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Директорія УНР.</div><div class="answer"><span class="marker">Б</span>Рада народних комісарів.</div><div class="answer"><span class="marker">В</span>Головна українська рада.</div><div class="answer"><span class="marker">Г</span>Українська Центральна Рада.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10098" onclick="showComment(10098)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10098" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q25" class="task-card">
			<div class="counter">Завдання 25</div>
			<div class="question">Установіть відповідність між прізвищем діяча та фактом його біографії.</div><br>
			<div class="answers" style="width: 50%"><div class="answer"><span class="marker">1</span>Г. Бобринський</div><div class="answer"><span class="marker">2</span>Є. Чикаленко </div><div class="answer"><span class="marker">3</span>М. Міхновський </div><div class="answer"><span class="marker">4</span>К. Левицький</div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="answer"><span class="marker">А</span>один з організаторів Союзу визволення України</div><div class="answer"><span class="marker">Б</span>фундатор Української народної партії (УНП)</div><div class="answer"><span class="marker">В</span>засновник київських газет «Громадська думка» і «Рада»</div><div class="answer"><span class="marker">Г</span>Галицько-Буковинський генерал-губернатор у 1914–1915 рр.</div><div class="answer"><span class="marker">Д</span>голова Головної української ради</div></div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr><tr>
					<th class="r">5</th>
					<td><label><span class="marker"></span></label></td>
					<td><label><span class="marker"></span></label></td>
					<td><label><span class="marker"></span></label></td>
					<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10119" onclick="showComment(10119)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10119" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1d;2c;3b;4e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q26" class="task-card">
			<div class="counter">Завдання 26</div>
			<div class="question"><p>На картосхемі позначено лінію фронту часів Першої світової війни станом на</p>
			
			<p><img alt="" src="/doc/images/znotest/102/10216/34_1.jpg" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1914 р. </div><div class="answer"><span class="marker">Б</span>1915 р. </div><div class="answer"><span class="marker">В</span>1916 р. </div><div class="answer"><span class="marker">Г</span>1917р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10216" onclick="showComment(10216)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10216" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q27" class="task-card">
			<div class="counter">Завдання 27</div>
			<div class="question">Бойові дії на українських землях у роки Першої світової війни розпочалися в</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1914 р. </div><div class="answer"><span class="marker">Б</span>1915 р. </div><div class="answer"><span class="marker">В</span>1916 р. </div><div class="answer"><span class="marker">Г</span>1917 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12100" onclick="showComment(12100)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12100" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q28" class="task-card">
			<div class="counter">Завдання 28</div>
			<div class="question"><p>Прочитайте уривок з історичного джерела та виконайте завдання.</p>
			
			<p>«<em>Надходить важка історична хвиля. Вирішується доля держав і народів. Нічого не вдіяли всі зусилля дипломатії, щоб утримати мир у Європі… Війни хоче цар російський, самодержавний володар імперії, яка є історичним ворогом України… Історичний ворог України не може спокійно дивитися, що не вся Україна в його руках…»</em></p>
			
			<p>В уривку йдеться про переддень</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>балканських війн 1912–1913 рр. </div><div class="answer"><span class="marker">Б</span>Першої світової війни 1914–1918 рр. </div><div class="answer"><span class="marker">В</span>першої війни радянської Росії з УНР 1917–1918 рр.</div><div class="answer"><span class="marker">Г</span>польсько-радянської війни 1920–1921 рр.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12537" onclick="showComment(12537)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12537" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q29" class="task-card">
			<div class="counter">Завдання 29</div>
			<div class="question">Установіть відповідність між подією часів Першої світової війни та роком, коли вона відбулася.</div><br>
			<div class="answers" style="width: 50%"><div class="answer"><span class="marker">1</span>утворення Української Центральної Ради </div><div class="answer"><span class="marker">2</span>формування легіону Українських січових стрільців </div><div class="answer"><span class="marker">3</span>підписання Брестського мирного договору </div><div class="answer"><span class="marker">4</span>Брусиловський прорив</div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="answer"><span class="marker">А</span>1914 р. </div><div class="answer"><span class="marker">Б</span>1915 р. </div><div class="answer"><span class="marker">В</span>1916 р. </div><div class="answer"><span class="marker">Г</span>1917 р. </div><div class="answer"><span class="marker">Д</span>1918 р.</div></div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12558" onclick="showComment(12558)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12558" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1d;2a;3e;4c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q30" class="task-card">
			<div class="counter">Завдання 30</div>
			<div class="question"><p>Результат якої події Першої світової війни дав змогу правлячим колам Росії реалізувати стратегію «…<i>злиття землі Ярослава Осмомисла, князів Данила і Романа з Імперією в політичному та національному відношеннях</i>…»?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Галицької битви</div><div class="answer"><span class="marker">Б</span>Карпатської операції </div><div class="answer"><span class="marker">В</span>Ґорліцького прориву </div><div class="answer"><span class="marker">Г</span>Брусиловського прориву</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_13785" onclick="showComment(13785)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_13785" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q31" class="task-card">
			<div class="counter">Завдання 31</div>
			<div class="question">Створення легіону Українських січових стрільців</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>спричинено формуванням «Вільного козацтва». </div><div class="answer"><span class="marker">Б</span>було складовою процесу «українізації» частин російської армії. </div><div class="answer"><span class="marker">В</span>відбулося за ініціативи Головної української ради.</div><div class="answer"><span class="marker">Г</span>зумовлено проголошенням Західноукраїнської Народної Республіки.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14973" onclick="showComment(14973)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14973" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q32" class="task-card">
			<div class="counter">Завдання 32</div>
			<div class="question"><p>На картосхемі стрілками позначено</p>
			
			<p><img alt="" src="/doc/images/znotest/154/15495/3.JPG" width="516" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>«Брусиловський прорив» російських військ. </div><div class="answer"><span class="marker">Б</span>бойовий шлях Українських січових стрільців. </div><div class="answer"><span class="marker">В</span>головні напрямки дій російських військ під час Галицької битви. </div><div class="answer"><span class="marker">Г</span>наступ німецьких й австро-угорських військ під час Ґорліцького прориву.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_15495" onclick="showComment(15495)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_15495" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q33" class="task-card">
			<div class="counter">Завдання 33</div>
			<div class="question">Для соціально-економічного розвитку українських земель періоду Першої світової війни було характерним</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>зростання виробництва сільгосппродукції. </div><div class="answer"><span class="marker">Б</span>посилення інфляційних процесів в економіці. </div><div class="answer"><span class="marker">В</span>збільшення виробництва продуктів нафтопереробки. </div><div class="answer"><span class="marker">Г</span>ліквідування механізмів державного регулювання економіки.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_16540" onclick="showComment(16540)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_16540" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q34" class="task-card">
			<div class="counter">Завдання 34</div>
			<div class="question"><p>Які українські землі під час Першої світової війни в 1914 р. було окуповано російськими військами?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Західне Поділля, Східну Волинь </div><div class="answer"><span class="marker">Б</span>Холмщину, Західну Волинь </div><div class="answer"><span class="marker">В</span>Східну Галичину, Північну Буковину </div><div class="answer"><span class="marker">Г</span>Закарпаття, Мармарощину</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17428" onclick="showComment(17428)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17428" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q35" class="task-card">
			<div class="counter">Завдання 35</div>
			<div class="question"><p>В уривку з історичного джерела «<i>Москвофіли-інтелігенти на кожному кроці показували радість з приводу вступу до Львова російських військ та намагалися їм допомогти</i>» відображено події в Східній Галичині в</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1900 р. </div><div class="answer"><span class="marker">Б</span>1907 р.</div><div class="answer"><span class="marker">В</span>1914 р. </div><div class="answer"><span class="marker">Г</span>1918 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_18349" onclick="showComment(18349)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_18349" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q36" class="task-card">
			<div class="counter">Завдання 36</div>
			<div class="question"><p>Проаналізуйте уривок з історичного джерела:</p>
			
			<p><em>«…ми, українці, з початку війни зайняли нейтральну позицію й не виступали ні за, ні проти війни, а тепер постановили виступити рішуче проти війни, бо вона тільки нищить наш край, як уже знищила Галичину та частину Волині, і не принесе нічого корисного.</em></p>
			
			<p><em>Володимир Леонтович та Андрій В’язлов висловилися проти такої рішучої заяви, бо вона йде всупереч з думками російської інтелігенції, що нас і так обвинувачує вже не тільки [російський] уряд, але й [російське суспільство] у сепаратизмі…».</em></p>
			
			<p>Еволюцію поглядів якої організації відображено в ньому?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Революційної української партії </div><div class="answer"><span class="marker">Б</span>Товариства українських поступовців </div><div class="answer"><span class="marker">В</span>Головної української ради</div><div class="answer"><span class="marker">Г</span>Союзу визволення України</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_19367" onclick="showComment(19367)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_19367" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q37" class="task-card">
			<div class="counter">Завдання 37</div>
			<div class="question"><p>Хто підписав документ, уривок з якого наведено:</p>
			
			<p><em>«Наказ “Сокола-Батька”. Члени всіх філій “Сокола-Батька” як “Січей”, так і “Соколів” мають стати тепер членами “Українських Січових Стрільців”… У стрілецьких справах усі тепер підпадають під наказ “Української Бойової Управи”…»?</em></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Іван Франко </div><div class="answer"><span class="marker">Б</span>Іван Боберський </div><div class="answer"><span class="marker">В</span> Євген Петрушевич </div><div class="answer"><span class="marker">Г</span>Андрей Шептицький</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_20653" onclick="showComment(20653)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_20653" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q38" class="task-card">
			<div class="counter">Завдання 38</div>
			<div class="question"><p>Події Першої світової війни, описані в уривку джерела <em>«Дії цього фронту врятували Італію від розгрому та виходу її з війни, окрім того, полегшили становище англійців і французів на фронті, спонукали Румунію стати на бік </em><em>[</em><em>Антанти</em><em>]</em><em> та зіпсували всі плани й наміри австро-угорців і німців на цей</em> <em>рік...»,</em> сприяли</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>повторній окупації російськими військами частини Галичини та Буковини. </div><div class="answer"><span class="marker">Б</span>реорганізації Головної української ради в Загальну українську раду.</div><div class="answer"><span class="marker">В</span>ліквідації Галицько-Буковинського генерал-губернаторства.</div><div class="answer"><span class="marker">Г</span>створенню легіону Українських січових стрільців.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_21300" onclick="showComment(21300)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_21300" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q39" class="task-card">
			<div class="counter">Завдання 39</div>
			<div class="question"><p>Про яку операцію військ Південно-Західного фронту часів Першої світової війни йдеться в цитованому документі?</p>
			
			<p><em>«У порівнянні з надіями, що покладалися на цей фронт навесні 1916 року, його наступ перевершив усі очікування. Він виконав поставлене перед ним завдання – врятувати Італію від розгрому та виходу її з війни, окрім того, полегшив становище англійців і французів на фронті, змусив Румунію стати на наш бік та зіпсував усі плани й наміри австро-угорців і німців на цей рік».</em></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Галицьку битву </div><div class="answer"><span class="marker">Б</span>штурм фортеці Перемишль </div><div class="answer"><span class="marker">В</span>бої за гору Лисоня </div><div class="answer"><span class="marker">Г</span>Брусиловський прорив</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22052" onclick="showComment(22052)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22052" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q40" class="task-card">
			<div class="counter">Завдання 40</div>
			<div class="question"><p>Яка країна з початком Першої світової війни окреслила свої стратегічні наміри наступним чином: «<i>наша головна мета в цій війні полягає у довготривалому ослабленні Росії і тому, на випадок нашої перемоги, ми приступимо до створення незалежної від Росії Української держави. Маючи це на увазі, ми будемо підтримувати діяльність Союзу визволення України»?</i></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Польща </div><div class="answer"><span class="marker">Б</span> Велика Британія </div><div class="answer"><span class="marker">В</span>Австро-Угорщина </div><div class="answer"><span class="marker">Г</span>Румунія</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22115" onclick="showComment(22115)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22115" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q41" class="task-card">
			<div class="counter">Завдання 41</div>
			<div class="question"><p>Яка країна на початку XX ст. визначила свої зовнішньополітичні пріоритети таким чином: <i>«…твердо приймаються такі завдання на найближчі роки: 1) приєднати західні землі та з належною поступовістю викорінити тут мазепинський дух; 2) заволодіти протоками, які мають для нас виключне значення для виходу нашого флоту... до Середземного моря»?</i></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Австро-Угорщина </div><div class="answer"><span class="marker">Б</span>Румунія </div><div class="answer"><span class="marker">В</span>Німеччина </div><div class="answer"><span class="marker">Г</span>Росія</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22176" onclick="showComment(22176)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22176" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q42" class="task-card">
			<div class="counter">Завдання 42</div>
			<div class="question"><p>У складі якої армії в роки Першої світової війни було сформовано підрозділ Українських січових стрільців?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>російської </div><div class="answer"><span class="marker">Б</span>німецької </div><div class="answer"><span class="marker">В</span>австро-угорської</div><div class="answer"><span class="marker">Г</span>польської</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22231" onclick="showComment(22231)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22231" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q43" class="task-card">
			<div class="counter">Завдання 43</div>
			<div class="question"><p>Установіть відповідність між подією та її наслідками.</p>
			</div><br>
			<div class="answers" style="width: 50%"><div class="answer"><span class="marker">1</span>економічна криза 1900–1903 рр. </div><div class="answer"><span class="marker">2</span>революція 1905–1907 рр. </div><div class="answer"><span class="marker">3</span>Столипінська реформа 1906–1911 рр. </div><div class="answer"><span class="marker">4</span>Перша світова війна 1914–1918 рр.</div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="answer"><span class="marker">А</span>повалення самодержавства, розпад Російської імперії, Українська революція </div><div class="answer"><span class="marker">Б</span>посилення концентрації виробництва, зростання питомої ваги України в економіці Російської імперії </div><div class="answer"><span class="marker">В</span>руйнування селянської общини, перетворення Наддніпрянської України в одного з основних експортерів хліба до Європи </div><div class="answer"><span class="marker">Г</span>втрата чинності Емського указу, легалізація діяльності українських політичних партій, створення українських думських громад </div><div class="answer"><span class="marker">Д</span>скасування панщини та особистої залежності селян, надання селянам громадянських прав</div></div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22252" onclick="showComment(22252)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22252" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2d;3c;4a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q44" class="task-card">
			<div class="counter">Завдання 44</div>
			<div class="question"><p>У якому році оприлюднено цитоване звернення до населення західноукраїнських земель:</p>
			
			<p><em>«Не бути більше підневільної Русі! Надбання Володимира Святого, земля Ярослава Осмомисла, князів Данила та Романа, скинувши ярмо, підніме знамено єдиної, великої, неподільної Росії. Звільнені руські брати!.. Не вбачаючи свого щастя в утиску іноземців, як це робили [австрійці], спрямуйте меч свій на ворога, а серця свої зверніть до Бога з молитвою за Росію, за російського Царя!»?</em></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1914 р. </div><div class="answer"><span class="marker">Б</span>1915 р. </div><div class="answer"><span class="marker">В</span>1916 р.</div><div class="answer"><span class="marker">Г</span>1917 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22286" onclick="showComment(22286)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22286" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q45" class="task-card">
			<div class="counter">Завдання 45</div>
			<div class="question"><p style="text-align: center;"><strong>Проаналізуйте фрагмент історичного документа</strong></p>
			
			<p><em>«Відозва Загальної української ради.</em></p>
			
			<p><em>За всяку ціну завзялася російська імперія загарбати українські землі Австро-Угорщини...<br>
			[...]</em></p>
			
			<p><em>Уже другий раз у часи цієї війни насувається на українські землі Австро-Угорщини&nbsp;російський наступ. Другий раз українське населення Галичини, Буковини й північно-східної Угорщини попадає в огонь національного й релігійного переслідування з боку&nbsp;Росії.</em></p>
			
			<p><em>Під час першого наступу Росія з найбільшою брутальністю прагнула до повного&nbsp;знищення українського життя...</em></p>
			
			<p><em>І тепер в часи другого наступу всі ті вчинки повторюються!»</em></p>
			
			<p>Загальна українська рада оприлюднила цитоване звернення у</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>1914 р.</div><div class="answer"><span class="marker">Б</span>1916 р.</div><div class="answer"><span class="marker">В</span>1918 р.</div><div class="answer"><span class="marker">Г</span>1920 р.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22837" onclick="showComment(22837)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22837" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q46" class="task-card">
			<div class="counter">Завдання 46</div>
			<div class="question"><p><strong>Проаналізуйте фрагмент історичного документа</strong></p>
			
			<p><em>«Відозва Загальної української ради.</em></p>
			
			<p><em>За всяку ціну завзялася російська імперія загарбати українські землі Австро-Угорщини...<br>
			[...]</em></p>
			
			<p><em>Уже другий раз у часи цієї війни насувається на українські землі Австро-Угорщини&nbsp;російський наступ. Другий раз українське населення Галичини, Буковини й північно-східної Угорщини попадає в огонь національного й релігійного переслідування з боку&nbsp;Росії.</em></p>
			
			<p><em>Під час першого наступу Росія з найбільшою брутальністю прагнула до повного&nbsp;знищення українського життя...</em></p>
			
			<p><em>І тепер в часи другого наступу всі ті вчинки повторюються!»</em></p>
			
			<p>Появу звернення зумовлено</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>завершенням Галицької битви.</div><div class="answer"><span class="marker">Б</span>початком «Листопадового зриву».</div><div class="answer"><span class="marker">В</span>здійсненням Чортківської офензиви.</div><div class="answer"><span class="marker">Г</span>проведенням Брусиловського прориву.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22838" onclick="showComment(22838)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22838" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q47" class="task-card">
			<div class="counter">Завдання 47</div>
			<div class="question"><p><strong>Проаналізуйте фрагмент історичного документа</strong></p>
			
			<p><em>«Відозва Загальної української ради.</em></p>
			
			<p><em>За всяку ціну завзялася російська імперія загарбати українські землі Австро-Угорщини...<br>
			[...]</em></p>
			
			<p><em>Уже другий раз у часи цієї війни насувається на українські землі Австро-Угорщини&nbsp;російський наступ. Другий раз українське населення Галичини, Буковини й північно-східної Угорщини попадає в огонь національного й релігійного переслідування з боку&nbsp;Росії.</em></p>
			
			<p><em>Під час першого наступу Росія з найбільшою брутальністю прагнула до повного&nbsp;знищення українського життя...</em></p>
			
			<p><em>І тепер в часи другого наступу всі ті вчинки повторюються!»</em></p>
			
			<p>У роки Першої світової війни Загальна українська рада</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>виступала за нейтралітет українців у війні.</div><div class="answer"><span class="marker">Б</span>була прихильною до влади Австро-Угорщини.</div><div class="answer"><span class="marker">В</span>вимагала негайного проголошення незалежності України.</div><div class="answer"><span class="marker">Г</span>підтримувала політику Росії на західноукраїнських землях.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_22839" onclick="showComment(22839)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_22839" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q48" class="task-card">
			<div class="counter">Завдання 48</div>
			<div class="question"><p>Вільгельм фон Габсбург-Лотрінген – австрійський архікнязь, полковник армії УНР, поет. Під яким псевдонімом він відомий як полковник Українських січових стрільців (УСС)?</p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Олесь Тихий</div><div class="answer"><span class="marker">Б</span>Віктор Грім</div><div class="answer"><span class="marker">В</span>Тарас Чупринка</div><div class="answer"><span class="marker">Г</span>Василь Вишиваний</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_23804" onclick="showComment(23804)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_23804" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q49" class="task-card">
			<div class="counter">Завдання 49</div>
			<div class="question"><p>Яка організація випустила рекламне оголошення, зображене на фото?</p>
			
			<p><img alt="" src="/doc/images/znotest/248/24862/01-i.png" style="height: auto;" width="362"></p>
			</div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Земський союз</div><div class="answer"><span class="marker">Б</span>Союз визволення України</div><div class="answer"><span class="marker">В</span>Карпато-руський визвольний комітет</div><div class="answer"><span class="marker">Г</span>Товариство українських поступовців</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_24862" onclick="showComment(24862)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_24862" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q50" class="task-card">
			<div class="counter">Завдання 50</div>
			<div class="question"><p>Увідповідніть подію з її наслідками.</p>
			</div><br>
			<div class="answers" style="width: 50%"><div class="answer"><span class="marker">1</span>економічна криза 1900-1903 рр.</div><div class="answer"><span class="marker">2</span>революція 1905-1907 рр.</div><div class="answer"><span class="marker">3</span>Столипінська реформа 1906-1911 рр.</div><div class="answer"><span class="marker">4</span>Перша світова війна</div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="answer"><span class="marker">А</span>скасування панщини й особистої залежності селян, надання селянам громадянських прав</div><div class="answer"><span class="marker">Б</span>руйнування селянської общини, перетворення Наддніпрянської України на одного з основних експортерів хліба в Європу</div><div class="answer"><span class="marker">В</span>посилення концентрації виробництва, зростання питомої ваги українських земель в економіці Російської імперії</div><div class="answer"><span class="marker">Г</span>утрата чинності Емського указу, легалізація діяльності українських політичних партій, створення українських думських громад</div><div class="answer"><span class="marker">Д</span>повалення самодержавства, розпад Російської імперії, Українська революція</div></div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_24917" onclick="showComment(24917)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_24917" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1c;2d;3b;4e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q51" class="task-card">
			<div class="counter">Завдання 51</div>
			<div class="question"><p>Реалізація імперської стратегії Росії в Першій світовій війні щодо <i>«…злиття землі Ярослава Осмомисла, князів Данила і Романа з Імперією в політичному, соціальному та національному відношеннях…» </i>стала можливою завдяки</p></div><br>
			<div class="answers" style="width: 100%"><div class="answer"><span class="marker">А</span>Карпатській операції.</div><div class="answer"><span class="marker">Б</span>Горліцькому прориву.</div><div class="answer"><span class="marker">В</span>Брусиловському прориву.</div><div class="answer"><span class="marker">Г</span>Галицькій битві.</div><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_26014" onclick="showComment(26014)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_26014" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q52" class="task-card">
			<div class="counter">Завдання 52</div>
			<div class="question"><p>Установіть відповідність між українською політичною силою та її позицією щодо Першої світової війни.</p>
			</div><br>
			<div class="answers" style="width: 50%"><div class="answer"><span class="marker">1</span>Головна українська рада</div><div class="answer"><span class="marker">2</span>Товариство українських поступовців</div><div class="answer"><span class="marker">3</span>Союз визволення України</div><div class="answer"><span class="marker">4</span>Частина соціал-демократії на чолі з С.&nbsp;Петлюрою </div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="answer"><span class="marker">А</span><i>«Царська імперія загрожує нашому життю під охороною Австрійської монархії. Нехай українство віддасть усі свої сили на те, щоб боронити наше життя, щоб історичний ворог України був розбитий! Нехай на руїнах царської імперії зійде сонце визволеної України!»</i></div><div class="answer"><span class="marker">Б</span><i>«Реалізацію устремлінь українського народу зв’язуємо із підтримкою Австрії й розгромом Росії у війні. Політичною платформою є державна самостійність України. Форма правління має бути конституційна монархія з демократичним устроєм...» </i></div><div class="answer"><span class="marker">В</span><i>«Браття! Хай надбання Володимира Святого, земля князя Ярослава Осмомисла, скинувши чужоземне іго, зіллються з великою Росією. Оберніть меч свій на ворога, а серце своє з молитвою до Росії...» </i></div><div class="answer"><span class="marker">Г</span><i>«Цю війну ми визнаємо чужою.., шкідливою українському народові, бо жодна з воюючих сторін не може викликати співчуття ні цілями, ні способами боротьби. Ми стоїмо на основі автономного устрою тих держав, з якими нас поєднала історична доля...» </i></div><div class="answer"><span class="marker">Д</span><i>«Українці […] виконають свій обов’язок громадян Росії в цей тяжкий час до кінця не тільки на полі бою, а й як громадяни – в міру сил сприятимуть успішному виконанню російською армією завдання, що випало на її долю...»</i></div></div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_26029" onclick="showComment(26029)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_26029" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1a;2d;3b;4e => 0</span> -->
			</div>
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
					<div class="test-bal">Максимальна кількість балів: <strong>67</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
					<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/ukraine-history/tema.html">до списку тем</a>.</small></em></div>
				</div>
					<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/tag-ukrayina_v_roki_pershoyi_svitovoyi_vijni/?1669654387">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/ukraine-history/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			</div>
			<div class="q-info question res"><span class="q-btn button-gray q-up" onclick="window.scrollTo(0,150);">На початок сторінки</span></div></div></div>
			
			<div class="clear"></div>
			
			<!-- zno_quest_list_by_tag_all 0.06894 c. -->
			
			
			<!-- banners - banner_multimob - 1963 -->
			<!--noindex-->
			<div class="banner-wrapper">
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?281611.1664532469" border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?281611.1669048925" border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?281611.1669049035" border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?281611.1668508411" border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?281611.1664546603" border="0" alt=""></a>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner_multimob 0.00049 c. -->
			
			
			<!-- banners - banner620 - 1964 -->
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
			
			<!-- banner620 0.00046 c. -->
			
			
			            </div>
			            <div class="col-right homepage-right-hide">
						
			<!-- banners - banner_multi_300 - 1965 -->
			<!--noindex-->
			<!-- id=20 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3dTcKID" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/20/300krok_20.jpg?281611.1664532469" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=22 -->
			<div class="banner-block w300 h100 ">
				<a href="http://bit.ly/3EQ3yzF" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/22/300-100-1semestr_22.jpg?281611.1669048925" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=21 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3yk0szc" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/21/300-100_21.jpg?281611.1669049035" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=15 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3wKH5yD" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/15/banner_300h100rh_v01_15.png?281611.1668508411" width="300" height="100" border="0" alt=""></a>
			</div>
			<!-- id=28 -->
			<div class="banner-block w300 h100 ">
				<a href="https://bit.ly/3IaY7dv" target="_blank" rel="nofollow"><img src="//zno.osvita.ua/doc/images/banners/28/02-1-30x100-banner-2_28.jpg?281611.1664546603" width="300" height="100" border="0" alt=""></a>
			</div>
			<!--/noindex-->
			<!-- banner_multi_300 0.0014 c. -->
			
			
			<!-- banners - banner300 - 1966 -->
			<!--noindex-->
			<div class="block w300 wrapbanner" style="height:600px;">
			<div class="banner" style="height:600px;">
			<!-- id=1 -->
			<div id="admixer_741839645c2346e68867b1f3f0e96a5e_zone_20646_sect_226_site_226"></div><script type="text/javascript" src="https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=74a1f9e1-65c3-4075-a988-90d4b6350625"></script>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner300 0.00054 c. -->
			
			
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
			                    ©&nbsp;2007–2022 «Освіта.ua».<br>
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
			</script><a href="http://www.bigmir.net/" target="_blank" onclick="img=new Image();img.src=" www.bigmir.net="" ?cl="16796306&quot;;&quot;"><img src="//c.bigmir.net/?v16796673&amp;s16796306&amp;t29&amp;c1&amp;n286135&amp;w0&amp;y0&amp;d24&amp;r1536&amp;fhttps%3A//zno.osvita.ua/ukraine-history/tema.html" width="160" height="19" border="0" alt="bigmir)net TOP 100" title="bigmir)net TOP 100"></a>
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
			</script>
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
    }
}
