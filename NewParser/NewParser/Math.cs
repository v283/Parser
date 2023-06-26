using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewParser
{
    public static class Math1
    {
        public static string html1 = """
			 <body id="body" class="mathematics">
			
			
			 
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
						
			<!-- news - menu - 1888 -->
					<div class="title-block no-bottom-line">
						<a href="https://zno.osvita.ua" title="ЗНО-ОНЛАЙН"><span class="linkh1">ЗНО-ОНЛАЙН</span></a>
									<div class="description"><h1 class="desc">Завдання за темою з математики</h1></div>
								</div>
			<div id="breadcrumbs" class="breadcrumbs" vocab="http://schema.org/" typeof="BreadcrumbList">
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="1">
			<a property="item" typeof="WebPage" href="https://zno.osvita.ua"><span property="name">Тести ЗНО онлайн</span></a></span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="2">
			<a href="https://zno.osvita.ua/mathematics/tema.html" property="item" typeof="WebPage"><span property="name">Математика</span></a>
			</span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="3">
			<a href="https://zno.osvita.ua/mathematics/tag-koordinati_ta_vektori/" property="item" typeof="WebPage">
			<meta property="name" content="Дійсні числа – тести ЗНО/НМТ – завдання з математики">
			</a>
			<span>Дійсні числа – тести ЗНО/НМТ – завдання з математики</span>
			</span>
			<!-- tag --></div>
			
			<!-- curpath = /mathematics/tag-koordinati_ta_vektori/ -->
			
			<!-- menu 0.00365 c. -->
			
			
					</div>
				</div>
				
				<div class="container">
			        <div id="main-content">
			            <div class="col-main">
						
			<!-- znotest - zno_quest_list_by_tag_all - 1889 -->
			<!-- setTitle #### -->
			
			
			<style type="text/css">
			.test-title .label{color: #35866e; font-size:inherit; font-weight:normal;}
			</style>
			
			<script type="text/javascript">
			
			var qfirst = 1;
			var list = 0;
			var cnt = 78;
			var total = 78;
			var test_id = 'tag_120';
			var tag_id = 120;
			var quest_id = 1;
			var section = 2;
			var maxball = 132;
			var tpage = 'tag';
			var freetemp = 0;
			
			
			
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
							if( confirm("Збереження поточних відповідей доступно тільки для «Преміум-акаунтів». Умови отримання «Преміум» доступу дивіться у вашому профілі на сайті. \n\nДля продовження роботи над завданнями теми натисніть кнопку «ОК», або натисніть «Відміна» для завершення теми та отримання поточних результатів.") ){ return ; }			
						}else{
							window.savetemp = test_id;
							if(!isPrem()){ if( confirm("Збереження поточних відповідей доступно тільки для «Преміум-акаунтів». Умови отримання «Преміум» доступу дивіться у вашому профілі на сайті. \n\nДля продовження роботи над завданнями теми натисніть кнопку «ОК», або натисніть «Відміна» для завершення теми та отримання поточних результатів.") ){ return ; }}
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
					}else{
						var prs = getStorageItems('section_temp_tag_pr_'+section);
						console.log('temp_tag_'+tag_id+'='+prs[tag_id]);
						if(prs[tag_id]){
							getTempResult(tag_id);
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
			<!-- 1 - 0 - Математика -->
			<span class="label">Предмет:</span>&nbsp;<span class="row">Алгебра і початки аналізу</span><br><!-- 2 - 3 - Алгебра і початки аналізу -->
			<span class="label">Розділ:</span>&nbsp;<span class="row">Числа і вирази</span><br><!-- 3 - 118 - Числа і вирази -->
			<span class="label">Тема:</span>&nbsp;<span class="row">Дійсні числа</span><br><!-- 4 - 119 - Дійсні числа -->
			<span class="label">Кількість завдань:</span>&nbsp;<span class="row">78</span> <!-- 78 -->
			</div>
			
			<div class="tasks-numbers" id="tasks-numbers"><span class="q1 number ">1</span><span class="q2 number ">2</span><span class="q3 number ">3</span><span class="q4 number ">4</span><span class="q5 number ">5</span><span class="q6 number ">6</span><span class="q7 number ">7</span><span class="q8 number ">8</span><span class="q9 number ">9</span><span class="q10 number ">10</span><span class="q11 number ">11</span><span class="q12 number ">12</span><span class="q13 number ">13</span><span class="q14 number ">14</span><span class="q15 number ">15</span><span class="q16 number ">16</span><span class="q17 number ">17</span><span class="q18 number ">18</span><span class="q19 number ">19</span><span class="q20 number ">20</span><span class="q21 number ">21</span><span class="q22 number ">22</span><span class="q23 number ">23</span><span class="q24 number ">24</span><span class="q25 number ">25</span><span class="q26 number ">26</span><span class="q27 number ">27</span><span class="q28 number ">28</span><span class="q29 number ">29</span><span class="q30 number ">30</span><span class="q31 number ">31</span><span class="q32 number ">32</span><span class="q33 number ">33</span><span class="q34 number ">34</span><span class="q35 number ">35</span><span class="q36 number ">36</span><span class="q37 number ">37</span><span class="q38 number ">38</span><span class="q39 number ">39</span><span class="q40 number ">40</span><span class="q41 number ">41</span><span class="q42 number ">42</span><span class="q43 number ">43</span><span class="q44 number ">44</span><span class="q45 number ">45</span><span class="q46 number ">46</span><span class="q47 number ">47</span><span class="q48 number ">48</span><span class="q49 number ">49</span><span class="q50 number ">50</span><span class="q51 number ">51</span><span class="q52 number ">52</span><span class="q53 number ">53</span><span class="q54 number ">54</span><span class="q55 number ">55</span><span class="q56 number ">56</span><span class="q57 number ">57</span><span class="q58 number ">58</span><span class="q59 number ">59</span><span class="q60 number ">60</span><span class="q61 number ">61</span><span class="q62 number ">62</span><span class="q63 number ">63</span><span class="q64 number ">64</span><span class="q65 number ">65</span><span class="q66 number ">66</span><span class="q67 number ">67</span><span class="q68 number ">68</span><span class="q69 number ">69</span><span class="q70 number ">70</span><span class="q71 number ">71</span><span class="q72 number ">72</span><span class="q73 number ">73</span><span class="q74 number ">74</span><span class="q75 number ">75</span><span class="q76 number ">76</span><span class="q77 number ">77</span><span class="q78 number bad">78</span><span class="num_all" onclick="questExp(); return false;">&nbsp;Всі&nbsp;завдання&nbsp;</span></div>
			
			<div id="waiting" style="display: none;"><center>Зачекайте, йде розрахунок...<br><div id="wait"> </div></center></div>
			<div id="waiting2" style="display:none;"></div>
			
			<div id="wrap">
					
			<!-- 
			сохраню если отвечал дольше 15с.
			сохраню если ответов больше 5%
			все старые записи по тегу удалю.
			 -->
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
			
					<div class="test-bal">Максимальна кількість балів: <strong>132</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
						
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
			<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/mathematics/tema.html">до списку тем</a>.</small></em></div>
				</div>
				<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/mathematics/tag-dijsni_chysla/?1676309069">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/mathematics/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/mathematics/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			
			<!-- abc=0 -->
			<div id="q1" class="task-card">
			<div class="counter">Завдання 1</div>
			<div class="question"><p><img width="596" height="111" alt="" src="/doc/images/znotest/43/4300/matematika_1_1.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_4300" onclick="showComment(4300)">Читати коментар</span>
					<div id="commentar_4300" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><img alt="" src="/doc/images/znotest/43/4300/desice-os-math-2013-01.png" width="600" style="height: auto;"></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q2" class="task-card">
			<div class="counter">Завдання 2</div>
			<div class="question"><p><img width="596" height="120" alt="" src="/doc/images/znotest/43/4304/matematika_5.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_4304" onclick="showComment(4304)">Читати коментар</span>
					<div id="commentar_4304" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><img alt="" src="/doc/images/znotest/43/4304/desice-os-math-2013-05.png" width="600" style="height: auto;"></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q3" class="task-card">
			<div class="counter">Завдання 3</div>
			<div class="question"><p><img width="596" height="111" alt="" src="/doc/images/znotest/43/4319/matematika_18.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_4319" onclick="showComment(4319)">Читати коментар</span>
					<div id="commentar_4319" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><img alt="" src="/doc/images/znotest/43/4319/desice-os-math-2013-18_1.png" width="600" style="height: auto;"></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q4" class="task-card">
			<div class="counter">Завдання 4</div>
			<div class="question"><p><img width="596" height="128" alt="" src="/doc/images/znotest/53/5317/matematika_3.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_5317" onclick="showComment(5317)">Читати коментар</span>
					<div id="commentar_5317" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><img alt="" src="/doc/images/znotest/53/5317/deside-ds-math-2013-03.png" width="600" style="height: auto;"></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q5" class="task-card">
			<div class="counter">Завдання 5</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/60/6081/matematika_2012_1_8.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6081" onclick="showComment(6081)">Читати коментар</span>
					<div id="commentar_6081" class="explanation" style="display: none;">
					<strong>Коментар</strong><br><p><img alt="" src="/doc/images/znotest/60/6081/decide-os-math-2012-08.png" width="600" style="height: auto;"></p>
			</div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q6" class="task-card">
			<div class="counter">Завдання 6</div>
			<div class="question"><p><img width="596" height="160" alt="" src="/doc/images/znotest/61/6102/matematika_2012-2_13.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6102" onclick="showComment(6102)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6102" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q7" class="task-card">
			<div class="counter">Завдання 7</div>
			<div class="question"><p><img width="596" height="104" alt="" src="/doc/images/znotest/61/6107/matematika_2012-2_18.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6107" onclick="showComment(6107)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6107" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q8" class="task-card">
			<div class="counter">Завдання 8</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/61/6123/matematika_2011_2.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6123" onclick="showComment(6123)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6123" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q9" class="task-card">
			<div class="counter">Завдання 9</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/61/6150/matematika_2011_29.png" width="385" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><div class="q-info">Відповідь: <strong></strong></div><!-- 8-9 (8) -->
				<br>
				<div class="q-info">Правильна відповідь: <strong>-9</strong></div><br><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання можливо пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6150" onclick="showComment(6150)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6150" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/3/" target="_blank">Завдання відкритої форми з короткою відповіддю (1 вид)</a> 
			</div>
			<!-- <span>-9 => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q10" class="task-card">
			<div class="counter">Завдання 10</div>
			<div class="question"><p><img width="596" height="116" alt="" src="/doc/images/znotest/61/6158/1_matematika_2010-I_2.png"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6158" onclick="showComment(6158)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6158" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q11" class="task-card">
			<div class="counter">Завдання 11</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/61/6175/matematika_2010-I_19.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6175" onclick="showComment(6175)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6175" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q12" class="task-card">
			<div class="counter">Завдання 12</div>
			<div class="question"><p><img width="594" height="274" alt="" src="/doc/images/znotest/61/6182/matematika_2010-I_26.png"></p></div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6182" onclick="showComment(6182)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6182" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2e;3a;4c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q13" class="task-card">
			<div class="counter">Завдання 13</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/61/6195/matematika_2012_1_19.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6195" onclick="showComment(6195)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6195" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q14" class="task-card">
			<div class="counter">Завдання 14</div>
			<div class="question"><p><img width="596" height="104" alt="" src="/doc/images/znotest/62/6211/matematika_2010-II_1.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6211" onclick="showComment(6211)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6211" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q15" class="task-card">
			<div class="counter">Завдання 15</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/62/6214/matematika_2010-II_4.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6214" onclick="showComment(6214)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6214" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q16" class="task-card">
			<div class="counter">Завдання 16</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/62/6221/matematika_2010-II_11.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6221" onclick="showComment(6221)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6221" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q17" class="task-card">
			<div class="counter">Завдання 17</div>
			<div class="question"><p><img width="591" height="288" alt="" src="/doc/images/znotest/62/6236/matematika_2010-II_26.jpg"></p></div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6236" onclick="showComment(6236)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6236" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1d;2e;3a;4c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q18" class="task-card">
			<div class="counter">Завдання 18</div>
			<div class="question"><p><img alt="" height="102" src="/doc/images/znotest/62/6247/matematika-01.jpg" width="573"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6247" onclick="showComment(6247)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6247" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q19" class="task-card">
			<div class="counter">Завдання 19</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/62/6262/1_matematika-16.jpg" width="622" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6262" onclick="showComment(6262)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6262" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q20" class="task-card">
			<div class="counter">Завдання 20</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/62/6269/1_matematika-23.jpg" width="597" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6269" onclick="showComment(6269)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6269" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1d;2e;3a;4c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q21" class="task-card">
			<div class="counter">Завдання 21</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/62/6275/1_matematika-29.jpg" width="597" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><div class="q-info">Відповідь: <strong></strong></div><!-- 8-9 (8) -->
				<br>
				<div class="q-info">Правильна відповідь: <strong>-7</strong></div><br><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання можливо пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6275" onclick="showComment(6275)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6275" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/3/" target="_blank">Завдання відкритої форми з короткою відповіддю (1 вид)</a> 
			</div>
			<!-- <span>-7 => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q22" class="task-card">
			<div class="counter">Завдання 22</div>
			<div class="question"><p><img width="596" height="116" alt="" src="/doc/images/znotest/62/6281/1_Matematika_126_1.png"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6281" onclick="showComment(6281)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6281" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q23" class="task-card">
			<div class="counter">Завдання 23</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6314/matematika-127_1.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6314" onclick="showComment(6314)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6314" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q24" class="task-card">
			<div class="counter">Завдання 24</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6330/1_matematika-127_17.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6330" onclick="showComment(6330)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6330" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q25" class="task-card">
			<div class="counter">Завдання 25</div>
			<div class="question"><p><img width="596" height="120" alt="" src="/doc/images/znotest/63/6346/matematika_1.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6346" onclick="showComment(6346)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6346" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q26" class="task-card">
			<div class="counter">Завдання 26</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6348/1_matematika_3.jpg" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6348" onclick="showComment(6348)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6348" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q27" class="task-card">
			<div class="counter">Завдання 27</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6352/1_matematika_7.jpg" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6352" onclick="showComment(6352)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6352" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q28" class="task-card">
			<div class="counter">Завдання 28</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6354/1_matematika_9.jpg" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6354" onclick="showComment(6354)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6354" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q29" class="task-card">
			<div class="counter">Завдання 29</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6372/1_matematika_27.jpg" width="590" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6372" onclick="showComment(6372)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6372" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1c;2e;3d;4b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q30" class="task-card">
			<div class="counter">Завдання 30</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6381/matematika17_2010_1.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6381" onclick="showComment(6381)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6381" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q31" class="task-card">
			<div class="counter">Завдання 31</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/63/6388/matematika17_2010_8.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6388" onclick="showComment(6388)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6388" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q32" class="task-card">
			<div class="counter">Завдання 32</div>
			<div class="question"><p><sup><img alt="" src="/doc/images/znotest/63/6392/1_matematika17_2010_12.png" width="596" style="height: auto;"></sup></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6392" onclick="showComment(6392)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6392" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q33" class="task-card">
			<div class="counter">Завдання 33</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/64/6406/1_matematika17_2010_26.png" width="589" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6406" onclick="showComment(6406)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6406" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1c;2e;3d;4b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q34" class="task-card">
			<div class="counter">Завдання 34</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/64/6435/matematika17_2010_6.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6435" onclick="showComment(6435)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6435" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q35" class="task-card">
			<div class="counter">Завдання 35</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/64/6445/1_matematika17_2010_10.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6445" onclick="showComment(6445)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6445" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q36" class="task-card">
			<div class="counter">Завдання 36</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/64/6458/1_matematika17_2010_18.png" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6458" onclick="showComment(6458)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6458" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q37" class="task-card">
			<div class="counter">Завдання 37</div>
			<div class="question"><p><img width="596" height="104" alt="" src="/doc/images/znotest/68/6872/1_33.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6872" onclick="showComment(6872)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6872" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q38" class="task-card">
			<div class="counter">Завдання 38</div>
			<div class="question"><p><img width="596" height="128" alt="" src="/doc/images/znotest/68/6878/matematika_7.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6878" onclick="showComment(6878)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6878" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q39" class="task-card">
			<div class="counter">Завдання 39</div>
			<div class="question"><p><img width="596" height="128" alt="" src="/doc/images/znotest/68/6886/matematika_15.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_6886" onclick="showComment(6886)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_6886" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q40" class="task-card">
			<div class="counter">Завдання 40</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/71/7166/matematika_2.jpg" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7166" onclick="showComment(7166)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7166" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q41" class="task-card">
			<div class="counter">Завдання 41</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/71/7173/1_matematika_9.jpg" width="596" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7173" onclick="showComment(7173)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7173" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q42" class="task-card">
			<div class="counter">Завдання 42</div>
			<div class="question"><p><img width="596" height="144" alt="" src="/doc/images/znotest/74/7482/1_matematika_2009_3.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7482" onclick="showComment(7482)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7482" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q43" class="task-card">
			<div class="counter">Завдання 43</div>
			<div class="question"><p><img width="596" height="144" alt="" src="/doc/images/znotest/74/7490/1_matematika_2009_5.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7490" onclick="showComment(7490)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7490" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q44" class="task-card">
			<div class="counter">Завдання 44</div>
			<div class="question"><p><img width="596" height="112" alt="" src="/doc/images/znotest/74/7495/1_matematika_2009_10.jpg"></p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7495" onclick="showComment(7495)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7495" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q45" class="task-card">
			<div class="counter">Завдання 45</div>
			<div class="question"><p><img width="144" height="55" alt="" src="/doc/images/znotest/75/7526/1_matematika_2009_21.jpg"></p><p>&nbsp;</p></div><br>
			<div class="answers" style="width: 100%"><br></div><br><div class="q-info">Відповідь: <strong></strong></div><!-- 8-9 (8) -->
				<br>
				<div class="q-info">Правильна відповідь: <strong>64</strong></div><br><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання можливо пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7526" onclick="showComment(7526)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7526" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/3/" target="_blank">Завдання відкритої форми з короткою відповіддю (1 вид)</a> 
			</div>
			<!-- <span>64 => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q46" class="task-card">
			<div class="counter">Завдання 46</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/76/7643/1_matematika2015_22.png" width="560" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
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
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_7643" onclick="showComment(7643)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_7643" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1e;2c;3b;4a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q47" class="task-card">
			<div class="counter">Завдання 47</div>
			<div class="question"><p><img width="528" height="272" alt="" src="/doc/images/znotest/81/8189/1_matematika_22.jpg"></p></div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_8189" onclick="showComment(8189)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_8189" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2c;3a;4e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q48" class="task-card">
			<div class="counter">Завдання 48</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/92/9232/matematika_2016_1.png" width="597" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9232" onclick="showComment(9232)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9232" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q49" class="task-card">
			<div class="counter">Завдання 49</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/92/9253/1_matematika_2016_22.png" width="561" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker ok"></span></label></td>
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
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9253" onclick="showComment(9253)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9253" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1a;2c;3e;4d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q50" class="task-card">
			<div class="counter">Завдання 50</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/94/9448/1_matematika_2016_22.png" width="551" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
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
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_9448" onclick="showComment(9448)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_9448" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1e;2a;3d;4b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q51" class="task-card">
			<div class="counter">Завдання 51</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/108/10832/ds-math-2016-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10832" onclick="showComment(10832)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10832" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q52" class="task-card">
			<div class="counter">Завдання 52</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/108/10853/ds-math-2016-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_10853" onclick="showComment(10853)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_10853" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1c;2e;3a;4d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q53" class="task-card">
			<div class="counter">Завдання 53</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/120/12065/os-math-2017-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12065" onclick="showComment(12065)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12065" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q54" class="task-card">
			<div class="counter">Завдання 54</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/120/12082/os-math-2017-18.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12082" onclick="showComment(12082)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12082" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q55" class="task-card">
			<div class="counter">Завдання 55</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/120/12086/os-math-2017-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12086" onclick="showComment(12086)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12086" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1c;2a;3d;4b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q56" class="task-card">
			<div class="counter">Завдання 56</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/125/12507/ds-math-2017-06.png" width="601" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12507" onclick="showComment(12507)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12507" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q57" class="task-card">
			<div class="counter">Завдання 57</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/125/12518/ds-math-2017-17.png" width="602" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12518" onclick="showComment(12518)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12518" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q58" class="task-card">
			<div class="counter">Завдання 58</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/125/12523/ds-math-2017-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
			<div class="q-info">Правильна відповідь:</div><!--  4.(4х5)  5.(4х4)  10.(5х4) - (4) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_12523" onclick="showComment(12523)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_12523" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1e;2b;3d;4c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q59" class="task-card">
			<div class="counter">Завдання 59</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/142/14235/pr-math-2018-01_1.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14235" onclick="showComment(14235)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14235" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q60" class="task-card">
			<div class="counter">Завдання 60</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/142/14239/pr-math-2018-05.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14239" onclick="showComment(14239)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14239" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q61" class="task-card">
			<div class="counter">Завдання 61</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/142/14256/pr-math-2018-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14256" onclick="showComment(14256)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14256" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2a;3d;4e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q62" class="task-card">
			<div class="counter">Завдання 62</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/143/14306/os-math-2008-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14306" onclick="showComment(14306)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14306" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q63" class="task-card">
			<div class="counter">Завдання 63</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/143/14307/os-math-2008-02.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14307" onclick="showComment(14307)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14307" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q64" class="task-card">
			<div class="counter">Завдання 64</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/143/14312/os-math-2008-07.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14312" onclick="showComment(14312)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14312" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q65" class="task-card">
			<div class="counter">Завдання 65</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/145/14523/os-math-2007-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14523" onclick="showComment(14523)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14523" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q66" class="task-card">
			<div class="counter">Завдання 66</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/145/14543/os-math-2007-21.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><div class="q-info">Відповідь: <strong></strong></div><!-- 8-9 (8) -->
				<br>
				<div class="q-info">Правильна відповідь: <strong>-5</strong></div><br><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання можливо пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14543" onclick="showComment(14543)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14543" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/3/" target="_blank">Завдання відкритої форми з короткою відповіддю (1 вид)</a> 
			</div>
			<!-- <span>-5 => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q67" class="task-card">
			<div class="counter">Завдання 67</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/146/14617/os-math-2018-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_14617" onclick="showComment(14617)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_14617" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2a;3d;4e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q68" class="task-card">
			<div class="counter">Завдання 68</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/152/15235/ds-math-2018-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_15235" onclick="showComment(15235)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_15235" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q69" class="task-card">
			<div class="counter">Завдання 69</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/152/15237/ds-math-2018-03.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_15237" onclick="showComment(15237)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_15237" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q70" class="task-card">
			<div class="counter">Завдання 70</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/152/15256/ds-math-2018-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_15256" onclick="showComment(15256)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_15256" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1a;2e;3d;4b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q71" class="task-card">
			<div class="counter">Завдання 71</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/165/16598/pr-math-2019-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_16598" onclick="showComment(16598)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_16598" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q72" class="task-card">
			<div class="counter">Завдання 72</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/166/16614/pr-math-2019-17.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_16614" onclick="showComment(16614)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_16614" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q73" class="task-card">
			<div class="counter">Завдання 73</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/170/17082/os-math-2019-22.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="">
				</div>
				<div class="answers" style="">
			</div><br>
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
				<td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
				<tr>
				<th class="r">4</th>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr></tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17082" onclick="showComment(17082)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17082" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1b;2e;3d;4a => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q74" class="task-card">
			<div class="counter">Завдання 74</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/176/17642/ds-math-2019-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17642" onclick="showComment(17642)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17642" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>b => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q75" class="task-card">
			<div class="counter">Завдання 75</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/176/17656/ds-math-2019-15.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_17656" onclick="showComment(17656)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_17656" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>d => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q76" class="task-card">
			<div class="counter">Завдання 76</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/194/19486/pr-math-2020-01.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_19486" onclick="showComment(19486)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_19486" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>e => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q77" class="task-card">
			<div class="counter">Завдання 77</div>
			<div class="question"><p><img alt="" src="/doc/images/znotest/199/19961/os-math-2020-17.png" width="600" style="height: auto;"></p>
			</div><br>
			<div class="answers" style="width: 100%"><br></div><br><!-- 1 -->
				<div class="q-info">Правильна відповідь:</div>
				<br><table class="select-answers-variants">
					<tbody><tr><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
					<tr><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker ok"></span></label></td><td><label><span class="marker"></span></label></td><td><label><span class="marker"></span></label></td></tr>
					</tbody></table><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_19961" onclick="showComment(19961)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_19961" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/1/" target="_blank">Завдання з вибором однієї правильної відповіді</a> 
			</div>
			<!-- <span>c => </span> -->
			</div>
			
			<!-- abc=0 -->
			<div id="q78" class="task-card">
			<div class="counter">Завдання 78</div>
			<div class="question"><p>Установіть відповідність між виразом (1–3) та проміжком (А&nbsp;–&nbsp;Д), якому належить його значення. </p></div><br>
			<div class="answers" style="width: 50%"><div class="quest-title"><i>Вираз</i>:</div><div class="answer"><span class="marker">1</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="12" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="10.184ex" height="2.26ex" role="img" focusable="false" viewBox="0 -749.5 4501.1 999" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.564ex;"><defs><path id="MJX-13-TEX-N-7C" d="M139 -249H137Q125 -249 119 -235V251L120 737Q130 750 139 750Q152 750 159 735V-235Q151 -249 141 -249H139Z"></path><path id="MJX-13-TEX-N-2212" d="M84 237T84 250T98 270H679Q694 262 694 250T679 230H98Q84 237 84 250Z"></path><path id="MJX-13-TEX-N-31" d="M213 578L200 573Q186 568 160 563T102 556H83V602H102Q149 604 189 617T245 641T273 663Q275 666 285 666Q294 666 302 660V361L303 61Q310 54 315 52T339 48T401 46H427V0H416Q395 3 257 3Q121 3 100 0H88V46H114Q136 46 152 46T177 47T193 50T201 52T207 57T213 61V578Z"></path><path id="MJX-13-TEX-N-2C" d="M78 35T78 60T94 103T137 121Q165 121 187 96T210 8Q210 -27 201 -60T180 -117T154 -158T130 -185T117 -194Q113 -194 104 -185T95 -172Q95 -168 106 -156T131 -126T157 -76T173 -3V9L172 8Q170 7 167 6T161 3T152 1T140 0Q113 0 96 17Z"></path><path id="MJX-13-TEX-N-36" d="M42 313Q42 476 123 571T303 666Q372 666 402 630T432 550Q432 525 418 510T379 495Q356 495 341 509T326 548Q326 592 373 601Q351 623 311 626Q240 626 194 566Q147 500 147 364L148 360Q153 366 156 373Q197 433 263 433H267Q313 433 348 414Q372 400 396 374T435 317Q456 268 456 210V192Q456 169 451 149Q440 90 387 34T253 -22Q225 -22 199 -14T143 16T92 75T56 172T42 313ZM257 397Q227 397 205 380T171 335T154 278T148 216Q148 133 160 97T198 39Q222 21 251 21Q302 21 329 59Q342 77 347 104T352 209Q352 289 347 316T329 361Q302 397 257 397Z"></path><path id="MJX-13-TEX-N-2B" d="M56 237T56 250T70 270H369V420L370 570Q380 583 389 583Q402 583 409 568V270H707Q722 262 722 250T707 230H409V-68Q401 -82 391 -82H389H387Q375 -82 369 -68V230H70Q56 237 56 250Z"></path><path id="MJX-13-TEX-N-32" d="M109 429Q82 429 66 447T50 491Q50 562 103 614T235 666Q326 666 387 610T449 465Q449 422 429 383T381 315T301 241Q265 210 201 149L142 93L218 92Q375 92 385 97Q392 99 409 186V189H449V186Q448 183 436 95T421 3V0H50V19V31Q50 38 56 46T86 81Q115 113 136 137Q145 147 170 174T204 211T233 244T261 278T284 308T305 340T320 369T333 401T340 431T343 464Q343 527 309 573T212 619Q179 619 154 602T119 569T109 550Q109 549 114 549Q132 549 151 535T170 489Q170 464 154 447T109 429Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo" transform="translate(0 -0.5)"><use data-c="7C" xlink:href="#MJX-13-TEX-N-7C"></use></g><g data-mml-node="mo" transform="translate(278,0)"><use data-c="2212" xlink:href="#MJX-13-TEX-N-2212"></use></g><g data-mml-node="mn" transform="translate(1056,0)"><use data-c="31" xlink:href="#MJX-13-TEX-N-31"></use></g><g data-mml-node="mo" transform="translate(1556,0)"><use data-c="2C" xlink:href="#MJX-13-TEX-N-2C"></use></g><g data-mml-node="mn" transform="translate(2000.7,0)"><use data-c="36" xlink:href="#MJX-13-TEX-N-36"></use></g><g data-mml-node="TeXAtom" data-mjx-texclass="ORD" transform="translate(2500.7,0)"><g data-mml-node="mo" transform="translate(0 -0.5)"><use data-c="7C" xlink:href="#MJX-13-TEX-N-7C"></use></g></g><g data-mml-node="mo" transform="translate(3000.9,0)"><use data-c="2B" xlink:href="#MJX-13-TEX-N-2B"></use></g><g data-mml-node="mn" transform="translate(4001.1,0)"><use data-c="32" xlink:href="#MJX-13-TEX-N-32"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">|</mo><mo>−</mo><mn>1</mn><mo>,</mo><mn>6</mn><mrow data-mjx-texclass="ORD"><mo stretchy="false">|</mo></mrow><mo>+</mo><mn>2</mn></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">2</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="13" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="3.96ex" height="3.799ex" role="img" focusable="false" viewBox="0 -1089.5 1750.3 1679.1" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -1.334ex;"><defs><path id="MJX-14-TEX-N-221A" d="M95 178Q89 178 81 186T72 200T103 230T169 280T207 309Q209 311 212 311H213Q219 311 227 294T281 177Q300 134 312 108L397 -77Q398 -77 501 136T707 565T814 786Q820 800 834 800Q841 800 846 794T853 782V776L620 293L385 -193Q381 -200 366 -200Q357 -200 354 -197Q352 -195 256 15L160 225L144 214Q129 202 113 190T95 178Z"></path><path id="MJX-14-TEX-N-32" d="M109 429Q82 429 66 447T50 491Q50 562 103 614T235 666Q326 666 387 610T449 465Q449 422 429 383T381 315T301 241Q265 210 201 149L142 93L218 92Q375 92 385 97Q392 99 409 186V189H449V186Q448 183 436 95T421 3V0H50V19V31Q50 38 56 46T86 81Q115 113 136 137Q145 147 170 174T204 211T233 244T261 278T284 308T305 340T320 369T333 401T340 431T343 464Q343 527 309 573T212 619Q179 619 154 602T119 569T109 550Q109 549 114 549Q132 549 151 535T170 489Q170 464 154 447T109 429Z"></path><path id="MJX-14-TEX-N-34" d="M462 0Q444 3 333 3Q217 3 199 0H190V46H221Q241 46 248 46T265 48T279 53T286 61Q287 63 287 115V165H28V211L179 442Q332 674 334 675Q336 677 355 677H373L379 671V211H471V165H379V114Q379 73 379 66T385 54Q393 47 442 46H471V0H462ZM293 211V545L74 212L183 211H293Z"></path><path id="MJX-14-TEX-N-33" d="M127 463Q100 463 85 480T69 524Q69 579 117 622T233 665Q268 665 277 664Q351 652 390 611T430 522Q430 470 396 421T302 350L299 348Q299 347 308 345T337 336T375 315Q457 262 457 175Q457 96 395 37T238 -22Q158 -22 100 21T42 130Q42 158 60 175T105 193Q133 193 151 175T169 130Q169 119 166 110T159 94T148 82T136 74T126 70T118 67L114 66Q165 21 238 21Q293 21 321 74Q338 107 338 175V195Q338 290 274 322Q259 328 213 329L171 330L168 332Q166 335 166 348Q166 366 174 366Q202 366 232 371Q266 376 294 413T322 525V533Q322 590 287 612Q265 626 240 626Q208 626 181 615T143 592T132 580H135Q138 579 143 578T153 573T165 566T175 555T183 540T186 520Q186 498 172 481T127 463Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mfrac"><g data-mml-node="msqrt" transform="translate(220,406.5) scale(0.707)"><g transform="translate(853,0)"><g data-mml-node="mn"><use data-c="32" xlink:href="#MJX-14-TEX-N-32"></use><use data-c="34" xlink:href="#MJX-14-TEX-N-34" transform="translate(500,0)"></use></g></g><g data-mml-node="mo" transform="translate(0,88.4)"><use data-c="221A" xlink:href="#MJX-14-TEX-N-221A"></use></g><rect width="1000" height="42.4" x="853" y="846"></rect></g><g data-mml-node="msqrt" transform="translate(396.8,-511) scale(0.707)"><g transform="translate(853,0)"><g data-mml-node="mn"><use data-c="33" xlink:href="#MJX-14-TEX-N-33"></use></g></g><g data-mml-node="mo" transform="translate(0,71.4)"><use data-c="221A" xlink:href="#MJX-14-TEX-N-221A"></use></g><rect width="500" height="42.4" x="853" y="829"></rect></g><rect width="1510.3" height="60" x="120" y="220"></rect></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mfrac><msqrt><mn>24</mn></msqrt><msqrt><mn>3</mn></msqrt></mfrac></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">3</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="14" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="6.995ex" height="3.257ex" role="img" focusable="false" viewBox="0 -1078.9 3091.6 1439.5" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.816ex;"><defs><path id="MJX-15-TEX-N-32" d="M109 429Q82 429 66 447T50 491Q50 562 103 614T235 666Q326 666 387 610T449 465Q449 422 429 383T381 315T301 241Q265 210 201 149L142 93L218 92Q375 92 385 97Q392 99 409 186V189H449V186Q448 183 436 95T421 3V0H50V19V31Q50 38 56 46T86 81Q115 113 136 137Q145 147 170 174T204 211T233 244T261 278T284 308T305 340T320 369T333 401T340 431T343 464Q343 527 309 573T212 619Q179 619 154 602T119 569T109 550Q109 549 114 549Q132 549 151 535T170 489Q170 464 154 447T109 429Z"></path><path id="MJX-15-TEX-N-63" d="M370 305T349 305T313 320T297 358Q297 381 312 396Q317 401 317 402T307 404Q281 408 258 408Q209 408 178 376Q131 329 131 219Q131 137 162 90Q203 29 272 29Q313 29 338 55T374 117Q376 125 379 127T395 129H409Q415 123 415 120Q415 116 411 104T395 71T366 33T318 2T249 -11Q163 -11 99 53T34 214Q34 318 99 383T250 448T370 421T404 357Q404 334 387 320Z"></path><path id="MJX-15-TEX-N-6F" d="M28 214Q28 309 93 378T250 448Q340 448 405 380T471 215Q471 120 407 55T250 -10Q153 -10 91 57T28 214ZM250 30Q372 30 372 193V225V250Q372 272 371 288T364 326T348 362T317 390T268 410Q263 411 252 411Q222 411 195 399Q152 377 139 338T126 246V226Q126 130 145 91Q177 30 250 30Z"></path><path id="MJX-15-TEX-N-73" d="M295 316Q295 356 268 385T190 414Q154 414 128 401Q98 382 98 349Q97 344 98 336T114 312T157 287Q175 282 201 278T245 269T277 256Q294 248 310 236T342 195T359 133Q359 71 321 31T198 -10H190Q138 -10 94 26L86 19L77 10Q71 4 65 -1L54 -11H46H42Q39 -11 33 -5V74V132Q33 153 35 157T45 162H54Q66 162 70 158T75 146T82 119T101 77Q136 26 198 26Q295 26 295 104Q295 133 277 151Q257 175 194 187T111 210Q75 227 54 256T33 318Q33 357 50 384T93 424T143 442T187 447H198Q238 447 268 432L283 424L292 431Q302 440 314 448H322H326Q329 448 335 442V310L329 304H301Q295 310 295 316Z"></path><path id="MJX-15-TEX-N-2061" d=""></path><path id="MJX-15-TEX-N-33" d="M127 463Q100 463 85 480T69 524Q69 579 117 622T233 665Q268 665 277 664Q351 652 390 611T430 522Q430 470 396 421T302 350L299 348Q299 347 308 345T337 336T375 315Q457 262 457 175Q457 96 395 37T238 -22Q158 -22 100 21T42 130Q42 158 60 175T105 193Q133 193 151 175T169 130Q169 119 166 110T159 94T148 82T136 74T126 70T118 67L114 66Q165 21 238 21Q293 21 321 74Q338 107 338 175V195Q338 290 274 322Q259 328 213 329L171 330L168 332Q166 335 166 348Q166 366 174 366Q202 366 232 371Q266 376 294 413T322 525V533Q322 590 287 612Q265 626 240 626Q208 626 181 615T143 592T132 580H135Q138 579 143 578T153 573T165 566T175 555T183 540T186 520Q186 498 172 481T127 463Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mn"><use data-c="32" xlink:href="#MJX-15-TEX-N-32"></use></g><g data-mml-node="mi" transform="translate(666.7,0)"><use data-c="63" xlink:href="#MJX-15-TEX-N-63"></use><use data-c="6F" xlink:href="#MJX-15-TEX-N-6F" transform="translate(444,0)"></use><use data-c="73" xlink:href="#MJX-15-TEX-N-73" transform="translate(944,0)"></use></g><g data-mml-node="mo" transform="translate(2004.7,0)"><use data-c="2061" xlink:href="#MJX-15-TEX-N-2061"></use></g><g data-mml-node="mfrac" transform="translate(2171.3,0)"><g data-mml-node="mi" transform="translate(220,495.6) scale(0.778)"><text data-variant="bold" transform="scale(1,-1)" font-size="832.2px">𝛑</text></g><g data-mml-node="mn" transform="translate(283.4,-345) scale(0.707)"><use data-c="33" xlink:href="#MJX-15-TEX-N-33"></use></g><rect width="680.3" height="60" x="120" y="220"></rect></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mn>2</mn><mi>cos</mi><mo data-mjx-texclass="NONE">⁡</mo><mfrac><mi style="font-style:normal;font-weight:bold;font-size:1.1em">π</mi><mn>3</mn></mfrac></math></mjx-assistive-mml></mjx-container></div>
				</div>
				<div class="answers" style="width: 50%">
			<div class="quest-title"><i>Проміжок</i>:</div><div class="answer"><span class="marker">А</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="15" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="8.486ex" height="2.262ex" role="img" focusable="false" viewBox="0 -750 3750.7 1000" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.566ex;"><defs><path id="MJX-16-TEX-N-28" d="M94 250Q94 319 104 381T127 488T164 576T202 643T244 695T277 729T302 750H315H319Q333 750 333 741Q333 738 316 720T275 667T226 581T184 443T167 250T184 58T225 -81T274 -167T316 -220T333 -241Q333 -250 318 -250H315H302L274 -226Q180 -141 137 -14T94 250Z"></path><path id="MJX-16-TEX-N-2212" d="M84 237T84 250T98 270H679Q694 262 694 250T679 230H98Q84 237 84 250Z"></path><path id="MJX-16-TEX-N-221E" d="M55 217Q55 305 111 373T254 442Q342 442 419 381Q457 350 493 303L507 284L514 294Q618 442 747 442Q833 442 888 374T944 214Q944 128 889 59T743 -11Q657 -11 580 50Q542 81 506 128L492 147L485 137Q381 -11 252 -11Q166 -11 111 57T55 217ZM907 217Q907 285 869 341T761 397Q740 397 720 392T682 378T648 359T619 335T594 310T574 285T559 263T548 246L543 238L574 198Q605 158 622 138T664 94T714 61T765 51Q827 51 867 100T907 217ZM92 214Q92 145 131 89T239 33Q357 33 456 193L425 233Q364 312 334 337Q285 380 233 380Q171 380 132 331T92 214Z"></path><path id="MJX-16-TEX-N-3B" d="M78 370Q78 394 95 412T138 430Q162 430 180 414T199 371Q199 346 182 328T139 310T96 327T78 370ZM78 60Q78 85 94 103T137 121Q202 121 202 8Q202 -44 183 -94T144 -169T118 -194Q115 -194 106 -186T95 -174Q94 -171 107 -155T137 -107T160 -38Q161 -32 162 -22T165 -4T165 4Q165 5 161 4T142 0Q110 0 94 18T78 60Z"></path><path id="MJX-16-TEX-N-A0" d=""></path><path id="MJX-16-TEX-N-30" d="M96 585Q152 666 249 666Q297 666 345 640T423 548Q460 465 460 320Q460 165 417 83Q397 41 362 16T301 -15T250 -22Q224 -22 198 -16T137 16T82 83Q39 165 39 320Q39 494 96 585ZM321 597Q291 629 250 629Q208 629 178 597Q153 571 145 525T137 333Q137 175 145 125T181 46Q209 16 250 16Q290 16 318 46Q347 76 354 130T362 333Q362 478 354 524T321 597Z"></path><path id="MJX-16-TEX-N-29" d="M60 749L64 750Q69 750 74 750H86L114 726Q208 641 251 514T294 250Q294 182 284 119T261 12T224 -76T186 -143T145 -194T113 -227T90 -246Q87 -249 86 -250H74Q66 -250 63 -250T58 -247T55 -238Q56 -237 66 -225Q221 -64 221 250T66 725Q56 737 55 738Q55 746 60 749Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo"><use data-c="28" xlink:href="#MJX-16-TEX-N-28"></use></g><g data-mml-node="mo" transform="translate(389,0)"><use data-c="2212" xlink:href="#MJX-16-TEX-N-2212"></use></g><g data-mml-node="mi" transform="translate(1167,0)"><use data-c="221E" xlink:href="#MJX-16-TEX-N-221E"></use></g><g data-mml-node="mo" transform="translate(2167,0)"><use data-c="3B" xlink:href="#MJX-16-TEX-N-3B"></use></g><g data-mml-node="mtext" transform="translate(2611.7,0)"><use data-c="A0" xlink:href="#MJX-16-TEX-N-A0"></use></g><g data-mml-node="mn" transform="translate(2861.7,0)"><use data-c="30" xlink:href="#MJX-16-TEX-N-30"></use></g><g data-mml-node="mo" transform="translate(3361.7,0)"><use data-c="29" xlink:href="#MJX-16-TEX-N-29"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">(</mo><mo>−</mo><mi mathvariant="normal">∞</mi><mo>;</mo><mtext>&nbsp;</mtext><mn>0</mn><mo stretchy="false">)</mo></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">Б</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="16" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="5.343ex" height="2.262ex" role="img" focusable="false" viewBox="0 -750 2361.7 1000" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.566ex;"><defs><path id="MJX-17-TEX-N-5B" d="M118 -250V750H255V710H158V-210H255V-250H118Z"></path><path id="MJX-17-TEX-N-30" d="M96 585Q152 666 249 666Q297 666 345 640T423 548Q460 465 460 320Q460 165 417 83Q397 41 362 16T301 -15T250 -22Q224 -22 198 -16T137 16T82 83Q39 165 39 320Q39 494 96 585ZM321 597Q291 629 250 629Q208 629 178 597Q153 571 145 525T137 333Q137 175 145 125T181 46Q209 16 250 16Q290 16 318 46Q347 76 354 130T362 333Q362 478 354 524T321 597Z"></path><path id="MJX-17-TEX-N-3B" d="M78 370Q78 394 95 412T138 430Q162 430 180 414T199 371Q199 346 182 328T139 310T96 327T78 370ZM78 60Q78 85 94 103T137 121Q202 121 202 8Q202 -44 183 -94T144 -169T118 -194Q115 -194 106 -186T95 -174Q94 -171 107 -155T137 -107T160 -38Q161 -32 162 -22T165 -4T165 4Q165 5 161 4T142 0Q110 0 94 18T78 60Z"></path><path id="MJX-17-TEX-N-A0" d=""></path><path id="MJX-17-TEX-N-31" d="M213 578L200 573Q186 568 160 563T102 556H83V602H102Q149 604 189 617T245 641T273 663Q275 666 285 666Q294 666 302 660V361L303 61Q310 54 315 52T339 48T401 46H427V0H416Q395 3 257 3Q121 3 100 0H88V46H114Q136 46 152 46T177 47T193 50T201 52T207 57T213 61V578Z"></path><path id="MJX-17-TEX-N-29" d="M60 749L64 750Q69 750 74 750H86L114 726Q208 641 251 514T294 250Q294 182 284 119T261 12T224 -76T186 -143T145 -194T113 -227T90 -246Q87 -249 86 -250H74Q66 -250 63 -250T58 -247T55 -238Q56 -237 66 -225Q221 -64 221 250T66 725Q56 737 55 738Q55 746 60 749Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo"><use data-c="5B" xlink:href="#MJX-17-TEX-N-5B"></use></g><g data-mml-node="mn" transform="translate(278,0)"><use data-c="30" xlink:href="#MJX-17-TEX-N-30"></use></g><g data-mml-node="mo" transform="translate(778,0)"><use data-c="3B" xlink:href="#MJX-17-TEX-N-3B"></use></g><g data-mml-node="mtext" transform="translate(1222.7,0)"><use data-c="A0" xlink:href="#MJX-17-TEX-N-A0"></use></g><g data-mml-node="mn" transform="translate(1472.7,0)"><use data-c="31" xlink:href="#MJX-17-TEX-N-31"></use></g><g data-mml-node="mo" transform="translate(1972.7,0)"><use data-c="29" xlink:href="#MJX-17-TEX-N-29"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">[</mo><mn>0</mn><mo>;</mo><mtext>&nbsp;</mtext><mn>1</mn><mo stretchy="false">)</mo></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">В</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="17" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="5.343ex" height="2.262ex" role="img" focusable="false" viewBox="0 -750 2361.7 1000" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.566ex;"><defs><path id="MJX-18-TEX-N-5B" d="M118 -250V750H255V710H158V-210H255V-250H118Z"></path><path id="MJX-18-TEX-N-31" d="M213 578L200 573Q186 568 160 563T102 556H83V602H102Q149 604 189 617T245 641T273 663Q275 666 285 666Q294 666 302 660V361L303 61Q310 54 315 52T339 48T401 46H427V0H416Q395 3 257 3Q121 3 100 0H88V46H114Q136 46 152 46T177 47T193 50T201 52T207 57T213 61V578Z"></path><path id="MJX-18-TEX-N-3B" d="M78 370Q78 394 95 412T138 430Q162 430 180 414T199 371Q199 346 182 328T139 310T96 327T78 370ZM78 60Q78 85 94 103T137 121Q202 121 202 8Q202 -44 183 -94T144 -169T118 -194Q115 -194 106 -186T95 -174Q94 -171 107 -155T137 -107T160 -38Q161 -32 162 -22T165 -4T165 4Q165 5 161 4T142 0Q110 0 94 18T78 60Z"></path><path id="MJX-18-TEX-N-A0" d=""></path><path id="MJX-18-TEX-N-32" d="M109 429Q82 429 66 447T50 491Q50 562 103 614T235 666Q326 666 387 610T449 465Q449 422 429 383T381 315T301 241Q265 210 201 149L142 93L218 92Q375 92 385 97Q392 99 409 186V189H449V186Q448 183 436 95T421 3V0H50V19V31Q50 38 56 46T86 81Q115 113 136 137Q145 147 170 174T204 211T233 244T261 278T284 308T305 340T320 369T333 401T340 431T343 464Q343 527 309 573T212 619Q179 619 154 602T119 569T109 550Q109 549 114 549Q132 549 151 535T170 489Q170 464 154 447T109 429Z"></path><path id="MJX-18-TEX-N-29" d="M60 749L64 750Q69 750 74 750H86L114 726Q208 641 251 514T294 250Q294 182 284 119T261 12T224 -76T186 -143T145 -194T113 -227T90 -246Q87 -249 86 -250H74Q66 -250 63 -250T58 -247T55 -238Q56 -237 66 -225Q221 -64 221 250T66 725Q56 737 55 738Q55 746 60 749Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo"><use data-c="5B" xlink:href="#MJX-18-TEX-N-5B"></use></g><g data-mml-node="mn" transform="translate(278,0)"><use data-c="31" xlink:href="#MJX-18-TEX-N-31"></use></g><g data-mml-node="mo" transform="translate(778,0)"><use data-c="3B" xlink:href="#MJX-18-TEX-N-3B"></use></g><g data-mml-node="mtext" transform="translate(1222.7,0)"><use data-c="A0" xlink:href="#MJX-18-TEX-N-A0"></use></g><g data-mml-node="mn" transform="translate(1472.7,0)"><use data-c="32" xlink:href="#MJX-18-TEX-N-32"></use></g><g data-mml-node="mo" transform="translate(1972.7,0)"><use data-c="29" xlink:href="#MJX-18-TEX-N-29"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">[</mo><mn>1</mn><mo>;</mo><mtext>&nbsp;</mtext><mn>2</mn><mo stretchy="false">)</mo></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">Г</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="18" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="5.343ex" height="2.262ex" role="img" focusable="false" viewBox="0 -750 2361.7 1000" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.566ex;"><defs><path id="MJX-19-TEX-N-5B" d="M118 -250V750H255V710H158V-210H255V-250H118Z"></path><path id="MJX-19-TEX-N-32" d="M109 429Q82 429 66 447T50 491Q50 562 103 614T235 666Q326 666 387 610T449 465Q449 422 429 383T381 315T301 241Q265 210 201 149L142 93L218 92Q375 92 385 97Q392 99 409 186V189H449V186Q448 183 436 95T421 3V0H50V19V31Q50 38 56 46T86 81Q115 113 136 137Q145 147 170 174T204 211T233 244T261 278T284 308T305 340T320 369T333 401T340 431T343 464Q343 527 309 573T212 619Q179 619 154 602T119 569T109 550Q109 549 114 549Q132 549 151 535T170 489Q170 464 154 447T109 429Z"></path><path id="MJX-19-TEX-N-3B" d="M78 370Q78 394 95 412T138 430Q162 430 180 414T199 371Q199 346 182 328T139 310T96 327T78 370ZM78 60Q78 85 94 103T137 121Q202 121 202 8Q202 -44 183 -94T144 -169T118 -194Q115 -194 106 -186T95 -174Q94 -171 107 -155T137 -107T160 -38Q161 -32 162 -22T165 -4T165 4Q165 5 161 4T142 0Q110 0 94 18T78 60Z"></path><path id="MJX-19-TEX-N-A0" d=""></path><path id="MJX-19-TEX-N-33" d="M127 463Q100 463 85 480T69 524Q69 579 117 622T233 665Q268 665 277 664Q351 652 390 611T430 522Q430 470 396 421T302 350L299 348Q299 347 308 345T337 336T375 315Q457 262 457 175Q457 96 395 37T238 -22Q158 -22 100 21T42 130Q42 158 60 175T105 193Q133 193 151 175T169 130Q169 119 166 110T159 94T148 82T136 74T126 70T118 67L114 66Q165 21 238 21Q293 21 321 74Q338 107 338 175V195Q338 290 274 322Q259 328 213 329L171 330L168 332Q166 335 166 348Q166 366 174 366Q202 366 232 371Q266 376 294 413T322 525V533Q322 590 287 612Q265 626 240 626Q208 626 181 615T143 592T132 580H135Q138 579 143 578T153 573T165 566T175 555T183 540T186 520Q186 498 172 481T127 463Z"></path><path id="MJX-19-TEX-N-29" d="M60 749L64 750Q69 750 74 750H86L114 726Q208 641 251 514T294 250Q294 182 284 119T261 12T224 -76T186 -143T145 -194T113 -227T90 -246Q87 -249 86 -250H74Q66 -250 63 -250T58 -247T55 -238Q56 -237 66 -225Q221 -64 221 250T66 725Q56 737 55 738Q55 746 60 749Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo"><use data-c="5B" xlink:href="#MJX-19-TEX-N-5B"></use></g><g data-mml-node="mn" transform="translate(278,0)"><use data-c="32" xlink:href="#MJX-19-TEX-N-32"></use></g><g data-mml-node="mo" transform="translate(778,0)"><use data-c="3B" xlink:href="#MJX-19-TEX-N-3B"></use></g><g data-mml-node="mtext" transform="translate(1222.7,0)"><use data-c="A0" xlink:href="#MJX-19-TEX-N-A0"></use></g><g data-mml-node="mn" transform="translate(1472.7,0)"><use data-c="33" xlink:href="#MJX-19-TEX-N-33"></use></g><g data-mml-node="mo" transform="translate(1972.7,0)"><use data-c="29" xlink:href="#MJX-19-TEX-N-29"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">[</mo><mn>2</mn><mo>;</mo><mtext>&nbsp;</mtext><mn>3</mn><mo stretchy="false">)</mo></math></mjx-assistive-mml></mjx-container></div><div class="answer"><span class="marker">Д</span><mjx-container class="MathJax CtxtMenu_Attached_0" jax="SVG" tabindex="0" ctxtmenu_counter="19" style="position: relative;"><svg xmlns="http://www.w3.org/2000/svg" width="9.24ex" height="2.262ex" role="img" focusable="false" viewBox="0 -750 4084.1 1000" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" style="vertical-align: -0.566ex;"><defs><path id="MJX-20-TEX-N-5B" d="M118 -250V750H255V710H158V-210H255V-250H118Z"></path><path id="MJX-20-TEX-N-33" d="M127 463Q100 463 85 480T69 524Q69 579 117 622T233 665Q268 665 277 664Q351 652 390 611T430 522Q430 470 396 421T302 350L299 348Q299 347 308 345T337 336T375 315Q457 262 457 175Q457 96 395 37T238 -22Q158 -22 100 21T42 130Q42 158 60 175T105 193Q133 193 151 175T169 130Q169 119 166 110T159 94T148 82T136 74T126 70T118 67L114 66Q165 21 238 21Q293 21 321 74Q338 107 338 175V195Q338 290 274 322Q259 328 213 329L171 330L168 332Q166 335 166 348Q166 366 174 366Q202 366 232 371Q266 376 294 413T322 525V533Q322 590 287 612Q265 626 240 626Q208 626 181 615T143 592T132 580H135Q138 579 143 578T153 573T165 566T175 555T183 540T186 520Q186 498 172 481T127 463Z"></path><path id="MJX-20-TEX-N-3B" d="M78 370Q78 394 95 412T138 430Q162 430 180 414T199 371Q199 346 182 328T139 310T96 327T78 370ZM78 60Q78 85 94 103T137 121Q202 121 202 8Q202 -44 183 -94T144 -169T118 -194Q115 -194 106 -186T95 -174Q94 -171 107 -155T137 -107T160 -38Q161 -32 162 -22T165 -4T165 4Q165 5 161 4T142 0Q110 0 94 18T78 60Z"></path><path id="MJX-20-TEX-N-A0" d=""></path><path id="MJX-20-TEX-N-2B" d="M56 237T56 250T70 270H369V420L370 570Q380 583 389 583Q402 583 409 568V270H707Q722 262 722 250T707 230H409V-68Q401 -82 391 -82H389H387Q375 -82 369 -68V230H70Q56 237 56 250Z"></path><path id="MJX-20-TEX-N-221E" d="M55 217Q55 305 111 373T254 442Q342 442 419 381Q457 350 493 303L507 284L514 294Q618 442 747 442Q833 442 888 374T944 214Q944 128 889 59T743 -11Q657 -11 580 50Q542 81 506 128L492 147L485 137Q381 -11 252 -11Q166 -11 111 57T55 217ZM907 217Q907 285 869 341T761 397Q740 397 720 392T682 378T648 359T619 335T594 310T574 285T559 263T548 246L543 238L574 198Q605 158 622 138T664 94T714 61T765 51Q827 51 867 100T907 217ZM92 214Q92 145 131 89T239 33Q357 33 456 193L425 233Q364 312 334 337Q285 380 233 380Q171 380 132 331T92 214Z"></path><path id="MJX-20-TEX-N-29" d="M60 749L64 750Q69 750 74 750H86L114 726Q208 641 251 514T294 250Q294 182 284 119T261 12T224 -76T186 -143T145 -194T113 -227T90 -246Q87 -249 86 -250H74Q66 -250 63 -250T58 -247T55 -238Q56 -237 66 -225Q221 -64 221 250T66 725Q56 737 55 738Q55 746 60 749Z"></path></defs><g stroke="currentColor" fill="currentColor" stroke-width="0" transform="scale(1,-1)"><g data-mml-node="math"><g data-mml-node="mo"><use data-c="5B" xlink:href="#MJX-20-TEX-N-5B"></use></g><g data-mml-node="mn" transform="translate(278,0)"><use data-c="33" xlink:href="#MJX-20-TEX-N-33"></use></g><g data-mml-node="mo" transform="translate(778,0)"><use data-c="3B" xlink:href="#MJX-20-TEX-N-3B"></use></g><g data-mml-node="mtext" transform="translate(1222.7,0)"><use data-c="A0" xlink:href="#MJX-20-TEX-N-A0"></use></g><g data-mml-node="mo" transform="translate(1694.9,0)"><use data-c="2B" xlink:href="#MJX-20-TEX-N-2B"></use></g><g data-mml-node="mi" transform="translate(2695.1,0)"><use data-c="221E" xlink:href="#MJX-20-TEX-N-221E"></use></g><g data-mml-node="mo" transform="translate(3695.1,0)"><use data-c="29" xlink:href="#MJX-20-TEX-N-29"></use></g></g></g></svg><mjx-assistive-mml unselectable="on" display="inline"><math xmlns="http://www.w3.org/1998/Math/MathML"><mo stretchy="false">[</mo><mn>3</mn><mo>;</mo><mtext>&nbsp;</mtext><mo>+</mo><mi mathvariant="normal">∞</mi><mo stretchy="false">)</mo></math></mjx-assistive-mml></mjx-container></div></div><br>
			<div class="q-info">Правильна відповідь:</div><!-- 13 (13) -->
				<br>
				<table class="select-answers-variants"><tbody><tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr><tr>
				<th class="r">1</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				</tr>
				<tr>
				<th class="r">2</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				</tr>
				<tr>
				<th class="r">3</th>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker ok"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				<td><label><span class="marker"></span></label></td>
				</tr>
				</tbody></table><!-- 13 --><div class="kilk-baliv">Кількість балів: <strong>0</strong>. Завдання пропущено.</div><div class="two-buttons-container">
					<span class="q-btn button-gray explan_open" id="btn_show_26009" onclick="showComment(26009)">Читати коментар</span>
					<div class="description up nopremium">Коментарі доступні лише для зареєстрованих користувачів. <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;&gt;&gt;&gt;</a>.</div>
					<div id="commentar_26009" class="explanation" style="display: none;">
					<b>Обмеження! Придбайте Преміум</b> (у профілі)<br><br></div>
					</div><div class="clear"><!-- --></div>
			<div class="description">Вид завдання: <a href="/dovidka/viditestiv/2/" target="_blank">Завдання на встановлення відповідності (логічні пари)</a> 
			</div>
			<!-- <span>1e;2d;3c => 0</span> -->
			</div>
			
			<div class="q-info question res">
				<div class="blue-block-test-results">
					<div class="test-bal">Максимальна кількість балів: <strong>132</strong></div>
					<div class="test-bal">Набрана кількість балів: <strong>0</strong></div>
					<div class="test-bal">Відсоток правильних: <strong>0%</strong></div>
					<div class="time">Витрачено часу: <strong>1 хв.</strong></div>
					<div class="reit-name"><em><small>На жаль, ваш результат не буде збережено. Придбайте <a href="/premium.html" target="_blank">преміум-акаунт</a> для збереження результатів.<br>Повернутись <a href="https://zno.osvita.ua/mathematics/tema.html">до списку тем</a>.</small></em></div>
				</div>
					<table class="nav-table">
					<tbody><tr>
						<td>
							<a href="https://zno.osvita.ua/mathematics/tag-dijsni_chysla/?1676309069">
								<img src="/doc/i/icon-znovu.png"><span>Пройти тему знову</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/mathematics/tema.html">
								<img src="/doc/i/icon-allquest.png"><span>Всі теми з цього предмета</span>
							</a>
						</td>
						<td>
							<a href="https://zno.osvita.ua/mathematics/">
								<img src="/doc/i/icon-alltest.png"><span>Всі тести з цього предмета</span>
							</a>
						</td>
					</tr>
				</tbody></table>
			</div>
			<div class="q-info question res"><span class="q-btn button-gray q-up" onclick="window.scrollTo(0,150);">На початок сторінки</span></div></div></div>
			
			<div class="clear"></div>
			
			<!-- zno_quest_list_by_tag_all 0.08393 c. -->
			
			
			            </div>
			            <div class="col-right homepage-right-hide">
						
			<!-- banners - banner300 - 1890 -->
			<!--noindex-->
			<div class="block w300 wrapbanner" style="height:600px;">
			<div class="banner" style="height:600px;">
			<!-- id=1 -->
			<div id="admixer_741839645c2346e68867b1f3f0e96a5e_zone_20646_sect_226_site_226"></div><script type="text/javascript" src="https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=74a1f9e1-65c3-4075-a988-90d4b6350625"></script>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner300 0.00108 c. -->
			
			
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
			</script><a href="http://www.bigmir.net/" target="_blank" onclick="img=new Image();img.src=" www.bigmir.net="" ?cl="16796306&quot;;&quot;"><img src="//c.bigmir.net/?v16796821&amp;s16796306&amp;t29&amp;c1&amp;n179188&amp;w0&amp;y0&amp;d24&amp;r1536&amp;fhttps%3A//zno.osvita.ua/mathematics/tema.html" width="160" height="19" border="0" alt="bigmir)net TOP 100" title="bigmir)net TOP 100"></a>
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
			<script>(function(){var js = "window['__CF$cv$params']={r:'798f399a3c51b383',m:'DUTTqXHu84kahlJhpRxgM_4xvHWvgWowPMBCyTRpURI-1676308724-0-AWcjBYNucuAJCpuJkyfAvoSZrUunooncx/TBqP131Rva+dwB06iQnNTALAO8O7BHvWTBiueD+xd82Vw+bXAC27hrDQSkupoPU7UuYKc1l5QtcP2eZ2+LYOfFpCkAgg0MhV5zCcYW/6F+YtLs21ngtcE=',s:[0xd461582a44,0x3e5b0e9838],u:'/cdn-cgi/challenge-platform/h/b'};var now=Date.now()/1000,offset=14400,ts=''+(Math.floor(now)-Math.floor(now%offset)),_cpo=document.createElement('script');_cpo.nonce='',_cpo.src='/cdn-cgi/challenge-platform/h/b/scripts/alpha/invisible.js?ts='+ts,document.getElementsByTagName('head')[0].appendChild(_cpo);";var _0xh = document.createElement('iframe');_0xh.height = 1;_0xh.width = 1;_0xh.style.position = 'absolute';_0xh.style.top = 0;_0xh.style.left = 0;_0xh.style.border = 'none';_0xh.style.visibility = 'hidden';document.body.appendChild(_0xh);function handler() {var _0xi = _0xh.contentDocument || _0xh.contentWindow.document;if (_0xi) {var _0xj = _0xi.createElement('script');_0xj.nonce = '';_0xj.innerHTML = js;_0xi.getElementsByTagName('head')[0].appendChild(_0xj);}}if (document.readyState !== 'loading') {handler();} else if (window.addEventListener) {document.addEventListener('DOMContentLoaded', handler);} else {var prev = document.onreadystatechange || function () {};document.onreadystatechange = function (e) {prev(e);if (document.readyState !== 'loading') {document.onreadystatechange = prev;handler();}};}})();</script><iframe height="1" width="1" style="position: absolute; top: 0px; left: 0px; border: none; visibility: hidden;"></iframe>
			
			
			
			<div style="display: none; visibility: hidden;"><script data-ad-client="ca-pub-7936802855264727" async="null" src="https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script></div><div style="display: none; visibility: hidden;"></div></body> 
			""";
        public static string html2 = """
			 
			<!DOCTYPE html>
			<html lang="uk" prefix="fb: http://ogp.me/ns/fb# og: http://ogp.me/ns#">
			<head>
				<meta charset="utf-8">
			    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no, minimum-scale=1, user-scalable=no">
				<title>Дійсні числа – тести ЗНО/НМТ – завдання з математики – сайт ЗНО.Освіта.UA</title>
				<!-- 0.092511892318726 server 3-->
			<meta name="title" content="Дійсні числа – тести ЗНО/НМТ – завдання з математики – сайт ЗНО.Освіта.UA" />
			<meta http-equiv="Expires" content="Thu, Jan 1 1970 00:00:00 GMT">
			<meta http-equiv="Pragma" content="no-cache">
			<meta http-equiv="Cache-Control" content="no-cache">
			<meta name="referrer" content="origin-when-cross-origin">
			<meta name="format-detection" content="telephone=no">
			<meta http-equiv="Content-language" content="uk" />
			<meta name="description" content="Завдання та тести з теми &quot;Дійсні числа&quot; зовнішнього незалежного оцінювання (ЗНО), національного мультипредметного тесту (НМТ) з математики" />
			<meta name="keywords" content="" />
			<meta property="og:title" content="Дійсні числа – тести ЗНО/НМТ – завдання з математики – сайт ЗНО.Освіта.UA" />
			<meta property="og:description" content="Завдання та тести з теми &quot;Дійсні числа&quot; зовнішнього незалежного оцінювання (ЗНО), національного мультипредметного тесту (НМТ) з математики" />
			<meta property="og:url" content="https://zno.osvita.ua/mathematics/tag-dijsni_chysla/" />
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
				//admixerML.defineSlot({
				//	z: '7b98aa89-284f-4b35-a32a-f6f334259573',
				//	ph: 'admixer_7b98aa89284f4b35a32af6f334259573_zone_5891_sect_226_site_226',
				//	i: 'inv-nets'
				//});
			
			    // CatFish mobile
				//admixerML.defineSlot({
				//	z: '5fce274d-5435-45a5-b87f-69de1b4043c8',
				//	ph: 'admixer_5fce274d543545a5b87f69de1b4043c8_zone_5888_sect_226_site_226',
				//	i: 'inv-nets'
				//});
			
			
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
			<body id="body" class="mathematics">
			
			
			 
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
						
			<!-- news - menu - 1888 -->
					<div class="title-block no-bottom-line">
						<a href="https://zno.osvita.ua" title="ЗНО-ОНЛАЙН"><span class="linkh1">ЗНО-ОНЛАЙН</span></a>
									<div class="description"><h1 class="desc">Завдання за темою з математики</h1></div>
								</div>
			<div id="breadcrumbs" class="breadcrumbs" vocab="http://schema.org/" typeof="BreadcrumbList">
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="1" />
			<a property="item" typeof="WebPage" href="https://zno.osvita.ua"><span property="name">Тести ЗНО онлайн</span></a></span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="2" />
			<a href="https://zno.osvita.ua/mathematics/tema.html" property="item" typeof="WebPage"><span property="name">Математика</span></a>
			</span>
			 / 
			<span property="itemListElement" typeof="ListItem">
			<meta property="position" content="3" />
			<a href="https://zno.osvita.ua/mathematics/tag-koordinati_ta_vektori/" property="item" typeof="WebPage">
			<meta property="name" content="Дійсні числа – тести ЗНО/НМТ – завдання з математики" />
			</a>
			<span>Дійсні числа – тести ЗНО/НМТ – завдання з математики</span>
			</span>
			<!-- tag --></div>
			
			<!-- curpath = /mathematics/tag-koordinati_ta_vektori/ -->
			
			<!-- menu 0.00365 c. -->
			
			
					</div>
				</div>
				
				<div class="container">
			        <div id="main-content">
			            <div class="col-main">
						
			<!-- znotest - zno_quest_list_by_tag_all - 1889 -->
			<!-- setTitle #### -->
			
			
			<style type="text/css">
			.test-title .label{color: #35866e; font-size:inherit; font-weight:normal;}
			</style>
			
			<script type="text/javascript">
			
			var qfirst = 1;
			var list = 0;
			var cnt = 78;
			var total = 78;
			var test_id = 'tag_120';
			var tag_id = 120;
			var quest_id = 1;
			var section = 2;
			var maxball = 132;
			var tpage = 'tag';
			var freetemp = 0;
			
			
			
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
							if( confirm("Збереження поточних відповідей доступно тільки для «Преміум-акаунтів». Умови отримання «Преміум» доступу дивіться у вашому профілі на сайті. \n\nДля продовження роботи над завданнями теми натисніть кнопку «ОК», або натисніть «Відміна» для завершення теми та отримання поточних результатів.") ){ return ; }			
						}else{
							window.savetemp = test_id;
							if(!isPrem()){ if( confirm("Збереження поточних відповідей доступно тільки для «Преміум-акаунтів». Умови отримання «Преміум» доступу дивіться у вашому профілі на сайті. \n\nДля продовження роботи над завданнями теми натисніть кнопку «ОК», або натисніть «Відміна» для завершення теми та отримання поточних результатів.") ){ return ; }}
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
					}else{
						var prs = getStorageItems('section_temp_tag_pr_'+section);
						console.log('temp_tag_'+tag_id+'='+prs[tag_id]);
						if(prs[tag_id]){
							getTempResult(tag_id);
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
			<!-- 1 - 0 - Математика -->
			<span class="label">Предмет:</span>&nbsp;<span class="row">Алгебра і початки аналізу</span><br><!-- 2 - 3 - Алгебра і початки аналізу -->
			<span class="label">Розділ:</span>&nbsp;<span class="row">Числа і вирази</span><br><!-- 3 - 118 - Числа і вирази -->
			<span class="label">Тема:</span>&nbsp;<span class="row">Дійсні числа</span><br><!-- 4 - 119 - Дійсні числа -->
			<span class="label">Кількість завдань:</span>&nbsp;<span class="row">78</span> <!-- 78 -->
			</div>
			
			<div class="tasks-numbers" id="tasks-numbers">
			<span class="number q1 current">1</span><span class="number q2">2</span><span class="number q3">3</span><span class="number q4">4</span><span class="number q5">5</span><span class="number q6">6</span><span class="number q7">7</span><span class="number q8">8</span><span class="number q9">9</span><span class="number q10">10</span><span class="number q11">11</span><span class="number q12">12</span><span class="number q13">13</span><span class="number q14">14</span><span class="number q15">15</span><span class="number q16">16</span><span class="number q17">17</span><span class="number q18">18</span><span class="number q19">19</span><span class="number q20">20</span><span class="number q21">21</span><span class="number q22">22</span><span class="number q23">23</span><span class="number q24">24</span><span class="number q25">25</span><span class="number q26">26</span><span class="number q27">27</span><span class="number q28">28</span><span class="number q29">29</span><span class="number q30">30</span><span class="number q31">31</span><span class="number q32">32</span><span class="number q33">33</span><span class="number q34">34</span><span class="number q35">35</span><span class="number q36">36</span><span class="number q37">37</span><span class="number q38">38</span><span class="number q39">39</span><span class="number q40">40</span><span class="number q41">41</span><span class="number q42">42</span><span class="number q43">43</span><span class="number q44">44</span><span class="number q45">45</span><span class="number q46">46</span><span class="number q47">47</span><span class="number q48">48</span><span class="number q49">49</span><span class="number q50">50</span><span class="number q51">51</span><span class="number q52">52</span><span class="number q53">53</span><span class="number q54">54</span><span class="number q55">55</span><span class="number q56">56</span><span class="number q57">57</span><span class="number q58">58</span><span class="number q59">59</span><span class="number q60">60</span><span class="number q61">61</span><span class="number q62">62</span><span class="number q63">63</span><span class="number q64">64</span><span class="number q65">65</span><span class="number q66">66</span><span class="number q67">67</span><span class="number q68">68</span><span class="number q69">69</span><span class="number q70">70</span><span class="number q71">71</span><span class="number q72">72</span><span class="number q73">73</span><span class="number q74">74</span><span class="number q75">75</span><span class="number q76">76</span><span class="number q77">77</span><span class="number q78">78</span></div>
			
			<div id="waiting" style="display:none;"><center>Зачекайте, йде розрахунок...<br><div id="wait"> </div></center></div>
			<div id="waiting2" style="display:none;"></div>
			
			<div id="wrap">
			
			<!-- abc=0 --><!-- out_order=1 --> 
			 
			<div class="task-card current card_4300" style="" id="q1">
			<div class="counter">Завдання 1 з 78</div>
			<form class="q-test" id="q_form_1" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="1">
			<input type="hidden" name="q[tip]" id="q1-tip" value="1">
			<input type="hidden" name="q[id]" value="4300">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="111" alt="" src="/doc/images/znotest/43/4300/matematika_1_1.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_4300" onclick="showComment(4300)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_4300" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/43/4300/desice-os-math-2013-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 1. Завдання: <b>4300</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_4304" style="display:none;" id="q2">
			<div class="counter">Завдання 2 з 78</div>
			<form class="q-test" id="q_form_2" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="2">
			<input type="hidden" name="q[tip]" id="q2-tip" value="1">
			<input type="hidden" name="q[id]" value="4304">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="120" alt="" src="/doc/images/znotest/43/4304/matematika_5.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_4304" onclick="showComment(4304)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_4304" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/43/4304/desice-os-math-2013-05.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 1. Завдання: <b>4304</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=18 --> 
			<div class="task-card card_4319" style="display:none;" id="q3">
			<div class="counter">Завдання 3 з 78</div>
			<form class="q-test" id="q_form_3" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="3">
			<input type="hidden" name="q[tip]" id="q3-tip" value="1">
			<input type="hidden" name="q[id]" value="4319">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="111" alt="" src="/doc/images/znotest/43/4319/matematika_18.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_4319" onclick="showComment(4319)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q18" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_4319" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/43/4319/desice-os-math-2013-18_1.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 1. Завдання: <b>4319</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=3 --> 
			<div class="task-card card_5317" style="display:none;" id="q4">
			<div class="counter">Завдання 4 з 78</div>
			<form class="q-test" id="q_form_4" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="4">
			<input type="hidden" name="q[tip]" id="q4-tip" value="1">
			<input type="hidden" name="q[id]" value="5317">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="128" alt="" src="/doc/images/znotest/53/5317/matematika_3.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_5317" onclick="showComment(5317)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q3" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_5317" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/53/5317/deside-ds-math-2013-03.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 2. Завдання: <b>5317</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=8 --> 
			<div class="task-card card_6081" style="display:none;" id="q5">
			<div class="counter">Завдання 5 з 78</div>
			<form class="q-test" id="q_form_5" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="5">
			<input type="hidden" name="q[tip]" id="q5-tip" value="1">
			<input type="hidden" name="q[id]" value="6081">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/60/6081/matematika_2012_1_8.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6081" onclick="showComment(6081)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q8" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6081" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/60/6081/decide-os-math-2012-08.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 3. Завдання: <b>6081</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=13 --> 
			<div class="task-card card_6102" style="display:none;" id="q6">
			<div class="counter">Завдання 6 з 78</div>
			<form class="q-test" id="q_form_6" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="6">
			<input type="hidden" name="q[tip]" id="q6-tip" value="1">
			<input type="hidden" name="q[id]" value="6102">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="160" alt="" src="/doc/images/znotest/61/6102/matematika_2012-2_13.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6102" onclick="showComment(6102)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q13" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6102" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6102/decide-ds-math-2012-13.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 121. Завдання: <b>6102</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=18 --> 
			<div class="task-card card_6107" style="display:none;" id="q7">
			<div class="counter">Завдання 7 з 78</div>
			<form class="q-test" id="q_form_7" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="7">
			<input type="hidden" name="q[tip]" id="q7-tip" value="1">
			<input type="hidden" name="q[id]" value="6107">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="104" alt="" src="/doc/images/znotest/61/6107/matematika_2012-2_18.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6107" onclick="showComment(6107)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q18" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6107" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6107/decide-ds-math-2012-18.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 121. Завдання: <b>6107</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=2 --> 
			<div class="task-card card_6123" style="display:none;" id="q8">
			<div class="counter">Завдання 8 з 78</div>
			<form class="q-test" id="q_form_8" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="8">
			<input type="hidden" name="q[tip]" id="q8-tip" value="1">
			<input type="hidden" name="q[id]" value="6123">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/61/6123/matematika_2011_2.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6123" onclick="showComment(6123)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q2" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6123" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6123/decide-os-math-2011-02.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 122. Завдання: <b>6123</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=29 --> 
			<div class="task-card card_6150" style="display:none;" id="q9">
			<div class="counter">Завдання 9 з 78</div>
			<form class="q-test" id="q_form_9" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="9">
			<input type="hidden" name="q[tip]" id="q9-tip" value="8">
			<input type="hidden" name="q[id]" value="6150">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/61/6150/matematika_2011_29.png" width="385" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=8 -->
			
			
			
			
			<div class="clear mb10"></div>
			
			
			
			
			<div class="q-info">Впишіть відповідь:</div><!-- 8-9 -->
			<br>
			<input type="text" value="" name="a" class="inptext w250" maxlength="30" />
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6150" onclick="showComment(6150)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q29" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6150" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6150/decide-os-math-2011-29.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 122. Завдання: <b>6150</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=2 --> 
			<div class="task-card card_6158" style="display:none;" id="q10">
			<div class="counter">Завдання 10 з 78</div>
			<form class="q-test" id="q_form_10" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="10">
			<input type="hidden" name="q[tip]" id="q10-tip" value="1">
			<input type="hidden" name="q[id]" value="6158">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="116" alt="" src="/doc/images/znotest/61/6158/1_matematika_2010-I_2.png" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6158" onclick="showComment(6158)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q2" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6158" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6158/decide-os-math-2010-02.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 123. Завдання: <b>6158</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=19 --> 
			<div class="task-card card_6175" style="display:none;" id="q11">
			<div class="counter">Завдання 11 з 78</div>
			<form class="q-test" id="q_form_11" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="11">
			<input type="hidden" name="q[tip]" id="q11-tip" value="1">
			<input type="hidden" name="q[id]" value="6175">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/61/6175/matematika_2010-I_19.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6175" onclick="showComment(6175)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q19" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6175" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6175/decide-os-math-2010-19.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 123. Завдання: <b>6175</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_6182" style="display:none;" id="q12">
			<div class="counter">Завдання 12 з 78</div>
			<form class="q-test" id="q_form_12" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="12">
			<input type="hidden" name="q[tip]" id="q12-tip" value="4">
			<input type="hidden" name="q[id]" value="6182">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="594" height="274" alt="" src="/doc/images/znotest/61/6182/matematika_2010-I_26.png" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6182" onclick="showComment(6182)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6182" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6182/decide-os-math-2010-26.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 123. Завдання: <b>6182</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=19 --> 
			<div class="task-card card_6195" style="display:none;" id="q13">
			<div class="counter">Завдання 13 з 78</div>
			<form class="q-test" id="q_form_13" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="13">
			<input type="hidden" name="q[tip]" id="q13-tip" value="1">
			<input type="hidden" name="q[id]" value="6195">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/61/6195/matematika_2012_1_19.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6195" onclick="showComment(6195)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q19" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6195" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/61/6195/decide-os-math-2012-19.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 3. Завдання: <b>6195</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6211" style="display:none;" id="q14">
			<div class="counter">Завдання 14 з 78</div>
			<form class="q-test" id="q_form_14" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="14">
			<input type="hidden" name="q[tip]" id="q14-tip" value="1">
			<input type="hidden" name="q[id]" value="6211">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="104" alt="" src="/doc/images/znotest/62/6211/matematika_2010-II_1.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6211" onclick="showComment(6211)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6211" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6211/decide-ds-math-2010-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 124. Завдання: <b>6211</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=4 --> 
			<div class="task-card card_6214" style="display:none;" id="q15">
			<div class="counter">Завдання 15 з 78</div>
			<form class="q-test" id="q_form_15" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="15">
			<input type="hidden" name="q[tip]" id="q15-tip" value="1">
			<input type="hidden" name="q[id]" value="6214">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/62/6214/matematika_2010-II_4.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6214" onclick="showComment(6214)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q4" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6214" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6214/decide-ds-math-2010-04.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 124. Завдання: <b>6214</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=11 --> 
			<div class="task-card card_6221" style="display:none;" id="q16">
			<div class="counter">Завдання 16 з 78</div>
			<form class="q-test" id="q_form_16" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="16">
			<input type="hidden" name="q[tip]" id="q16-tip" value="1">
			<input type="hidden" name="q[id]" value="6221">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/62/6221/matematika_2010-II_11.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6221" onclick="showComment(6221)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q11" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6221" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6221/decide-ds-math-2010-11.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 124. Завдання: <b>6221</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_6236" style="display:none;" id="q17">
			<div class="counter">Завдання 17 з 78</div>
			<form class="q-test" id="q_form_17" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="17">
			<input type="hidden" name="q[tip]" id="q17-tip" value="4">
			<input type="hidden" name="q[id]" value="6236">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="591" height="288" alt="" src="/doc/images/znotest/62/6236/matematika_2010-II_26.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6236" onclick="showComment(6236)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6236" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6236/decide-ds-math-2010-26.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 124. Завдання: <b>6236</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6247" style="display:none;" id="q18">
			<div class="counter">Завдання 18 з 78</div>
			<form class="q-test" id="q_form_18" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="18">
			<input type="hidden" name="q[tip]" id="q18-tip" value="1">
			<input type="hidden" name="q[id]" value="6247">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" height="102" src="/doc/images/znotest/62/6247/matematika-01.jpg" width="573" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6247" onclick="showComment(6247)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6247" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6247/deside-pr-math-2014-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 125. Завдання: <b>6247</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=16 --> 
			<div class="task-card card_6262" style="display:none;" id="q19">
			<div class="counter">Завдання 19 з 78</div>
			<form class="q-test" id="q_form_19" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="19">
			<input type="hidden" name="q[tip]" id="q19-tip" value="1">
			<input type="hidden" name="q[id]" value="6262">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/62/6262/1_matematika-16.jpg" width="622" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6262" onclick="showComment(6262)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q16" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6262" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6262/deside-pr-math-2014-16.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 125. Завдання: <b>6262</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=23 --> 
			<div class="task-card card_6269" style="display:none;" id="q20">
			<div class="counter">Завдання 20 з 78</div>
			<form class="q-test" id="q_form_20" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="20">
			<input type="hidden" name="q[tip]" id="q20-tip" value="4">
			<input type="hidden" name="q[id]" value="6269">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/62/6269/1_matematika-23.jpg" width="597" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6269" onclick="showComment(6269)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q23" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6269" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6269/deside-pr-math-2014-23.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 125. Завдання: <b>6269</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=29 --> 
			<div class="task-card card_6275" style="display:none;" id="q21">
			<div class="counter">Завдання 21 з 78</div>
			<form class="q-test" id="q_form_21" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="21">
			<input type="hidden" name="q[tip]" id="q21-tip" value="8">
			<input type="hidden" name="q[id]" value="6275">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/62/6275/1_matematika-29.jpg" width="597" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=8 -->
			
			
			
			
			<div class="clear mb10"></div>
			
			
			
			
			<div class="q-info">Впишіть відповідь:</div><!-- 8-9 -->
			<br>
			<input type="text" value="" name="a" class="inptext w250" maxlength="30" />
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6275" onclick="showComment(6275)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q29" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6275" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6275/deside-pr-math-2014-29.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 125. Завдання: <b>6275</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6281" style="display:none;" id="q22">
			<div class="counter">Завдання 22 з 78</div>
			<form class="q-test" id="q_form_22" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="22">
			<input type="hidden" name="q[tip]" id="q22-tip" value="1">
			<input type="hidden" name="q[id]" value="6281">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="116" alt="" src="/doc/images/znotest/62/6281/1_Matematika_126_1.png" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6281" onclick="showComment(6281)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6281" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/62/6281/deside-pr-math-2013-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 126. Завдання: <b>6281</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6314" style="display:none;" id="q23">
			<div class="counter">Завдання 23 з 78</div>
			<form class="q-test" id="q_form_23" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="23">
			<input type="hidden" name="q[tip]" id="q23-tip" value="1">
			<input type="hidden" name="q[id]" value="6314">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6314/matematika-127_1.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6314" onclick="showComment(6314)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6314" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6314/decide-pr-math-2012-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 127. Завдання: <b>6314</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=17 --> 
			<div class="task-card card_6330" style="display:none;" id="q24">
			<div class="counter">Завдання 24 з 78</div>
			<form class="q-test" id="q_form_24" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="24">
			<input type="hidden" name="q[tip]" id="q24-tip" value="1">
			<input type="hidden" name="q[id]" value="6330">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6330/1_matematika-127_17.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6330" onclick="showComment(6330)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q17" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6330" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6330/decide-pr-math-2012-17.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 127. Завдання: <b>6330</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6346" style="display:none;" id="q25">
			<div class="counter">Завдання 25 з 78</div>
			<form class="q-test" id="q_form_25" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="25">
			<input type="hidden" name="q[tip]" id="q25-tip" value="1">
			<input type="hidden" name="q[id]" value="6346">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="120" alt="" src="/doc/images/znotest/63/6346/matematika_1.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6346" onclick="showComment(6346)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6346" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6346/decide-pr-math-2011-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 128. Завдання: <b>6346</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=3 --> 
			<div class="task-card card_6348" style="display:none;" id="q26">
			<div class="counter">Завдання 26 з 78</div>
			<form class="q-test" id="q_form_26" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="26">
			<input type="hidden" name="q[tip]" id="q26-tip" value="1">
			<input type="hidden" name="q[id]" value="6348">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6348/1_matematika_3.jpg" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6348" onclick="showComment(6348)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q3" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6348" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6348/decide-pr-math-2011-03.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 128. Завдання: <b>6348</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=7 --> 
			<div class="task-card card_6352" style="display:none;" id="q27">
			<div class="counter">Завдання 27 з 78</div>
			<form class="q-test" id="q_form_27" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="27">
			<input type="hidden" name="q[tip]" id="q27-tip" value="1">
			<input type="hidden" name="q[id]" value="6352">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6352/1_matematika_7.jpg" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6352" onclick="showComment(6352)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q7" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6352" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6352/decide-pr-math-2011-07.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 128. Завдання: <b>6352</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=9 --> 
			<div class="task-card card_6354" style="display:none;" id="q28">
			<div class="counter">Завдання 28 з 78</div>
			<form class="q-test" id="q_form_28" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="28">
			<input type="hidden" name="q[tip]" id="q28-tip" value="1">
			<input type="hidden" name="q[id]" value="6354">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6354/1_matematika_9.jpg" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6354" onclick="showComment(6354)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q9" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6354" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6354/decide-pr-math-2011-09.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 128. Завдання: <b>6354</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=27 --> 
			<div class="task-card card_6372" style="display:none;" id="q29">
			<div class="counter">Завдання 29 з 78</div>
			<form class="q-test" id="q_form_29" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="29">
			<input type="hidden" name="q[tip]" id="q29-tip" value="4">
			<input type="hidden" name="q[id]" value="6372">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6372/1_matematika_27.jpg" width="590" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6372" onclick="showComment(6372)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q27" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6372" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6372/decide-pr-math-2011-27.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 128. Завдання: <b>6372</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6381" style="display:none;" id="q30">
			<div class="counter">Завдання 30 з 78</div>
			<form class="q-test" id="q_form_30" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="30">
			<input type="hidden" name="q[tip]" id="q30-tip" value="1">
			<input type="hidden" name="q[id]" value="6381">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6381/matematika17_2010_1.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6381" onclick="showComment(6381)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6381" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6381/decide-pr-1-math-2010-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 129. Завдання: <b>6381</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=8 --> 
			<div class="task-card card_6388" style="display:none;" id="q31">
			<div class="counter">Завдання 31 з 78</div>
			<form class="q-test" id="q_form_31" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="31">
			<input type="hidden" name="q[tip]" id="q31-tip" value="1">
			<input type="hidden" name="q[id]" value="6388">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/63/6388/matematika17_2010_8.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6388" onclick="showComment(6388)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q8" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6388" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6388/decide-pr-1-math-2010-08.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 129. Завдання: <b>6388</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=12 --> 
			<div class="task-card card_6392" style="display:none;" id="q32">
			<div class="counter">Завдання 32 з 78</div>
			<form class="q-test" id="q_form_32" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="32">
			<input type="hidden" name="q[tip]" id="q32-tip" value="1">
			<input type="hidden" name="q[id]" value="6392">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><sup><img alt="" src="/doc/images/znotest/63/6392/1_matematika17_2010_12.png" width="596" style="height: auto;" /></sup></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6392" onclick="showComment(6392)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q12" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6392" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/63/6392/decide-pr-1-math-2010-12.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 129. Завдання: <b>6392</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=26 --> 
			<div class="task-card card_6406" style="display:none;" id="q33">
			<div class="counter">Завдання 33 з 78</div>
			<form class="q-test" id="q_form_33" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="33">
			<input type="hidden" name="q[tip]" id="q33-tip" value="4">
			<input type="hidden" name="q[id]" value="6406">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/64/6406/1_matematika17_2010_26.png" width="589" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6406" onclick="showComment(6406)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q26" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6406" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/64/6406/decide-pr-1-math-2010-26.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 129. Завдання: <b>6406</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=6 --> 
			<div class="task-card card_6435" style="display:none;" id="q34">
			<div class="counter">Завдання 34 з 78</div>
			<form class="q-test" id="q_form_34" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="34">
			<input type="hidden" name="q[tip]" id="q34-tip" value="1">
			<input type="hidden" name="q[id]" value="6435">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/64/6435/matematika17_2010_6.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6435" onclick="showComment(6435)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q6" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6435" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/64/6435/decide-pr-2-math-2010-06.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 131. Завдання: <b>6435</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=10 --> 
			<div class="task-card card_6445" style="display:none;" id="q35">
			<div class="counter">Завдання 35 з 78</div>
			<form class="q-test" id="q_form_35" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="35">
			<input type="hidden" name="q[tip]" id="q35-tip" value="1">
			<input type="hidden" name="q[id]" value="6445">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/64/6445/1_matematika17_2010_10.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6445" onclick="showComment(6445)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q10" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6445" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/64/6445/decide-pr-2-math-2010-10.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 131. Завдання: <b>6445</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=18 --> 
			<div class="task-card card_6458" style="display:none;" id="q36">
			<div class="counter">Завдання 36 з 78</div>
			<form class="q-test" id="q_form_36" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="36">
			<input type="hidden" name="q[tip]" id="q36-tip" value="1">
			<input type="hidden" name="q[id]" value="6458">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/64/6458/1_matematika17_2010_18.png" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6458" onclick="showComment(6458)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q18" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6458" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/64/6458/decide-pr-2-math-2010-18.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 131. Завдання: <b>6458</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_6872" style="display:none;" id="q37">
			<div class="counter">Завдання 37 з 78</div>
			<form class="q-test" id="q_form_37" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="37">
			<input type="hidden" name="q[tip]" id="q37-tip" value="1">
			<input type="hidden" name="q[id]" value="6872">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="104" alt="" src="/doc/images/znotest/68/6872/1_33.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6872" onclick="showComment(6872)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6872" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/68/6872/kommentarii_1.png" style="width: 532px; height: 178px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 138. Завдання: <b>6872</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=7 --> 
			<div class="task-card card_6878" style="display:none;" id="q38">
			<div class="counter">Завдання 38 з 78</div>
			<form class="q-test" id="q_form_38" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="38">
			<input type="hidden" name="q[tip]" id="q38-tip" value="1">
			<input type="hidden" name="q[id]" value="6878">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="128" alt="" src="/doc/images/znotest/68/6878/matematika_7.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6878" onclick="showComment(6878)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q7" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6878" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/68/6878/kommentarii_7.png" style="width: 565px; height: 164px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 138. Завдання: <b>6878</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=15 --> 
			<div class="task-card card_6886" style="display:none;" id="q39">
			<div class="counter">Завдання 39 з 78</div>
			<form class="q-test" id="q_form_39" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="39">
			<input type="hidden" name="q[tip]" id="q39-tip" value="1">
			<input type="hidden" name="q[id]" value="6886">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="128" alt="" src="/doc/images/znotest/68/6886/matematika_15.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_6886" onclick="showComment(6886)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q15" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_6886" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/68/6886/kommentarii_15.png" style="width: 557px; height: 394px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 138. Завдання: <b>6886</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=2 --> 
			<div class="task-card card_7166" style="display:none;" id="q40">
			<div class="counter">Завдання 40 з 78</div>
			<form class="q-test" id="q_form_40" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="40">
			<input type="hidden" name="q[tip]" id="q40-tip" value="1">
			<input type="hidden" name="q[id]" value="7166">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/71/7166/matematika_2.jpg" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7166" onclick="showComment(7166)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q2" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7166" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/71/7166/kommentarii_2014_dop_sessia_2.png" style="width: 596px; height: 842px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 144. Завдання: <b>7166</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=9 --> 
			<div class="task-card card_7173" style="display:none;" id="q41">
			<div class="counter">Завдання 41 з 78</div>
			<form class="q-test" id="q_form_41" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="41">
			<input type="hidden" name="q[tip]" id="q41-tip" value="1">
			<input type="hidden" name="q[id]" value="7173">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/71/7173/1_matematika_9.jpg" width="596" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7173" onclick="showComment(7173)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q9" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7173" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/71/7173/kommentarii_2014_dop_sessia_9.png" style="width: 596px; height: 842px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 144. Завдання: <b>7173</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=3 --> 
			<div class="task-card card_7482" style="display:none;" id="q42">
			<div class="counter">Завдання 42 з 78</div>
			<form class="q-test" id="q_form_42" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="42">
			<input type="hidden" name="q[tip]" id="q42-tip" value="1">
			<input type="hidden" name="q[id]" value="7482">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="144" alt="" src="/doc/images/znotest/74/7482/1_matematika_2009_3.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7482" onclick="showComment(7482)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q3" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7482" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/74/7482/decide-os-math-2009-03.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 151. Завдання: <b>7482</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_7490" style="display:none;" id="q43">
			<div class="counter">Завдання 43 з 78</div>
			<form class="q-test" id="q_form_43" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="43">
			<input type="hidden" name="q[tip]" id="q43-tip" value="1">
			<input type="hidden" name="q[id]" value="7490">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="144" alt="" src="/doc/images/znotest/74/7490/1_matematika_2009_5.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7490" onclick="showComment(7490)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7490" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/74/7490/decide-os-math-2009-05.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 151. Завдання: <b>7490</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=10 --> 
			<div class="task-card card_7495" style="display:none;" id="q44">
			<div class="counter">Завдання 44 з 78</div>
			<form class="q-test" id="q_form_44" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="44">
			<input type="hidden" name="q[tip]" id="q44-tip" value="1">
			<input type="hidden" name="q[id]" value="7495">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="596" height="112" alt="" src="/doc/images/znotest/74/7495/1_matematika_2009_10.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7495" onclick="showComment(7495)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q10" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7495" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/74/7495/decide-os-math-2009-10.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 151. Завдання: <b>7495</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=21 --> 
			<div class="task-card card_7526" style="display:none;" id="q45">
			<div class="counter">Завдання 45 з 78</div>
			<form class="q-test" id="q_form_45" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="45">
			<input type="hidden" name="q[tip]" id="q45-tip" value="8">
			<input type="hidden" name="q[id]" value="7526">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="144" height="55" alt="" src="/doc/images/znotest/75/7526/1_matematika_2009_21.jpg" /></p><p>&nbsp;</p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=8 -->
			
			
			
			
			<div class="clear mb10"></div>
			
			
			
			
			<div class="q-info">Впишіть відповідь:</div><!-- 8-9 -->
			<br>
			<input type="text" value="" name="a" class="inptext w250" maxlength="30" />
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7526" onclick="showComment(7526)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q21" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7526" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/75/7526/decide-os-math-2009-21.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 151. Завдання: <b>7526</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_7643" style="display:none;" id="q46">
			<div class="counter">Завдання 46 з 78</div>
			<form class="q-test" id="q_form_46" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="46">
			<input type="hidden" name="q[tip]" id="q46-tip" value="4">
			<input type="hidden" name="q[id]" value="7643">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/76/7643/1_matematika2015_22.png" width="560" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_7643" onclick="showComment(7643)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_7643" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/76/7643/kommentarii_22__1_.png" style="width: 595px; height: 318px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 154. Завдання: <b>7643</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_8189" style="display:none;" id="q47">
			<div class="counter">Завдання 47 з 78</div>
			<form class="q-test" id="q_form_47" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="47">
			<input type="hidden" name="q[tip]" id="q47-tip" value="4">
			<input type="hidden" name="q[id]" value="8189">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img width="528" height="272" alt="" src="/doc/images/znotest/81/8189/1_matematika_22.jpg" /></p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_8189" onclick="showComment(8189)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_8189" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/81/8189/kommentarii_22.png" style="width: 596px; height: 386px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 166. Завдання: <b>8189</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_9232" style="display:none;" id="q48">
			<div class="counter">Завдання 48 з 78</div>
			<form class="q-test" id="q_form_48" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="48">
			<input type="hidden" name="q[tip]" id="q48-tip" value="1">
			<input type="hidden" name="q[id]" value="9232">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/92/9232/matematika_2016_1.png" width="597" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_9232" onclick="showComment(9232)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_9232" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/92/9232/kommentarii_2016_1.png" style="width: 563px; height: 283px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 187. Завдання: <b>9232</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_9253" style="display:none;" id="q49">
			<div class="counter">Завдання 49 з 78</div>
			<form class="q-test" id="q_form_49" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="49">
			<input type="hidden" name="q[tip]" id="q49-tip" value="4">
			<input type="hidden" name="q[id]" value="9253">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/92/9253/1_matematika_2016_22.png" width="561" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_9253" onclick="showComment(9253)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_9253" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/92/9253/kommentarii_2016_22.png" style="width: 553px; height: 389px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 187. Завдання: <b>9253</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_9448" style="display:none;" id="q50">
			<div class="counter">Завдання 50 з 78</div>
			<form class="q-test" id="q_form_50" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="50">
			<input type="hidden" name="q[tip]" id="q50-tip" value="4">
			<input type="hidden" name="q[id]" value="9448">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/94/9448/1_matematika_2016_22.png" width="551" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_9448" onclick="showComment(9448)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_9448" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/94/9448/matematika_osn_sessia_2016_22.png" style="width: 554px; height: 685px;" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 191. Завдання: <b>9448</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_10832" style="display:none;" id="q51">
			<div class="counter">Завдання 51 з 78</div>
			<form class="q-test" id="q_form_51" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="51">
			<input type="hidden" name="q[tip]" id="q51-tip" value="1">
			<input type="hidden" name="q[id]" value="10832">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/108/10832/ds-math-2016-01.png" width="600" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_10832" onclick="showComment(10832)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_10832" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/108/10832/deside-ds-math-2016-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 221. Завдання: <b>10832</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_10853" style="display:none;" id="q52">
			<div class="counter">Завдання 52 з 78</div>
			<form class="q-test" id="q_form_52" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="52">
			<input type="hidden" name="q[tip]" id="q52-tip" value="4">
			<input type="hidden" name="q[id]" value="10853">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/108/10853/ds-math-2016-22.png" width="600" style="height: auto;" /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_10853" onclick="showComment(10853)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_10853" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/108/10853/deside-ds-math-2016-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 221. Завдання: <b>10853</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_12065" style="display:none;" id="q53">
			<div class="counter">Завдання 53 з 78</div>
			<form class="q-test" id="q_form_53" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="53">
			<input type="hidden" name="q[tip]" id="q53-tip" value="1">
			<input type="hidden" name="q[id]" value="12065">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/120/12065/os-math-2017-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12065" onclick="showComment(12065)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12065" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/120/12065/deside-os-math-2017-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 247. Завдання: <b>12065</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=18 --> 
			<div class="task-card card_12082" style="display:none;" id="q54">
			<div class="counter">Завдання 54 з 78</div>
			<form class="q-test" id="q_form_54" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="54">
			<input type="hidden" name="q[tip]" id="q54-tip" value="1">
			<input type="hidden" name="q[id]" value="12082">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/120/12082/os-math-2017-18.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12082" onclick="showComment(12082)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q18" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12082" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/120/12082/deside-os-math-2017-18.png" style="height: auto;" width="600" /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 247. Завдання: <b>12082</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_12086" style="display:none;" id="q55">
			<div class="counter">Завдання 55 з 78</div>
			<form class="q-test" id="q_form_55" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="55">
			<input type="hidden" name="q[tip]" id="q55-tip" value="4">
			<input type="hidden" name="q[id]" value="12086">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/120/12086/os-math-2017-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12086" onclick="showComment(12086)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12086" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/120/12086/deside-os-math-2017-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 247. Завдання: <b>12086</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=6 --> 
			<div class="task-card card_12507" style="display:none;" id="q56">
			<div class="counter">Завдання 56 з 78</div>
			<form class="q-test" id="q_form_56" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="56">
			<input type="hidden" name="q[tip]" id="q56-tip" value="1">
			<input type="hidden" name="q[id]" value="12507">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/125/12507/ds-math-2017-06.png"  width="601" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12507" onclick="showComment(12507)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q6" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12507" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/125/12507/151229_deside-ds-math-2017-06.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 256. Завдання: <b>12507</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=17 --> 
			<div class="task-card card_12518" style="display:none;" id="q57">
			<div class="counter">Завдання 57 з 78</div>
			<form class="q-test" id="q_form_57" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="57">
			<input type="hidden" name="q[tip]" id="q57-tip" value="1">
			<input type="hidden" name="q[id]" value="12518">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/125/12518/ds-math-2017-17.png"  width="602" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12518" onclick="showComment(12518)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q17" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12518" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/125/12518/deside-ds-math-2017-17.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 256. Завдання: <b>12518</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_12523" style="display:none;" id="q58">
			<div class="counter">Завдання 58 з 78</div>
			<form class="q-test" id="q_form_58" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="58">
			<input type="hidden" name="q[tip]" id="q58-tip" value="4">
			<input type="hidden" name="q[id]" value="12523">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/125/12523/ds-math-2017-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_12523" onclick="showComment(12523)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_12523" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/125/12523/deside-ds-math-2017-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 256. Завдання: <b>12523</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_14235" style="display:none;" id="q59">
			<div class="counter">Завдання 59 з 78</div>
			<form class="q-test" id="q_form_59" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="59">
			<input type="hidden" name="q[tip]" id="q59-tip" value="1">
			<input type="hidden" name="q[id]" value="14235">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/142/14235/pr-math-2018-01_1.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14235" onclick="showComment(14235)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14235" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/142/14235/deside-pr-math-2018-01_1.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 290. Завдання: <b>14235</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=5 --> 
			<div class="task-card card_14239" style="display:none;" id="q60">
			<div class="counter">Завдання 60 з 78</div>
			<form class="q-test" id="q_form_60" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="60">
			<input type="hidden" name="q[tip]" id="q60-tip" value="1">
			<input type="hidden" name="q[id]" value="14239">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/142/14239/pr-math-2018-05.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14239" onclick="showComment(14239)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q5" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14239" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/142/14239/deside-pr-math-2018-05.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 290. Завдання: <b>14239</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_14256" style="display:none;" id="q61">
			<div class="counter">Завдання 61 з 78</div>
			<form class="q-test" id="q_form_61" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="61">
			<input type="hidden" name="q[tip]" id="q61-tip" value="4">
			<input type="hidden" name="q[id]" value="14256">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/142/14256/pr-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14256" onclick="showComment(14256)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14256" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/142/14256/deside-pr-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 290. Завдання: <b>14256</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_14306" style="display:none;" id="q62">
			<div class="counter">Завдання 62 з 78</div>
			<form class="q-test" id="q_form_62" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="62">
			<input type="hidden" name="q[tip]" id="q62-tip" value="1">
			<input type="hidden" name="q[id]" value="14306">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/143/14306/os-math-2008-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14306" onclick="showComment(14306)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14306" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/143/14306/decide-os-math-2008-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 292. Завдання: <b>14306</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=2 --> 
			<div class="task-card card_14307" style="display:none;" id="q63">
			<div class="counter">Завдання 63 з 78</div>
			<form class="q-test" id="q_form_63" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="63">
			<input type="hidden" name="q[tip]" id="q63-tip" value="1">
			<input type="hidden" name="q[id]" value="14307">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/143/14307/os-math-2008-02.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14307" onclick="showComment(14307)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q2" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14307" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/143/14307/decide-os-math-2008-02.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 292. Завдання: <b>14307</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=7 --> 
			<div class="task-card card_14312" style="display:none;" id="q64">
			<div class="counter">Завдання 64 з 78</div>
			<form class="q-test" id="q_form_64" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="64">
			<input type="hidden" name="q[tip]" id="q64-tip" value="1">
			<input type="hidden" name="q[id]" value="14312">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/143/14312/os-math-2008-07.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14312" onclick="showComment(14312)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q7" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14312" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/143/14312/decide-os-math-2008-07.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 292. Завдання: <b>14312</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_14523" style="display:none;" id="q65">
			<div class="counter">Завдання 65 з 78</div>
			<form class="q-test" id="q_form_65" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="65">
			<input type="hidden" name="q[tip]" id="q65-tip" value="1">
			<input type="hidden" name="q[id]" value="14523">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/145/14523/os-math-2007-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14523" onclick="showComment(14523)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14523" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/145/14523/decide-os-math-2007-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 296. Завдання: <b>14523</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=21 --> 
			<div class="task-card card_14543" style="display:none;" id="q66">
			<div class="counter">Завдання 66 з 78</div>
			<form class="q-test" id="q_form_66" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="66">
			<input type="hidden" name="q[tip]" id="q66-tip" value="8">
			<input type="hidden" name="q[id]" value="14543">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/145/14543/os-math-2007-21.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=8 -->
			
			
			
			
			<div class="clear mb10"></div>
			
			
			
			
			<div class="q-info">Впишіть відповідь:</div><!-- 8-9 -->
			<br>
			<input type="text" value="" name="a" class="inptext w250" maxlength="30" />
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14543" onclick="showComment(14543)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q21" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14543" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/145/14543/decide-os-math-2007-21.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 296. Завдання: <b>14543</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_14617" style="display:none;" id="q67">
			<div class="counter">Завдання 67 з 78</div>
			<form class="q-test" id="q_form_67" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="67">
			<input type="hidden" name="q[tip]" id="q67-tip" value="4">
			<input type="hidden" name="q[id]" value="14617">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/146/14617/os-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_14617" onclick="showComment(14617)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_14617" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/146/14617/deside-os-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 298. Завдання: <b>14617</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_15235" style="display:none;" id="q68">
			<div class="counter">Завдання 68 з 78</div>
			<form class="q-test" id="q_form_68" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="68">
			<input type="hidden" name="q[tip]" id="q68-tip" value="1">
			<input type="hidden" name="q[id]" value="15235">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/152/15235/ds-math-2018-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_15235" onclick="showComment(15235)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_15235" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/152/15235/deside-ds-math-2018-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 310. Завдання: <b>15235</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=3 --> 
			<div class="task-card card_15237" style="display:none;" id="q69">
			<div class="counter">Завдання 69 з 78</div>
			<form class="q-test" id="q_form_69" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="69">
			<input type="hidden" name="q[tip]" id="q69-tip" value="1">
			<input type="hidden" name="q[id]" value="15237">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/152/15237/ds-math-2018-03.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_15237" onclick="showComment(15237)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q3" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_15237" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/152/15237/deside-ds-math-2018-03.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 310. Завдання: <b>15237</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_15256" style="display:none;" id="q70">
			<div class="counter">Завдання 70 з 78</div>
			<form class="q-test" id="q_form_70" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="70">
			<input type="hidden" name="q[tip]" id="q70-tip" value="4">
			<input type="hidden" name="q[id]" value="15256">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/152/15256/ds-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_15256" onclick="showComment(15256)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_15256" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/152/15256/deside-ds-math-2018-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 310. Завдання: <b>15256</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_16598" style="display:none;" id="q71">
			<div class="counter">Завдання 71 з 78</div>
			<form class="q-test" id="q_form_71" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="71">
			<input type="hidden" name="q[tip]" id="q71-tip" value="1">
			<input type="hidden" name="q[id]" value="16598">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/165/16598/pr-math-2019-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_16598" onclick="showComment(16598)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_16598" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/165/16598/deside-pr-math-2019-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 337. Завдання: <b>16598</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=17 --> 
			<div class="task-card card_16614" style="display:none;" id="q72">
			<div class="counter">Завдання 72 з 78</div>
			<form class="q-test" id="q_form_72" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="72">
			<input type="hidden" name="q[tip]" id="q72-tip" value="1">
			<input type="hidden" name="q[id]" value="16614">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/166/16614/pr-math-2019-17.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_16614" onclick="showComment(16614)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q17" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_16614" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/166/16614/deside-pr-math-2019-17.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 337. Завдання: <b>16614</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=22 --> 
			<div class="task-card card_17082" style="display:none;" id="q73">
			<div class="counter">Завдання 73 з 78</div>
			<form class="q-test" id="q_form_73" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="73">
			<input type="hidden" name="q[tip]" id="q73-tip" value="4">
			<input type="hidden" name="q[id]" value="17082">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/170/17082/os-math-2019-22.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=4 -->
			
			<div class="answers col" style="width: 50%">
			</div>
			<div class="answers col" style="width: 50%">
			</div>
			
			
			
			<div class="clear mb10"></div>
			
			
			<div class="q-info">Позначте відповіді:</div><!--  4.(4х5|5x5)  5.(4х4)  10.(5х4) -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td></tr>
			<tr>
			<th class="r">4</th>
			<td><label><input type="radio" value="4a" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4b" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4c" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4d" name="a[4]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="4e" name="a[4]" class="q-radio" /><span class="marker"></span></label></td></tr>
			</table>
			
			
			
			
			
			
			<div class="two-buttons-container">
			    <div class="bw-left">
					<span class="q-btn button-green q-skip">Пропустити</span>
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_17082" onclick="showComment(17082)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q22" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_17082" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/170/17082/deside-os-math-2019-22.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 346. Завдання: <b>17082</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_17642" style="display:none;" id="q74">
			<div class="counter">Завдання 74 з 78</div>
			<form class="q-test" id="q_form_74" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="74">
			<input type="hidden" name="q[tip]" id="q74-tip" value="1">
			<input type="hidden" name="q[id]" value="17642">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/176/17642/ds-math-2019-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_17642" onclick="showComment(17642)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_17642" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/176/17642/deside-ds-math-2019-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 357. Завдання: <b>17642</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=15 --> 
			<div class="task-card card_17656" style="display:none;" id="q75">
			<div class="counter">Завдання 75 з 78</div>
			<form class="q-test" id="q_form_75" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="75">
			<input type="hidden" name="q[tip]" id="q75-tip" value="1">
			<input type="hidden" name="q[id]" value="17656">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/176/17656/ds-math-2019-15.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_17656" onclick="showComment(17656)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q15" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_17656" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/176/17656/deside-ds-math-2019-15.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 357. Завдання: <b>17656</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=1 --> 
			<div class="task-card card_19486" style="display:none;" id="q76">
			<div class="counter">Завдання 76 з 78</div>
			<form class="q-test" id="q_form_76" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="76">
			<input type="hidden" name="q[tip]" id="q76-tip" value="1">
			<input type="hidden" name="q[id]" value="19486">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/194/19486/pr-math-2020-01.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_19486" onclick="showComment(19486)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q1" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_19486" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/194/19486/decide-pr-math-2020-01.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 390. Завдання: <b>19486</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=17 --> 
			<div class="task-card card_19961" style="display:none;" id="q77">
			<div class="counter">Завдання 77 з 78</div>
			<form class="q-test" id="q_form_77" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="77">
			<input type="hidden" name="q[tip]" id="q77-tip" value="1">
			<input type="hidden" name="q[id]" value="19961">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p><img alt="" src="/doc/images/znotest/199/19961/os-math-2020-17.png"  width="600" style="height: auto;"  /></p>
			
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=1 -->
			<div class="answers">
			
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
					<span class="q-btn button-green q-next element_hide">Відповісти</span>		<span class="q-btn button-gray explan_open" id="btn_show_19961" onclick="showComment(19961)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final q-savetemp">Продовжити пізніше</span>
								</div>
			</div>
				<input type="hidden" id="do-q17" name="do" value="answer" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_19961" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p><img alt="" src="/doc/images/znotest/199/19961/decide-os-math-2020-17.png"  width="600" style="height: auto;"  /></p>
			</div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 400. Завдання: <b>19961</b></div>
			</div>
			
			<!-- abc=0 --><!-- out_order=16 --> 
			<div class="task-card card_26009" style="display:none;" id="q78">
			<div class="counter">Завдання 78 з 78</div>
			<form class="q-test" id="q_form_78" action="/users/znotest/tema/" onsubmit="return false;" autocomplete="off">
			<input type="hidden" name="q[out_order]" value="78">
			<input type="hidden" name="q[tip]" id="q78-tip" value="13">
			<input type="hidden" name="q[id]" value="26009">
			
			<br>
			
			<div class="q-error"></div>
			
			<div class="question">
			<p>Установіть відповідність між виразом (1&ndash;3) та проміжком (А&nbsp;&ndash;&nbsp;Д), якому належить його значення. </p>
			</div>
			
			<div class="clear"></div>
			
			<!-- tip=13 -->
			
			<div class="answers col" style="width: 50%">
				<div class="quest-title"><i>Вираз</i></div><div class="answer"><span class="marker">1</span>\( |-1,6|+2 \)</div><div class="answer"><span class="marker">2</span>\( \frac{\sqrt{24}}{\sqrt{3}} \)</div><div class="answer"><span class="marker">3</span>\( 2\cos\frac{\style{font-style:normal;font-weight:bold;font-size:1.1em}{\pi}}{3} \)</div></div>
			<div class="answers col" style="width: 50%">
				<div class="quest-title"><i>Проміжок</i></div><div class="answer"><span class="marker">А</span>\( (-\infty;\ 0) \)</div><div class="answer"><span class="marker">Б</span>\( [0;\ 1) \)</div><div class="answer"><span class="marker">В</span>\( [1;\ 2) \)</div><div class="answer"><span class="marker">Г</span>\( [2;\ 3) \)</div><div class="answer"><span class="marker">Д</span>\( [3;\ +\infty) \)</div></div>
			
			
			
			<div class="clear mb10"></div>
			
			
			
			
			
			
			
			<div class="q-info">Впишіть відповіді:</div><!-- 13 -->
			<br>
			<table class="select-answers-variants">
			<tr><th></th><th>А</th><th>Б</th><th>В</th><th>Г</th><th>Д</th></tr>
			<tr>
			<th class="r">1</th>
			<td><label><input type="radio" value="1a" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1b" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1c" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1d" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="1e" name="a[1]" class="q-radio" /><span class="marker"></span></label></td>
			</tr>
			<tr>
			<th class="r">2</th>
			<td><label><input type="radio" value="2a" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2b" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2c" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2d" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="2e" name="a[2]" class="q-radio" /><span class="marker"></span></label></td>
			</tr>
			<tr>
			<th class="r">3</th>
			<td><label><input type="radio" value="3a" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3b" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3c" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3d" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			<td><label><input type="radio" value="3e" name="a[3]" class="q-radio" /><span class="marker"></span></label></td>
			</tr>
			</table>
			
			<div class="two-buttons-container">
			    <div class="bw-left">
							<span class="q-btn button-gray explan_open" id="btn_show_26009" onclick="showComment(26009)">Читати коментар</span>		<div class="up-left"></div>
				</div>
			  
				<div class="bw-right">
							<span class="q-btn button-red q-final">Завершити тест</span>
						</div>
			</div>
			 
				<input type="hidden" id="do-q16" name="do" value="result" />
			</form>
			
			<div class="clear"></div>
			<div class="description up nopremium"><span class="nouser">Коментарі доступні лише для зареєстрованих користувачів.</span> <a href="/comtests.html" target="_blank">Дивитись умови перегляду коментарів&nbsp;>>></a>.</div>
			<div id="commentar_26009" class="explanation" style="display:none;">
				<strong>Коментар</strong><br><br>
				<p>
			        <strong>
			           ТЕМА: Алгебра і початки аналізу. Числа і вирази.
			        </strong>
			    </p>
			    <p>
			        Завдання перевіряє вміння використовувати властивості модуля, виконувати тотожні перетворення ірраціональних, тригонометричних виразів, розрізняти види чисел та числових проміжків.
			    </p>
			    <p>
			        Знайдемо значення виразу
			    </p>
			    <p>
			        <b>1.</b> \(|-1,6|+2=1,6+2=3,6\in [3;\ +\infty)\) <b>Д.</b>
			    </p>
			    <p>
			        <b>2.</b>
			        \begin{gather*}
			            \frac{\sqrt{24}}{\sqrt{3}}=\sqrt{\frac{24}{3}}=\sqrt{8}\\[7pt]
			            \sqrt{4}\lt \sqrt{8}\lt\sqrt{9}\\[7pt]
			            2\lt\sqrt{8}\lt 3.
			        \end{gather*}
			        Отже, \(\sqrt{8}\in [2;\ 3)\) &ndash; <b>Г.</b>
			    </p>
			    <p>
			        <b>3.</b> \(2\cos\frac{\style{font-style:normal;font-weight:bold;font-size:1.1em}{\pi}}{3}=2\cdot \frac 12=1\in [1;\ 2)\) &ndash; <b>B</b>.
			    </p>
			    <p><strong>Відповідь: 1Д 2Г 3В.</strong></p></div>
			
			<div class="description">
			Розділ із завданнями за темами працює у тестовому режимі. <br>Побажання та зауваження будь ласка пишіть на <script type="text/javascript">eval(unescape('%64%6f%63%75%6d%65%6e%74%2e%77%72%69%74%65%28%27%3c%61%20%68%72%65%66%3d%22%6d%61%69%6c%74%6f%3a%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%22%3e%6f%66%66%69%63%65%40%6f%73%76%69%74%61%2e%75%61%3c%2f%61%3e%27%29%3b'))</script> 
			</div>
			<div class="edinfo" style="display:none;">Тест 516. Завдання: <b>26009</b></div>
			</div>
			
			
			<!--<script type="text/javascript" async src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.7/MathJax.js?config=TeX-MML-AM_CHTML"></script>-->
			<script src="https://polyfill.io/v3/polyfill.min.js?features=es6"></script>
			<script id="MathJax-script" async src="https://cdn.jsdelivr.net/npm/mathjax@3/es5/tex-mml-svg.js"></script>
			
			
			<script type="text/javascript">
			window.onload = function() {
				if( window.zStat ){ zStat(); }
				setTimeout(function(){ if( getCookie('osname') === undefined ){$('.explanation').html('<p>Коментарі для зареєстрованих користувачів!</p>').hide();} }, 10000);
			}
			</script>
			
			
			
			
			<div class="links-card links">
			<div class="links-header">Інформація</div>
			<ul class="links">
			<li><a href="https://zno.osvita.ua/mathematics/" title="Усі завдання ЗНО з математики за темами" target="_blank">Усі завдання ЗНО з математики за темами</a></li>
			<li><a href="http://zno.osvita.ua/mathematics/" title="Усі тести ЗНО з математики онлайн" target="_blank">Усі тести ЗНО з математики онлайн</a></li>
			<li><a href="http://osvita.ua/test/answers/matem.html" title="Завдання й відповіді ЗНО з математики минулих років" target="_blank">Завдання й відповіді ЗНО з математики минулих років</a></li>
			<li><a href="http://osvita.ua/test/training/5017/" title="Усе про тест ЗНО з математики" target="_blank">Усе про тест ЗНО з математики</a></li>
			<li><a href="http://osvita.ua/test/program_zno/1126/" title="Програма ЗНО з математики" target="_blank">Програма ЗНО з математики</a></li>
			<li><a href="http://zno.osvita.ua/" title="Тести ЗНО онлайн з інших предметів" target="_blank">Тести ЗНО онлайн з інших предметів</a></li>
			<li><a href="http://osvita.ua/test/advice/" title="Дорожня карта учасника ЗНО" target="_blank">Дорожня карта учасника ЗНО</a></li>
			<li><a href="https://osvita.ua/consultations/bachelor/" title="Дорожня карта вступника на бакалавра" target="_blank">Дорожня карта вступника на бакалавра</a></li>
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
			
			<!-- zno_quest_list_by_tag_all 0.08393 c. -->
			
			
			            </div>
			            <div class="col-right homepage-right-hide">
						
			<!-- banners - banner300 - 1890 -->
			<!--noindex-->
			<div class="block w300 wrapbanner" style="height:600px;">
			<div class="banner" style="height:600px;">
			<!-- id=1 -->
			<div id='admixer_741839645c2346e68867b1f3f0e96a5e_zone_20646_sect_226_site_226'></div><script type='text/javascript' src='https://prebid-inv-eu.admixer.net/prebid-loader2.aspx?adguid=74a1f9e1-65c3-4075-a988-90d4b6350625'></script>
			</div>
			</div>
			<!--/noindex-->
			<!-- banner300 0.00108 c. -->
			
			
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
			<script>(function(){var js = "window['__CF$cv$params']={r:'798f399a3c51b383',m:'DUTTqXHu84kahlJhpRxgM_4xvHWvgWowPMBCyTRpURI-1676308724-0-AWcjBYNucuAJCpuJkyfAvoSZrUunooncx/TBqP131Rva+dwB06iQnNTALAO8O7BHvWTBiueD+xd82Vw+bXAC27hrDQSkupoPU7UuYKc1l5QtcP2eZ2+LYOfFpCkAgg0MhV5zCcYW/6F+YtLs21ngtcE=',s:[0xd461582a44,0x3e5b0e9838],u:'/cdn-cgi/challenge-platform/h/b'};var now=Date.now()/1000,offset=14400,ts=''+(Math.floor(now)-Math.floor(now%offset)),_cpo=document.createElement('script');_cpo.nonce='',_cpo.src='/cdn-cgi/challenge-platform/h/b/scripts/alpha/invisible.js?ts='+ts,document.getElementsByTagName('head')[0].appendChild(_cpo);";var _0xh = document.createElement('iframe');_0xh.height = 1;_0xh.width = 1;_0xh.style.position = 'absolute';_0xh.style.top = 0;_0xh.style.left = 0;_0xh.style.border = 'none';_0xh.style.visibility = 'hidden';document.body.appendChild(_0xh);function handler() {var _0xi = _0xh.contentDocument || _0xh.contentWindow.document;if (_0xi) {var _0xj = _0xi.createElement('script');_0xj.nonce = '';_0xj.innerHTML = js;_0xi.getElementsByTagName('head')[0].appendChild(_0xj);}}if (document.readyState !== 'loading') {handler();} else if (window.addEventListener) {document.addEventListener('DOMContentLoaded', handler);} else {var prev = document.onreadystatechange || function () {};document.onreadystatechange = function (e) {prev(e);if (document.readyState !== 'loading') {document.onreadystatechange = prev;handler();}};}})();</script></body>
			</html>
			<!-- page_id=101 tag | z=0 -->
			<!-- /mathematics/tag-dijsni_chysla/index.html от 13-02-2023 16:54:56 new /mathematics/tag-dijsni_chysla/index.html_7627 -->
			 
			""";
    }
    public static class Math2
    {
        public static string html1 = """ """;
        public static string html2 = """ """;

    }
    public static class Math3
    {
        public static string html1 = """ """;
        public static string html2 = """ """;
    }
    public static class Math4
    {
        public static string html1 = """ """;
        public static string html2 = """ """;
    }
    public static class Math5
    {
        public static string html1 = """ """;
        public static string html2 = """ """;
    }
    public static class Math6
    {
        public static string html1 = """ """;
        public static string html2 = """ """;
    }
}
