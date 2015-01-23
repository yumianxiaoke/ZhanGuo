module(..., package.seeall);

Message = {
	Name = [[MSG000]],  Value = [[档案开启错误]],
	Name = [[MSG001]],  Value = [[讯息测试1]],
	Name = [[MSG002]],  Value = [[讯息测试2]],
	Name = [[MSG003]],  Value = [[中文测试]],
	Name = [[MSG100]],  Value = [[\n城市太守资料错误:%s]],
	Name = [[MSG101]],  Value = [[\n君主资料错误:%s]],
	Name = [[MSG104]],  Value = [[Allocate GeneralType memory error !!]],
	Name = [[MSG105]],  Value = [[开启地图档错误]],
	Name = [[MSG106]],  Value = [[记忆体不足!!]],
	Name = [[MSG107]],  Value = [[地图资料不对]],
	Name = [[MSG108]],  Value = [[allocate chinese index table fail !!]],
	Name = [[MSG109]],  Value = [[找不到中文字型档]],
	Name = [[MSG110]],  Value = [[ChineseFontBuffer : 记忆体不足!!]],
	Name = [[MSG111]],  Value = [[找不到英文字型档]],
	Name = [[MSG112]],  Value = [[EnglishFontBuffer : 记忆体不足!!]],
	Name = [[MSG113]],  Value = [[InitializeGeneral : 记忆体不足!!]],
	Name = [[MSG114]],  Value = [[InitializeTroop : 记忆体不足!!]],
	Name = [[MSG115]],  Value = [[InitializeCity : 记忆体不足!!]],
	Name = [[MSG116]],  Value = [[InitializeKing : 记忆体不足!!]],
	Name = [[MSG800]],  Value = [[我找到了%S3%将军，请大人会见他。%k%%l%]],
	Name = [[MSG801]],  Value = [[%S3%将军，请加入我方，共创和平大业。%k%%l%]],
	Name = [[MSG802]],  Value = [[良禽择木而栖，贤臣择主而事，加入我方吧！%k%%l%]],
	Name = [[MSG803]],  Value = [[加入我方，我将好好重用你！%k%%l%]],
	Name = [[MSG804]],  Value = [[本人急需用人之际，%S3%将军快快加入我吧！%k%%l%]],
	Name = [[MSG805]],  Value = [[还真是埋没英雄啊！加入我方，我们一定不会亏待你的%k%%l%]],
	Name = [[MSG806]],  Value = [[看您一身是胆，又有着一手的好功夫，加入我们吧！%k%%l%]],
	Name = [[MSG807]],  Value = [[加入我方吧！不要让自己的大好才能白白浪费！%k%%l%]],
	Name = [[MSG808]],  Value = [[投效我方吧！你才有机会一展长才！%k%%l%]],
	Name = [[MSG809]],  Value = [[您是个聪明人，应该知道加入我方对你是百利而无一害！%k%%l%]],
	Name = [[MSG810]],  Value = [[多谢大人爱戴，我愿效犬马之劳！%k%%l%]],
	Name = [[MSG811]],  Value = [[太好了，我愿誓死效忠大人！%K%%l%]],
	Name = [[MSG812]],  Value = [[%S1%将军，辛苦了！%K%%l%]],
	Name = [[MSG813]],  Value = [[这是我应该做的....%k%%e%]],
	Name = [[MSG814]],  Value = [[唉！真是可惜....%K%%E%]],
	Name = [[MSG815]],  Value = [[唉！失败了 ....%K%%E%]],
	Name = [[MSG816]],  Value = [[%S3%已经成年了....%k%%l%]],
	Name = [[MSG817]],  Value = [[大人，%S3%已成年了，请大人会见他。%k%%l%]],
	Name = [[MSG818]],  Value = [[请让我为大人效力吧！！%k%%l%]],
	Name = [[MSG819]],  Value = [[嗯！这真是我军之福啊....%K%%l%]],
	Name = [[MSG820]],  Value = [[请大人让我加入！%k%%l%]],
	Name = [[MSG821]],  Value = [[大人，我愿效犬马之劳。%k%%l%]],
	Name = [[MSG822]],  Value = [[我听说大人求才若渴，是故毛遂自荐，请大人能让我加入。%k%%l%]],
	Name = [[MSG823]],  Value = [[我听说大人唯才适用，请大人让我加入。%k%%l%]],
	Name = [[MSG824]],  Value = [[我听说大人是位真英雄，我非常希望能为大人效力。%k%%l%]],
	Name = [[MSG825]],  Value = [[我希望能为大人的霸业尽一份力。%k%%l%]],
	Name = [[MSG826]],  Value = [[请大人让我为您效力吧！您一定不会失望的。%k%%l%]],
	Name = [[MSG830]],  Value = [[就让我们共创和平大业吧！%k%%l%]],
	Name = [[MSG831]],  Value = [[有你加入，我军就如虎添翼了！%k%%l%]],
	Name = [[MSG832]],  Value = [[久闻你的大名，我一定不会亏待你的！%k%%l%]],
	Name = [[MSG833]],  Value = [[很好，我等将军加入已经很久了。%k%%l%]],
	Name = [[MSG834]],  Value = [[哈哈！有你加入我就可以高枕无忧了。%k%%l%]],
	Name = [[MSG835]],  Value = [[很好，我一定会好好待你，不会让你被埋没的！%k%%l%]],
	Name = [[MSG836]],  Value = [[很好，我军就是需要像你这样的人才。%k%%l%]],
	Name = [[MSG837]],  Value = [[很好，我军就是缺少像你这样的人才。%k%%l%]],
	Name = [[MSG838]],  Value = [[有你的加入，放眼天下我军谁都不怕了。%k%%l%]],
	Name = [[MSG839]],  Value = [[很好很好！真是相见恨晚啊！%k%%l%]],
	Name = [[MSG840]],  Value = [[很好，加入我方你必定可一大展身手一番。%k%%l%]],
	Name = [[MSG850]],  Value = [[我与大人理念不同，请恕在下不能答应！%k%%l%]],
	Name = [[MSG851]],  Value = [[唉！很抱歉我不能答应。%k%%l%]],
	Name = [[MSG852]],  Value = [[嘿！大人您的人才众多，不差一个我。%k%%l%]],
	Name = [[MSG853]],  Value = [[大人，您的手下人才济济，少一个我或多一个我都没影响的。%k%%l%]],
	Name = [[MSG854]],  Value = [[我仍无事世的打算，请恕在下不能答应！%k%%l%]],
	Name = [[MSG855]],  Value = [[我尚未碰到心目中的明主，很抱歉！%k%%l%]],
	Name = [[MSG856]],  Value = [[我无法帮您的，很抱歉！%k%%l%]],
	Name = [[MSG857]],  Value = [[我目前仍然无法加入您的阵营！%k%%l%]],
	Name = [[MSG858]],  Value = [[我觉得我的能力不够还需锻链，目前无法加入您！%k%%l%]],
	Name = [[MSG859]],  Value = [[我觉得我的能力不够，无法担当大任%k%%l%]],
	Name = [[MSG860]],  Value = [[很抱歉，目前无法答应您，我想加入时会再找您的。%k%%l%]],
	Name = [[MSG861]],  Value = [[多谢大人爱戴，我目前仍有要事在身，请恕在下不能答应！%k%%l%]],
	Name = [[MSG870]],  Value = [[父亲大人，请让我加入吧！%k%%l%]],
	Name = [[MSG871]],  Value = [[父亲大人，我等着上战场已经很久了。%k%%l%]],
	Name = [[MSG872]],  Value = [[父亲大人，我已经准备好了，请让我加入吧！%k%%l%]],
	Name = [[MSG873]],  Value = [[父亲大人，我已经准备好了，请让我尽一份力吧！%k%%l%]],
	Name = [[MSG874]],  Value = [[父亲大人，请让我为您效力！%k%%l%]],
	Name = [[MSG875]],  Value = [[你能加入我就更放心了！%k%%l%]],
	Name = [[MSG876]],  Value = [[好好表现！不要让我失望了！%k%%l%]],
	Name = [[MSG877]],  Value = [[嗯！好好表现吧！%k%%l%]],
	Name = [[MSG878]],  Value = [[嗯！我很高兴你有这份心意！%k%%l%]],
	Name = [[MSG890]],  Value = [[太好了，我等这一天已经很久了！%K%%e%]],
	Name = [[MSG891]],  Value = [[父亲大人，我一定不会辜负您的期待的！%K%%e%]],
	Name = [[MSG892]],  Value = [[父亲大人，您一定会以我为荣的！%K%%e%]],
	Name = [[MSG893]],  Value = [[太好了，我一定会光宗耀祖的！%K%%e%]],
	Name = [[MSG894]],  Value = [[你能加入我就更放心了！%k%%l%"]],
	Name = [[MSG895]],  Value = [[好好表现！不要让我失望了！%k%%l%"]],
	Name = [[MSG896]],  Value = [[好好表现！不要让你父亲失望了！%k%%l%"]],
	Name = [[MSG897]],  Value = [[好好表现！我不会亏待你的！%k%%l%"]],
	Name = [[MSG898]],  Value = [[嗯！好好表现吧！%k%%l%"]],
	Name = [[MSG899]],  Value = [[果然是虎父无犬子，好好表现吧！%k%%l%"]],
	Name = [[MSG900]],  Value = [[太好了，我等这一天已经很久了！%K%%e%]],
	Name = [[MSG901]],  Value = [[太好了，我一定会好好表现！%K%%e%]],
	Name = [[MSG902]],  Value = [[我一定不会辜负大人的期待！%K%%e%]],
	Name = [[MSG903]],  Value = [[太好了，希望我能对大人有所帮助！%K%%e%]],
	Name = [[MSG904]],  Value = [[这是我应该做的....%k%%e%]],
	Name = [[MSG905]],  Value = [[这是应该的....%k%%e%]],
	Name = [[MSG906]],  Value = [[这是应该的，希望他能不负大人所望！%k%%e%]],
	Name = [[MSG907]],  Value = [[这是应该的，希望他不会让我失望！%k%%e%]],
	Name = [[MSG910]],  Value = [[真是不忍错杀一条好汉！%k%%l%]],
	Name = [[MSG911]],  Value = [[大丈夫生死何足惧！%k%%e%]],
	Name = [[MSG912]],  Value = [[再不投降就没有人救得了你了！%k%%l%]],
	Name = [[MSG913]],  Value = [[要杀要剐悉听尊便！%k%%e%]],
	Name = [[MSG914]],  Value = [[实在是个令人生气的家伙，推出去斩了！%k%%l%]],
	Name = [[MSG915]],  Value = [[哼！杀就杀怕什麽！%k%%e%]],
	Name = [[MSG916]],  Value = [[实在是个令人生气的家伙，推出去斩了！%k%%l%]],
	Name = [[MSG917]],  Value = [[我可不是一个怕死的人！%k%%e%]],
	Name = [[MSG918]],  Value = [[你真的不愿和我共图大事？%k%%l%]],
	Name = [[MSG919]],  Value = [[多说无益！%k%%e%]],
	Name = [[MSG920]],  Value = [[现在求饶已经太晚啦！%k%%l%]],
	Name = [[MSG921]],  Value = [[我还是不後悔的！%k%%e%]],
	Name = [[MSG922]],  Value = [[现在不求饶就太晚啦！%k%%l%]],
	Name = [[MSG923]],  Value = [[要杀就杀何必罗嗦！%k%%e%]],
	Name = [[MSG924]],  Value = [[可惜！可惜！%k%%l%]],
	Name = [[MSG925]],  Value = [[................%k%%e%]],
	Name = [[MSG926]],  Value = [[可惜！可惜！%k%%l%]],
	Name = [[MSG927]],  Value = [[我还是不後悔的！%k%%e%]],
	Name = [[MSG928]],  Value = [[快快求饶，饶你一命！%k%%l%]],
	Name = [[MSG929]],  Value = [[我可不是一个怕死的人！%k%%e%]],
	Name = [[MSG930]],  Value = [[再不投降明年的今天就是你的忌日！%k%%l%]],
	Name = [[MSG931]],  Value = [[哼！谁怕谁！我做鬼也不会加入的！%k%%e%]],
	Name = [[MSG940]],  Value = [[唉！杀了也没用，还是放走吧%K%%E%]],
	Name = [[MSG941]],  Value = [[今天暂且放了你，待你好好想想也不迟%K%%E%]],
	Name = [[MSG942]],  Value = [[这次放了你，下次希望你能加入%K%%E%]],
	Name = [[MSG943]],  Value = [[先放了你，下次战场上见吧%K%%E%]],
	Name = [[MSG944]],  Value = [[希望下此你能回心转意%K%%E%]],
	Name = [[MSG945]],  Value = [[唉！还是放了他吧%K%%E%]],
	Name = [[MSG950]],  Value = [[良禽择木而栖，贤臣择主而事，加入我方吧！%k%%l%]],
	Name = [[MSG951]],  Value = [[加入我方，我将尽释前嫌好好重用你！%k%%l%]],
	Name = [[MSG952]],  Value = [[快快求饶，再晚就没机会了！%k%%l%]],
	Name = [[MSG953]],  Value = [[你军已经没机会了，不如转投我方，一定不会亏待你的！%k%%l%]],
	Name = [[MSG954]],  Value = [[%S2%将军您是否愿意弃暗投明，共图大事！%k%%l%]],
	Name = [[MSG955]],  Value = [[本人急需用人之际，%S2%将军快快加入我吧！%k%%l%]],
	Name = [[MSG956]],  Value = [[%S2%将军现在不投降，等待何时？%k%%l%]],
	Name = [[MSG957]],  Value = [[还真是埋没英雄啊！加入我方，我们一定不会亏待你的。%k%%l%]],
	Name = [[MSG958]],  Value = [[您目前就像是龙困浅滩，何不另投他主呢？！%k%%l%]],
	Name = [[MSG959]],  Value = [[看您一身是胆，又有着一手的好功夫，加入我们吧！%k%%l%]],
	Name = [[MSG960]],  Value = [[希望你能尽释前嫌，与我携手合作！%k%%l%]],
	Name = [[MSG961]],  Value = [[%S2%将军，勿让自己的大好机会就此丧失，加入我方吧！%k%%l%]],
	Name = [[MSG962]],  Value = [[投降吧！可免你一死！%k%%l%]],
	Name = [[MSG963]],  Value = [[加入我方吧！不要让自己的大好才能白白浪费！%k%%l%]],
	Name = [[MSG964]],  Value = [[弃暗投明吧！不要让自己的大好机会白白放过！%k%%l%]],
	Name = [[MSG965]],  Value = [[投效我方吧！你才有机会一展长才！%k%%l%]],
	Name = [[MSG966]],  Value = [[您是个聪明人，应该知道加入我方对你是百利而无一害！%k%%l%]],
	Name = [[MSG970]],  Value = [[我与大人理念不同，请恕在下不能答应！%k%%e%]],
	Name = [[MSG971]],  Value = [[很抱歉， 我不能答应！%k%%e%]],
	Name = [[MSG972]],  Value = [[嘿！大人您的人才众多，不差我一个。%k%%e%]],
	Name = [[MSG973]],  Value = [[大人，您的手下人才济济，少我一个或多我一个都没影响的！%k%%e%]],
	Name = [[MSG974]],  Value = [[我无法帮您的，很抱歉！%k%%e%]],
	Name = [[MSG975]],  Value = [[不用多说了，大丈夫生死何足惧！！%k%%e%]],
	Name = [[MSG976]],  Value = [[多说无益！%k%%e%]],
	Name = [[MSG977]],  Value = [[我是不可能加入你的！%k%%e%]],
	Name = [[MSG978]],  Value = [[要我加入叛军是不可能的！%k%%e%]],
	Name = [[MSG980]],  Value = [[多谢大人爱戴，我愿誓死效忠大人！%K%%e%]],
	Name = [[MSG981]],  Value = [[希望能为大人的霸业尽一份力%k%%e%]],
	Name = [[MSG982]],  Value = [[多谢大人厚爱！%k%%e%]],
	Name = [[MSG983]],  Value = [[我愿誓死效忠大人！%K%%e%]],
	Name = [[MSG984]],  Value = [[多谢大人！我愿弃暗投明！%K%%e%]],
	Name = [[MSG985]],  Value = [[多谢大人不杀之恩！我必定全力报效大人！%K%%e%]],
	Name = [[MSG986]],  Value = [[多谢大人不记前嫌！%K%%e%]],
	Name = [[MSG987]],  Value = [[我愿加入为大人效力！%K%%e%]],
	Name = [[MSG988]],  Value = [[我愿加入为大人的霸业尽一份力！%k%%e%]],
	Name = [[MSG500]],  Value = [[不知羞耻的家伙，有胆回头再和我较量！%k%%e%]],
	Name = [[MSG501]],  Value = [[别跑那麽快，小心跌下马来！%k%%e%]],
	Name = [[MSG502]],  Value = [[%S2%鼠辈！竟然夹着尾巴逃了，哈哈哈....%k%%e%]],
	Name = [[MSG503]],  Value = [[别逃！一决胜负吧！%k%%e%]],
	Name = [[MSG504]],  Value = [[不要脸，每次都逃！%k%%e%]],
	Name = [[MSG505]],  Value = [[说到逃跑，你倒是满在行的....%k%%e%]],
	Name = [[MSG506]],  Value = [[哼！下次再宰了你！%k%%e%]],
	Name = [[MSG507]],  Value = [[就这点本事，也敢出来！%k%%e%]],
	Name = [[MSG508]],  Value = [[没有本事也敢上战场！%k%%e%]],
	Name = [[MSG509]],  Value = [[回去修练修练吧！%k%%e%]],
	Name = [[MSG510]],  Value = [[逃走了！想不到你竟会用这招！%k%%e%]],
	Name = [[MSG511]],  Value = [[竟然逃了！我还打得不过瘾啊！%k%%e%]],
	Name = [[MSG512]],  Value = [[哼！逃走了！我还没玩够耶！%k%%e%]],
	Name = [[MSG513]],  Value = [[我才用了几招耶！哈哈哈....%k%%e%]],
	Name = [[MSG514]],  Value = [[算你命大！哈哈哈....%k%%e%]],
	Name = [[MSG515]],  Value = [[你也没什麽了不起嘛！哈哈哈....%k%%e%]],
	Name = [[MSG516]],  Value = [[想跟我斗还早的很！%k%%e%]],
	Name = [[MSG517]],  Value = [[哼！想赢我！也不先打听打听，我是什麽人！%k%%e%]],
	Name = [[MSG518]],  Value = [[哼！想单挑！也不先打听打听，我是什麽人！%k%%e%]],
	Name = [[MSG519]],  Value = [[真是没意思！%k%%e%]],
	Name = [[MSG520]],  Value = [[真是脓包一个！哈哈哈....%k%%e%]],
	Name = [[MSG521]],  Value = [[真是太简单啦！%k%%e%]],
	Name = [[MSG522]],  Value = [[有没有像样一点的对手啊！%k%%e%]],
	Name = [[MSG523]],  Value = [[吓到了吧，这只是牛刀小试而已！%k%%e%]],
	Name = [[MSG524]],  Value = [[逃吧！下次别让我碰上了！%k%%e%]],
	Name = [[MSG525]],  Value = [[下次你就没那麽幸运了！%k%%e%]],
	Name = [[MSG526]],  Value = [[让你逃吧！趁我还没改变主意，快快消失！%k%%e%]],
	Name = [[MSG527]],  Value = [[别以为逃得了！很快又会见面的！%k%%e%]],
	Name = [[MSG528]],  Value = [[别以为逃得了！天罗地网等着你！%k%%e%]],
	Name = [[MSG529]],  Value = [[别以为逃得了！我已布下天罗地网等着你！%k%%e%]],
	Name = [[MSG530]],  Value = [[别以为你还有地方逃，很快你们就会灭亡的！%k%%e%]],
	Name = [[MSG531]],  Value = [[纵使你逃到天涯海角也逃不出我的手掌心！%k%%e%]],
	Name = [[MSG532]],  Value = [[逃得了一时，逃不了一世！%k%%e%]],
	Name = [[MSG533]],  Value = [[我还没使出绝招人就逃了！%k%%e%]],
	Name = [[MSG534]],  Value = [[逃的还真快！%k%%e%]],
	Name = [[MSG535]],  Value = [[功夫不怎麽样，逃命倒是一流的！%k%%e%]],
	Name = [[MSG536]],  Value = [[算你命大！否则明年的今天就是你的忌日！%k%%e%]],
	Name = [[MSG537]],  Value = [[还以为你会有两下子！%k%%e%]],
	Name = [[MSG538]],  Value = [[咦！怎麽逃得这麽快！%k%%e%]],
	Name = [[MSG539]],  Value = [[和我挑战，不是自讨苦吃吗？%k%%e%]],
	Name = [[MSG540]],  Value = [[遇到第一，你还是只能做第二！%k%%e%]],
	Name = [[MSG541]],  Value = [[我不是没有警告你！%k%%e%]],
	Name = [[MSG542]],  Value = [[你何必自不量力呢？%k%%e%]],
	Name = [[MSG543]],  Value = [[想也知道你是不可能胜过我的%k%%e%]],
	Name = [[MSG544]],  Value = [[嘿嘿！用脚指头想也知道，你想胜是不可能的%k%%e%]],
	Name = [[MSG545]],  Value = [[嘿嘿！用大姆指想也知道，你想胜是不可能的%k%%e%]],
	Name = [[MSG546]],  Value = [[嘿嘿！用小指头想也知道，你想胜是不可能的%k%%e%]],
	Name = [[MSG547]],  Value = [[看到你逃命的功夫，本人自叹不如%k%%e%]],
	Name = [[MSG548]],  Value = [[你的一举一动，早在本人的预料之中%k%%e%]],
	Name = [[MSG549]],  Value = [[看你夹着尾巴逃走，早在本人的预料之中%k%%e%]],
	Name = [[MSG550]],  Value = [[说到逃，难得有人会比你强%k%%e%]],
	Name = [[MSG551]],  Value = [[练个十年再找我吧！哈哈哈...%k%%e%]],
	Name = [[MSG552]],  Value = [[哼！让你逃走了%k%%e%]],
	Name = [[MSG553]],  Value = [[不要脸！你逃走的功夫真是一流的%k%%e%]],
	Name = [[MSG554]],  Value = [[遇到我你只有逃走的份！哈哈哈...%k%%e%]],
	Name = [[MSG555]],  Value = [[哈哈！你逃的还真快%k%%e%]],
	Name = [[MSG556]],  Value = [[连我都打不过，还想出来混啊%k%%e%]],
	Name = [[MSG557]],  Value = [[滚回老家吃奶吧%k%%e%]],
	Name = [[MSG558]],  Value = [[哼！下次就没有这麽便宜的事%k%%e%]],
	Name = [[MSG559]],  Value = [[还逃！刚刚的威风到那里去了%k%%e%]],
	Name = [[MSG560]],  Value = [[别逃！没两把刷子就不要出来现%k%%e%]],
	Name = [[MSG561]],  Value = [[怎麽！不服就再来打啊！%k%%e%]],
	Name = [[MSG562]],  Value = [[想在太岁头上动土，门都没有！%k%%e%]],
	Name = [[MSG563]],  Value = [[想在太岁头上动土，活的不耐烦啊！%k%%e%]],
	Name = [[MSG564]],  Value = [[怎麽如此的不堪一击啊！%k%%e%]],
	Name = [[MSG565]],  Value = [[别走！让我将你打下马来！%k%%e%]],
	Name = [[MSG566]],  Value = [[下次绝不让你轻易逃走！%k%%e%]],
	Name = [[MSG567]],  Value = [[这样就逃！你也不怕丢脸啊！%k%%e%]],
	Name = [[MSG568]],  Value = [[说到逃！真该叫你第一名%k%%e%]],
	Name = [[MSG600]],  Value = [[真是不堪一击！%k%%e%]],
	Name = [[MSG601]],  Value = [[凭这两三招也敢出来献丑！%k%%e%]],
	Name = [[MSG602]],  Value = [[你想赢我，还早一百年啊！%k%%e%]],
	Name = [[MSG603]],  Value = [[早说过你会後悔的....%k%%e%]],
	Name = [[MSG604]],  Value = [[凭你的身手，滚回家吃奶吧，哈哈哈....%k%%e%]],
	Name = [[MSG605]],  Value = [[要我手下留情，不嫌太晚了吗！%k%%e%]],
	Name = [[MSG606]],  Value = [[枉费你一身武艺，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG607]],  Value = [[枉费你一身武艺，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG608]],  Value = [[枉费你一身武艺，我还是不放在眼里！%k%%e%]],
	Name = [[MSG609]],  Value = [[枉费你一身武艺，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG610]],  Value = [[枉费你一身武艺，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG611]],  Value = [[枉费你一身武艺，跟我比还是不够看！%k%%e%]],
	Name = [[MSG612]],  Value = [[枉费你一身武艺，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG613]],  Value = [[枉费你一身武艺，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG614]],  Value = [[枉费你一身武艺，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG615]],  Value = [[枉费你一身武艺，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG616]],  Value = [[枉费你一身武艺，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG617]],  Value = [[纵使你相当厉害，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG618]],  Value = [[纵使你相当厉害，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG619]],  Value = [[纵使你相当厉害，我还是不放在眼里！%k%%e%]],
	Name = [[MSG620]],  Value = [[纵使你相当厉害，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG621]],  Value = [[纵使你相当厉害，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG622]],  Value = [[纵使你相当厉害，跟我比还是不够看！%k%%e%]],
	Name = [[MSG623]],  Value = [[纵使你相当厉害，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG624]],  Value = [[纵使你相当厉害，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG625]],  Value = [[纵使你相当厉害，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG626]],  Value = [[纵使你相当厉害，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG627]],  Value = [[纵使你相当厉害，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG628]],  Value = [[如此的狠角色，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG629]],  Value = [[如此的狠角色，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG630]],  Value = [[如此的狠角色，我还是不放在眼里！%k%%e%]],
	Name = [[MSG631]],  Value = [[如此的狠角色，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG632]],  Value = [[如此的狠角色，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG633]],  Value = [[如此的狠角色，跟我比还是不够看！%k%%e%]],
	Name = [[MSG634]],  Value = [[如此的狠角色，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG635]],  Value = [[如此的狠角色，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG636]],  Value = [[如此的狠角色，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG637]],  Value = [[如此的狠角色，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG638]],  Value = [[如此的狠角色，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG639]],  Value = [[虽然你兵强马壮，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG640]],  Value = [[虽然你兵强马壮，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG641]],  Value = [[虽然你兵强马壮，我还是不放在眼里！%k%%e%]],
	Name = [[MSG642]],  Value = [[虽然你兵强马壮，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG643]],  Value = [[虽然你兵强马壮，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG644]],  Value = [[虽然你兵强马壮，跟我比还是不够看！%k%%e%]],
	Name = [[MSG645]],  Value = [[虽然你兵强马壮，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG646]],  Value = [[虽然你兵强马壮，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG647]],  Value = [[虽然你兵强马壮，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG648]],  Value = [[虽然你兵强马壮，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG649]],  Value = [[虽然你兵强马壮，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG650]],  Value = [[即使你有三头六臂，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG651]],  Value = [[即使你有三头六臂，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG652]],  Value = [[即使你有三头六臂，我还是不放在眼里！%k%%e%]],
	Name = [[MSG653]],  Value = [[即使你有三头六臂，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG654]],  Value = [[即使你有三头六臂，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG655]],  Value = [[即使你有三头六臂，跟我比还是不够看！%k%%e%]],
	Name = [[MSG656]],  Value = [[即使你有三头六臂，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG657]],  Value = [[即使你有三头六臂，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG658]],  Value = [[即使你有三头六臂，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG659]],  Value = [[即使你有三头六臂，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG660]],  Value = [[即使你有三头六臂，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG661]],  Value = [[或许你很强，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG662]],  Value = [[或许你很强，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG663]],  Value = [[或许你很强，我还是不放在眼里！%k%%e%]],
	Name = [[MSG664]],  Value = [[或许你很强，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG665]],  Value = [[或许你很强，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG666]],  Value = [[或许你很强，跟我比还是不够看！%k%%e%]],
	Name = [[MSG667]],  Value = [[或许你很强，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG668]],  Value = [[或许你很强，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG669]],  Value = [[或许你很强，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG670]],  Value = [[或许你很强，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG671]],  Value = [[或许你很强，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG672]],  Value = [[就算你以前从未败过，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG673]],  Value = [[就算你以前从未败过，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG674]],  Value = [[就算你以前从未败过，我还是不放在眼里！%k%%e%]],
	Name = [[MSG675]],  Value = [[就算你以前从未败过，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG676]],  Value = [[就算你以前从未败过，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG677]],  Value = [[就算你以前从未败过，跟我比还是不够看！%k%%e%]],
	Name = [[MSG678]],  Value = [[就算你以前从未败过，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG679]],  Value = [[就算你以前从未败过，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG680]],  Value = [[就算你以前从未败过，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG681]],  Value = [[就算你以前从未败过，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG682]],  Value = [[就算你以前从未败过，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG683]],  Value = [[就算你是吃了熊心豹子胆，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG684]],  Value = [[就算你是吃了熊心豹子胆，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG685]],  Value = [[就算你是吃了熊心豹子胆，我还是不放在眼里！%k%%e%]],
	Name = [[MSG686]],  Value = [[就算你是吃了熊心豹子胆，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG687]],  Value = [[就算你是吃了熊心豹子胆，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG688]],  Value = [[就算你是吃了熊心豹子胆，跟我比还是不够看！%k%%e%]],
	Name = [[MSG689]],  Value = [[就算你是吃了熊心豹子胆，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG690]],  Value = [[就算你是吃了熊心豹子胆，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG691]],  Value = [[就算你是吃了熊心豹子胆，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG692]],  Value = [[就算你是吃了熊心豹子胆，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG693]],  Value = [[就算你是吃了熊心豹子胆，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG694]],  Value = [[就算你的功夫再强，还不是一样败在我的手下！%k%%e%]],
	Name = [[MSG695]],  Value = [[就算你的功夫再强，遇到我只有算你倒楣！%k%%e%]],
	Name = [[MSG696]],  Value = [[就算你的功夫再强，我还是不放在眼里！%k%%e%]],
	Name = [[MSG697]],  Value = [[就算你的功夫再强，也别想在太岁头上动土！%k%%e%]],
	Name = [[MSG698]],  Value = [[就算你的功夫再强，跟我比还是差了一截！%k%%e%]],
	Name = [[MSG699]],  Value = [[就算你的功夫再强，跟我比还是不够看！%k%%e%]],
	Name = [[MSG700]],  Value = [[就算你的功夫再强，惹毛了我下场都一样！%k%%e%]],
	Name = [[MSG701]],  Value = [[就算你的功夫再强，我要得胜也不过如探囊取物般的容易！%k%%e%]],
	Name = [[MSG702]],  Value = [[就算你的功夫再强，我还是能轻松获胜！%k%%e%]],
	Name = [[MSG703]],  Value = [[就算你的功夫再强，要战胜我只怕比登天还难！%k%%e%]],
	Name = [[MSG704]],  Value = [[就算你的功夫再强，遇到我还不是自讨苦吃！%k%%e%]],
	Name = [[MSG705]],  Value = [[别以为你自己很行，也不照照镜子%k%%e%]],
	Name = [[MSG240]],  Value = [[险胜！险胜！%k%%e%]],
	Name = [[MSG241]],  Value = [[哼！真是中看不中用的家伙！%k%%e%]],
	Name = [[MSG242]],  Value = [[哈哈！我也很强嘛....%k%%e%]],
	Name = [[MSG243]],  Value = [[看起来，你不怎麽样嘛！%k%%e%]],
	Name = [[MSG244]],  Value = [[连我都打不赢，你还想出来混啊！%k%%e%]],
	Name = [[MSG245]],  Value = [[哈哈！原来我也有这本事！%k%%e%]],
	Name = [[MSG246]],  Value = [[真险，今天又可以平安的度过了....%k%%e%]],
	Name = [[MSG247]],  Value = [[想不到！%S2%也败在我的手下！%k%%e%]],
	Name = [[MSG248]],  Value = [[逃走了！想不到你竟会用这招！%k%%e%]],
	Name = [[MSG249]],  Value = [[算你命大！哈哈哈....%k%%e%]],
	Name = [[MSG250]],  Value = [[你也没什麽了不起嘛！哈哈哈....%k%%e%]],
	Name = [[MSG251]],  Value = [[嗯！只要我想还是可以的！%k%%e%]],
	Name = [[MSG252]],  Value = [[哈哈！今天真走运！%k%%e%]],
	Name = [[MSG253]],  Value = [[咦！吓走他也不难嘛！%k%%e%]],
	Name = [[MSG254]],  Value = [[还以为你会有两下子！%k%%e%]],
	Name = [[MSG255]],  Value = [[咦！怎麽逃得这麽快！%k%%e%]],
	Name = [[MSG256]],  Value = [[别逃！刚刚的威风到那里去了！%k%%e%]],
	Name = [[MSG257]],  Value = [[怎麽如此的不堪一击啊！%k%%e%]],
	Name = [[MSG258]],  Value = [[咦！逃走了！早知道我就不用担心嘛！%k%%e%]],
	Name = [[MSG259]],  Value = [[咦！逃走了！看来我也不差嘛！%k%%e%]],
	Name = [[MSG260]],  Value = [[咦！逃走了！可见我也满行的！%k%%e%]],
	Name = [[MSG261]],  Value = [[惭愧！惭愧！险胜而已！%k%%e%]],
	Name = [[MSG262]],  Value = [[险胜！险胜！下次遇到得多注意注意！%k%%e%]],
	Name = [[MSG263]],  Value = [[好险！看来我福星高照！%k%%e%]],
	Name = [[MSG270]],  Value = [[胜负就留到下一次吧！%k%%e%]],
	Name = [[MSG271]],  Value = [[今天就先放你一马。%K%%E%]],
	Name = [[MSG272]],  Value = [[看来你我功夫在伯仲之间！%k%%e%]],
	Name = [[MSG273]],  Value = [[看来，你也很强嘛！%k%%e%]],
	Name = [[MSG274]],  Value = [[下次再领教你的高招吧！%k%%e%]],
	Name = [[MSG275]],  Value = [[想打败我没那麽容易吧！%k%%e%]],
	Name = [[MSG276]],  Value = [[只要我认真起来你也是没办法取胜的！%k%%e%]],
	Name = [[MSG277]],  Value = [[承让！承让！下次再领教你的真功夫吧！%k%%e%]],
	Name = [[MSG278]],  Value = [[可恶！就差一点点！%k%%e%]],
	Name = [[MSG279]],  Value = [[这次就算是平手吧！%k%%e%]],
	Name = [[MSG280]],  Value = [[看来你也不是个好欺负的人！%k%%e%]],
	Name = [[MSG281]],  Value = [[哼！下次再宰了你！%k%%e%]],
	Name = [[MSG282]],  Value = [[哼！这次放你一条生路！%k%%e%]],
	Name = [[MSG283]],  Value = [[哈哈....真是半斤八两！%k%%e%]],
	Name = [[MSG284]],  Value = [[你的运气不错，今天老子心情好就暂时放你一马！%k%%e%]],
	Name = [[MSG285]],  Value = [[找个机会堂堂正正的打一场吧！%k%%e%]],
	Name = [[MSG286]],  Value = [[下次再一决胜负吧！%k%%e%]],
	Name = [[MSG287]],  Value = [[别以为你很强，我只是和你玩玩而已！%k%%e%]],
	Name = [[MSG288]],  Value = [[你的人头就暂时寄在你的脖子上吧！%k%%e%]],
	Name = [[MSG289]],  Value = [[很好，我碰到对手了！%k%%e%]],
	Name = [[MSG290]],  Value = [[很好，你们也有几个人才嘛！%k%%e%]],
	Name = [[MSG300]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG301]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG302]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG303]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG304]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG305]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG306]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG307]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG308]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG309]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG310]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG311]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG312]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG313]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG314]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG315]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG316]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG317]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG318]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG319]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG320]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG321]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG322]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG323]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG324]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG325]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG326]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG327]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG328]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG329]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG330]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG331]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG332]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG333]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG334]],  Value = [[跟我%S1%交手，你一定会後悔的！%K%%E%]],
	Name = [[MSG335]],  Value = [[你的人头我要定了，有什麽遗言就快交代吧！%K%%E%]],
	Name = [[MSG336]],  Value = [[%S1%在此，谁敢与我一决死战！%K%%E%]],
	Name = [[MSG337]],  Value = [[我乃%S1%，不怕死的人尽管过来吧！%K%%E%]],
	Name = [[MSG338]],  Value = [[反贼，还不快快下马受缚！%K%%E%]],
	Name = [[MSG339]],  Value = [[和我%S1%交手是你一生最大的错误！%K%%E%]],
	Name = [[MSG340]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG341]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG342]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG343]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG344]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG345]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG346]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG347]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG348]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG349]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG350]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG351]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG352]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG353]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG354]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG355]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG356]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG357]],  Value = [[不知死活的家伙，这不是你该来的地方！%K%%E%]],
	Name = [[MSG358]],  Value = [[我乃%s1%是也！%k%%e%]],
	Name = [[MSG359]],  Value = [[我是%S1%，来比试一下吧！%K%%E%]],
	Name = [[MSG360]],  Value = [[完了！完了！搞不好今天要死在这里了！！%K%%E%]],
	Name = [[MSG361]],  Value = [[真要命，怎麽会碰上这个怪物！%K%%E%]],
	Name = [[MSG362]],  Value = [[好像是个狠角色，不可轻敌啊！%K%%E%]],
	Name = [[MSG363]],  Value = [[真糟糕，我的运气实在不好！%K%%E%]],
	Name = [[MSG364]],  Value = [[完了！完了！搞不好今天要死在这里了！！%K%%E%]],
	Name = [[MSG365]],  Value = [[真要命，怎麽会碰上这个怪物！%K%%E%]],
	Name = [[MSG366]],  Value = [[好像是个狠角色，不可轻敌啊！%K%%E%]],
	Name = [[MSG367]],  Value = [[真糟糕，我的运气实在不好！%K%%E%]],
	Name = [[MSG368]],  Value = [[完了！完了！搞不好今天要死在这里了！！%K%%E%]],
	Name = [[MSG369]],  Value = [[真要命，怎麽会碰上这个怪物！%K%%E%]],
	Name = [[MSG370]],  Value = [[好像是个狠角色，不可轻敌啊！%K%%E%]],
	Name = [[MSG371]],  Value = [[真糟糕，我的运气实在不好！%K%%E%]],
	Name = [[MSG372]],  Value = [[完了！完了！搞不好今天要死在这里了！！%K%%E%]],
	Name = [[MSG373]],  Value = [[真要命，怎麽会碰上这个怪物！%K%%E%]],
	Name = [[MSG374]],  Value = [[好像是个狠角色，不可轻敌啊！%K%%E%]],
	Name = [[MSG375]],  Value = [[真糟糕，我的运气实在不好！%K%%E%]],
	Name = [[MSG376]],  Value = [[完了！完了！搞不好今天要死在这里了！！%K%%E%]],
	Name = [[MSG377]],  Value = [[真要命，怎麽会碰上这个怪物！%K%%E%]],
	Name = [[MSG378]],  Value = [[好像是个狠角色，不可轻敌啊！%K%%E%]],
	Name = [[MSG379]],  Value = [[真糟糕，我的运气实在不好！%K%%E%]],
	Name = [[MSG380]],  Value = [[谁敢和我%S1%交手！%K%%E%]],
	Name = [[MSG381]],  Value = [[敢和我%S1%交手？来吧！%K%%E%]],
	Name = [[MSG382]],  Value = [[反贼%S2%，早早投降可以免你一死！%K%%E%]],
	Name = [[MSG383]],  Value = [[反贼%S2%，准备受死吧！%K%%E%]],
	Name = [[MSG384]],  Value = [[反贼%S2%，一决胜负吧！%K%%E%]],
	Name = [[MSG385]],  Value = [[就让你看看我的厉害！%K%%E%]],
	Name = [[MSG386]],  Value = [[谁敢和我%S1%交手！%K%%E%]],
	Name = [[MSG387]],  Value = [[敢和我%S1%交手？来吧！%K%%E%]],
	Name = [[MSG388]],  Value = [[反贼%S2%，早早投降可以免你一死！%K%%E%]],
	Name = [[MSG389]],  Value = [[反贼%S2%，准备受死吧！%K%%E%]],
	Name = [[MSG390]],  Value = [[反贼%S2%，一决胜负吧！%K%%E%]],
	Name = [[MSG391]],  Value = [[就让你看看我的厉害！%K%%E%]],
	Name = [[MSG392]],  Value = [[谁敢和我%S1%交手！%K%%E%]],
	Name = [[MSG393]],  Value = [[敢和我%S1%交手？来吧！%K%%E%]],
	Name = [[MSG394]],  Value = [[反贼%S2%，早早投降可以免你一死！%K%%E%]],
	Name = [[MSG395]],  Value = [[反贼%S2%，准备受死吧！%K%%E%]],
	Name = [[MSG396]],  Value = [[反贼%S2%，一决胜负吧！%K%%E%]],
	Name = [[MSG397]],  Value = [[就让你看看我的厉害！%K%%E%]],
	Name = [[MSG398]],  Value = [[谁敢和我%S1%交手！%K%%E%]],
	Name = [[MSG399]],  Value = [[敢和我%S1%交手？来吧！%K%%E%]],
	Name = [[MSG400]],  Value = [[别废话多说，一决胜负吧！%K%%E%]],
	Name = [[MSG401]],  Value = [[只动嘴巴是不会赢的，来吧！%K%%E%]],
	Name = [[MSG402]],  Value = [[别废话多说，一决胜负吧！%K%%E%]],
	Name = [[MSG403]],  Value = [[只动嘴巴是不会赢的，来吧！%K%%E%]],
	Name = [[MSG404]],  Value = [[别废话多说，一决胜负吧！%K%%E%]],
	Name = [[MSG405]],  Value = [[只动嘴巴是不会赢的，来吧！%K%%E%]],
	Name = [[MSG406]],  Value = [[别废话多说，一决胜负吧！%K%%E%]],
	Name = [[MSG407]],  Value = [[只动嘴巴是不会赢的，来吧！%K%%E%]],
	Name = [[MSG408]],  Value = [[别废话多说，一决胜负吧！%K%%E%]],
	Name = [[MSG409]],  Value = [[只动嘴巴是不会赢的，来吧！%K%%E%]],
}
