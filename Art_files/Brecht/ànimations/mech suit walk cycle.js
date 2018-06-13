(function (cjs, an) {

var p; // shortcut to reference prototypes
var lib={};var ss={};var img={};
lib.ssMetadata = [
		{name:"mech suit walk cycle_atlas_", frames: [[118,339,116,442],[0,339,116,442],[0,0,237,337],[236,339,82,293],[239,138,83,89],[239,0,138,67],[239,69,138,67],[239,229,83,83]]}
];


// symbols:



(lib.mechparts_0000s_0000_Kleurtoon_verzadiging4 = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(0);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0000s_0001_rightleg = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(1);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0001s_0000_Kleurtoon_verzadiging1 = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(2);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0005_begin = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(3);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0006_Laag4kopiëren = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(4);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0007_Kleurtoon_verzadiging5 = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(5);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0008_Laag10kopiëren = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(6);
}).prototype = p = new cjs.Sprite();



(lib.mechparts_0009_Kleurtoon_verzadiging6 = function() {
	this.spriteSheet = ss["mech suit walk cycle_atlas_"];
	this.gotoAndStop(7);
}).prototype = p = new cjs.Sprite();



// stage content:
(lib.mechsuitwalkcycle = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Laag_1
	this.instance = new lib.mechparts_0000s_0000_Kleurtoon_verzadiging4();
	this.instance.parent = this;
	this.instance.setTransform(298,169,0.438,0.438);

	this.instance_1 = new lib.mechparts_0008_Laag10kopiëren();
	this.instance_1.parent = this;
	this.instance_1.setTransform(281,116,0.438,0.438);

	this.instance_2 = new lib.mechparts_0006_Laag4kopiëren();
	this.instance_2.parent = this;
	this.instance_2.setTransform(326.4,99,0.438,0.438,0,0,180);

	this.instance_3 = new lib.mechparts_0001s_0000_Kleurtoon_verzadiging1();
	this.instance_3.parent = this;
	this.instance_3.setTransform(303,57,0.438,0.438);

	this.instance_4 = new lib.mechparts_0007_Kleurtoon_verzadiging5();
	this.instance_4.parent = this;
	this.instance_4.setTransform(362,116,0.438,0.438);

	this.instance_5 = new lib.mechparts_0000s_0001_rightleg();
	this.instance_5.parent = this;
	this.instance_5.setTransform(349,169,0.438,0.438);

	this.instance_6 = new lib.mechparts_0009_Kleurtoon_verzadiging6();
	this.instance_6.parent = this;
	this.instance_6.setTransform(381,102,0.438,0.438);

	this.instance_7 = new lib.mechparts_0005_begin();
	this.instance_7.parent = this;
	this.instance_7.setTransform(334,57,0.504,0.504);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]}).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:349,y:169}},{t:this.instance_4,p:{x:362}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:281}},{t:this.instance,p:{x:298,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:341,y:169}},{t:this.instance_4,p:{x:369}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:268}},{t:this.instance,p:{x:311,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:330,y:169}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:318,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:314,y:169}},{t:this.instance_4,p:{x:388}},{t:this.instance_3,p:{y:53}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:254}},{t:this.instance,p:{x:328,y:157}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:381,y:102}},{t:this.instance_5,p:{x:306,y:156}},{t:this.instance_4,p:{x:379}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:326.4,y:99}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:343,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:101}},{t:this.instance_5,p:{x:321,y:156}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:101}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:328,y:169}}]},1).to({state:[{t:this.instance_7},{t:this.instance_6,p:{x:379,y:100}},{t:this.instance_5,p:{x:340,y:145}},{t:this.instance_4,p:{x:375}},{t:this.instance_3,p:{y:57}},{t:this.instance_2,p:{x:328.4,y:100}},{t:this.instance_1,p:{x:261}},{t:this.instance,p:{x:312,y:169}}]},1).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(556,257,141.5,305.6);
// library properties:
lib.properties = {
	id: '986F24926A44954394052C18119079C7',
	width: 550,
	height: 400,
	fps: 12,
	color: "#FFFFFF",
	opacity: 1.00,
	manifest: [
		{src:"images/mech suit walk cycle_atlas_.png?1527782314246", id:"mech suit walk cycle_atlas_"}
	],
	preloads: []
};



// bootstrap callback support:

(lib.Stage = function(canvas) {
	createjs.Stage.call(this, canvas);
}).prototype = p = new createjs.Stage();

p.setAutoPlay = function(autoPlay) {
	this.tickEnabled = autoPlay;
}
p.play = function() { this.tickEnabled = true; this.getChildAt(0).gotoAndPlay(this.getTimelinePosition()) }
p.stop = function(ms) { if(ms) this.seek(ms); this.tickEnabled = false; }
p.seek = function(ms) { this.tickEnabled = true; this.getChildAt(0).gotoAndStop(lib.properties.fps * ms / 1000); }
p.getDuration = function() { return this.getChildAt(0).totalFrames / lib.properties.fps * 1000; }

p.getTimelinePosition = function() { return this.getChildAt(0).currentFrame / lib.properties.fps * 1000; }

an.bootcompsLoaded = an.bootcompsLoaded || [];
if(!an.bootstrapListeners) {
	an.bootstrapListeners=[];
}

an.bootstrapCallback=function(fnCallback) {
	an.bootstrapListeners.push(fnCallback);
	if(an.bootcompsLoaded.length > 0) {
		for(var i=0; i<an.bootcompsLoaded.length; ++i) {
			fnCallback(an.bootcompsLoaded[i]);
		}
	}
};

an.compositions = an.compositions || {};
an.compositions['986F24926A44954394052C18119079C7'] = {
	getStage: function() { return exportRoot.getStage(); },
	getLibrary: function() { return lib; },
	getSpriteSheet: function() { return ss; },
	getImages: function() { return img; }
};

an.compositionLoaded = function(id) {
	an.bootcompsLoaded.push(id);
	for(var j=0; j<an.bootstrapListeners.length; j++) {
		an.bootstrapListeners[j](id);
	}
}

an.getComposition = function(id) {
	return an.compositions[id];
}



})(createjs = createjs||{}, AdobeAn = AdobeAn||{});
var createjs, AdobeAn;