(function(){"use strict";var n={8907:function(n,t,e){var r=e(9242),o=e(3396),i=e(7139);const c={class:"container"},s={class:"main"},a=(0,o._)("h1",{class:"title"},[(0,o.Uk)(" Welcome to "),(0,o._)("a",null,"Next.js!")],-1),u=(0,o._)("p",{class:"description"},[(0,o.Uk)(" Get started by editing{' '} "),(0,o._)("code",{class:"{styles.code}"},"pages/index.js")],-1),f={class:"grid"},l=(0,o._)("footer",{class:"footer"},[(0,o._)("a",{target:"_blank",rel:"noopener noreferrer"}," Developed by Sofiia ")],-1);function p(n,t,e,r,p,d){return(0,o.wg)(),(0,o.iD)("div",c,[(0,o._)("main",s,[a,u,(0,o._)("div",f,[((0,o.wg)(!0),(0,o.iD)(o.HY,null,(0,o.Ko)(n.projects,(n=>((0,o.wg)(),(0,o.iD)("a",{class:"card",key:n},[(0,o._)("h2",null,(0,i.zw)(n["Title"])+"→",1),(0,o._)("p",null,(0,i.zw)(n["Content"]),1)])))),128))])]),l])}var d={name:"App",components:{},data:()=>({projects:[]}),mounted:async function(){await this.getProjects()},methods:{async getProjects(){const n=await fetch("/api/projects");this.projects="["+await n.json()+"]",this.projects=JSON.parse(this.projects)}}},v=e(89);const h=(0,v.Z)(d,[["render",p]]);var b=h;(0,r.ri)(b).mount("#app")}},t={};function e(r){var o=t[r];if(void 0!==o)return o.exports;var i=t[r]={exports:{}};return n[r](i,i.exports,e),i.exports}e.m=n,function(){var n=[];e.O=function(t,r,o,i){if(!r){var c=1/0;for(f=0;f<n.length;f++){r=n[f][0],o=n[f][1],i=n[f][2];for(var s=!0,a=0;a<r.length;a++)(!1&i||c>=i)&&Object.keys(e.O).every((function(n){return e.O[n](r[a])}))?r.splice(a--,1):(s=!1,i<c&&(c=i));if(s){n.splice(f--,1);var u=o();void 0!==u&&(t=u)}}return t}i=i||0;for(var f=n.length;f>0&&n[f-1][2]>i;f--)n[f]=n[f-1];n[f]=[r,o,i]}}(),function(){e.n=function(n){var t=n&&n.__esModule?function(){return n["default"]}:function(){return n};return e.d(t,{a:t}),t}}(),function(){e.d=function(n,t){for(var r in t)e.o(t,r)&&!e.o(n,r)&&Object.defineProperty(n,r,{enumerable:!0,get:t[r]})}}(),function(){e.g=function(){if("object"===typeof globalThis)return globalThis;try{return this||new Function("return this")()}catch(n){if("object"===typeof window)return window}}()}(),function(){e.o=function(n,t){return Object.prototype.hasOwnProperty.call(n,t)}}(),function(){var n={143:0};e.O.j=function(t){return 0===n[t]};var t=function(t,r){var o,i,c=r[0],s=r[1],a=r[2],u=0;if(c.some((function(t){return 0!==n[t]}))){for(o in s)e.o(s,o)&&(e.m[o]=s[o]);if(a)var f=a(e)}for(t&&t(r);u<c.length;u++)i=c[u],e.o(n,i)&&n[i]&&n[i][0](),n[i]=0;return e.O(f)},r=self["webpackChunkweb_client"]=self["webpackChunkweb_client"]||[];r.forEach(t.bind(null,0)),r.push=t.bind(null,r.push.bind(r))}();var r=e.O(void 0,[998],(function(){return e(8907)}));r=e.O(r)})();
//# sourceMappingURL=app.d567081d.js.map