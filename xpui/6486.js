"use strict";(("undefined"!=typeof self?self:global).webpackChunkclient_web=("undefined"!=typeof self?self:global).webpackChunkclient_web||[]).push([[6486],{45664:(e,s,a)=>{a.d(s,{M:()=>k,f:()=>E});var t=a(30758),n=a(97500),l=a.n(n),i=a(93523),r=a(1820),o=a(46607),d=a(31417),c=a(50324),u=a(622),h=a(35035);var m=a(99701),p=a(50342),x=a(94141),g=a(6038),v=a(48014),f=a(13787),N=a(69285);const w="BKsbV2Xl786X9a09XROH",b="HbKLiGoYM4dpuK8L4TMX",y="VmwiDoU6RpqyzK_n7XRO",j="rEx3EYgBzS8SoY7dmC6x";var R=a(86070);let k=function(e){return e.xs="small",e.sm="medium",e.md="large",e}({});const S=e=>{const{currentTarget:s,detail:a}=e;a>0&&s&&s.blur()},E=({uri:e,isFollowing:s,onFollow:a,size:n=k.sm,className:E,onClick:I=(()=>{}),showUpsell:M=!0,canDownload:O=!0,condensedAll:C,condensed:P})=>{const[A,_]=(0,t.useState)(!1),{capability:z,availability:D,addDownload:V}=(0,f.$)(e,O),Y=(0,v.V)(),B=(0,N.e)(e);((e,s)=>{const a=(0,c.i)(),n=(0,t.useRef)(!1);(0,t.useEffect)((()=>{e===h.kw.DOWNLOADING&&!1===n.current&&(n.current=!0,a.say(d.Ru.get("download.downloading",s.totalItems)))}),[a,e,s]);const l=(0,u.Z)(e);(0,t.useEffect)((()=>{l===h.kw.DOWNLOADING&&e===h.kw.YES&&(n.current=!1,a.say(d.Ru.get("download.complete")))}),[a,l,e])})(D,B);const L=(0,t.useCallback)((e=>{e.preventDefault(),z===h.vs.NO_PERMISSION?I(e,h.NV.NO_PERMISSION):(!1===s?(a(),_(!0)):V(),I(e,h.NV.ADD)),S(e)}),[V,z,s,I,a]),T=(0,t.useCallback)((s=>{s.preventDefault(),Y(e),S(s),I(s,h.NV.REMOVE)}),[e,Y,I]);if((0,t.useEffect)((()=>{!0===A&&!0===s&&(V(),_(!1))}),[s,A,V]),D===h.kw.YES)return(0,R.jsx)(m.Zp,{label:d.Ru.get("download.remove"),children:(0,R.jsx)(i.H,{className:E,onClick:T,iconOnly:r.F,semanticColor:"textBrightAccent",size:n,"aria-label":d.Ru.get("download.remove"),"aria-checked":!0,condensedAll:C,condensed:P})});if(z===h.vs.NO_CAPABILITY||z===h.vs.NO_PERMISSION_HIDE)return null;if(z===h.vs.NO_PERMISSION)return M?(0,R.jsx)("div",{className:l()(w,E),children:(0,R.jsx)(g.y,{offset:[-2,20],action:"toggle",trigger:"click",content:(0,R.jsx)(x.z,{children:(0,R.jsx)("span",{children:d.Ru.get("download.upsell")})}),renderInline:!1,children:(0,R.jsx)("div",{children:(0,R.jsx)(m.Zp,{label:d.Ru.get("download.download"),children:(0,R.jsx)(i.H,{onClick:L,iconOnly:o.i,size:n,"aria-label":d.Ru.get("download.download"),"aria-checked":!1,condensedAll:C,condensed:P})})})})}):null;if(D===h.kw.NO)return(0,R.jsx)(m.Zp,{label:d.Ru.get("download.download"),children:(0,R.jsx)(i.H,{className:E,onClick:L,iconOnly:o.i,size:n,"aria-label":d.Ru.get("download.download"),"aria-checked":!1,condensedAll:C,condensed:P})});let X;switch(n){case k.xs:X=16;break;case k.sm:X=24;break;default:X=32}return(0,R.jsxs)("div",{className:l()(y,E),role:"switch","aria-checked":!0,children:[(0,R.jsx)(m.Zp,{label:d.Ru.get("download.cancel"),children:(0,R.jsx)("button",{style:{height:X,width:X},className:l()(b,E),onClick:T,"aria-label":d.Ru.get("download.cancel")})}),(0,R.jsx)("span",{className:l()(j),children:(0,R.jsx)(p.C,{"aria-valuetext":d.Ru.get("progress.downloading-tracks"),percentage:B.percentage,size:X})})]})}},50866:(e,s,a)=>{a.d(s,{d:()=>d});var t=a(97500),n=a.n(t),l=a(97701),i=a(67174);const r="UyzJidwrGk3awngSGIwv";var o=a(86070);const d=({durationMs:e,className:s,displaySeconds:a})=>{const{hours:t,minutes:d,seconds:c}=(0,l.S)(e);return a=!1!==a&&!t&&c,(0,o.jsx)("span",{className:n()(r,s),children:(0,i.j)({h:t,m:d,s:a?c:0})})}},55769:(e,s,a)=>{a.d(s,{j:()=>S});var t=a(79225);const n="wIA_5Ypq0rltNPeZQpM4",l="Swi6YtNEFCCVz8l4y75v",i="pklLPOhfigdytL9bPoth",r="sb24Y8kdMZInJ8aI8dXT";var o=a(86070);function d({ariaValueText:e,max:s,current:a}){const t=s&&a?100*Math.min(1,a/s):0,d={transform:`translateX(-${100-t}%)`},c=e||`${Math.round(t)}%`;return(0,o.jsxs)("div",{className:n,role:"progressbar",tabIndex:0,"aria-valuenow":a,"aria-valuemin":0,"aria-valuemax":s,"aria-valuetext":c,children:[(0,o.jsx)("div",{className:l}),(0,o.jsx)("div",{className:i,children:(0,o.jsx)("div",{"data-testid":"progressBarFg",className:r,style:d})})]})}const c="qfYkuLpETFW3axnfMntO",u="_q93agegdE655O5zPz6l",h="z7Yl7CIT1AB0y91f_moh",m="iLIlkUcfIq56KncGtX7u",p="nV50yZ6BR_TIuWP3l7b1",x="qLjIx_SzBEpDRA_q7kxQ";var g=a(422),v=a(75943),f=a(31417),N=a(97500),w=a.n(N),b=a(50866),y=a(97701),j=a(67174);const R="xWm_uA0Co4SXVxaO7wlB",k=({durationMs:e,className:s,displaySeconds:a})=>{const{hours:t,minutes:n,seconds:l}=(0,y.S)(e);a=!1!==a&&!t&&l;const i=(0,j.j)({h:t,m:n,s:a?l:0});return i?(0,o.jsx)("span",{className:w()(R,s),children:f.Ru.get("time.left",i)}):null},S=e=>{const{resumePositionMs:s=0,releaseDate:a,isPlaying:n,fullyPlayed:l,durationMs:i,position:r=s,compactVariant:N=!1,className:y,progressBarClassName:j,progressStateClassName:R,releaseDateClassName:S}=e,E=a&&a.isoString?(0,o.jsx)(g.E,{as:"p",variant:"bodySmall",className:u,children:(0,t.V2)((0,t.ad)(a.isoString),a.precision)}):null,I=(()=>{if(0===i)return null;if(l&&!n)return(0,o.jsxs)("div",{className:w()(m,R),children:[(0,o.jsx)(g.E,{as:"p",variant:"bodySmall",className:h,children:f.Ru.get("episode.audiobook.chapter.finished")}),(0,o.jsx)(v.i,{size:"small",className:x,"aria-hidden":"true"})]});if(r>0||n){const e=Math.ceil(Math.max(i-r,0));return(0,o.jsx)("div",{className:w()(m,R),children:(0,o.jsx)(g.E,{as:"p",variant:"bodySmall",className:h,children:(0,o.jsx)(k,{durationMs:e,displaySeconds:!N&&void 0})})})}return(0,o.jsx)(g.E,{as:"p",variant:"bodySmall",className:w()(u,S),"data-testid":"episode-progress-not-played",children:(0,o.jsx)(b.d,{durationMs:i,displaySeconds:!N&&void 0})})})(),M=0===i?null:!l&&r>0||n?(0,o.jsx)("div",{className:w()(p,j),children:(0,o.jsx)(d,{current:r,max:i})}):null;return E||I||M?(0,o.jsxs)("div",{className:w()(c,y),children:[E,I,M]}):null}},50324:(e,s,a)=>{a.d(s,{i:()=>l});var t=a(30758);class n{constructor(e={}){this.settings={level:e.level||"polite",parent:e.parent||document.body,idPrefix:e.idPrefix||"live-region-",delay:e.delay||0},this.currentRegion=document.createElement("span")}say(e,s=this.settings.delay){this.clearNode(),this.currentRegion=document.createElement("span"),this.currentRegion.id=this.settings.idPrefix+Math.floor(1e4*Math.random());const a="assertive"!==this.settings.level?"status":"alert";this.currentRegion.setAttribute("aria-live",this.settings.level),this.currentRegion.setAttribute("role",a),this.currentRegion.setAttribute("style","clip: rect(1px, 1px, 1px, 1px); height: 1px; overflow: hidden; position: absolute; white-space: nowrap; width: 1px"),this.settings.parent.appendChild(this.currentRegion),window.setTimeout((()=>{this.currentRegion.textContent=e}),s)}clearNode(){const e=this.settings.parent.querySelector(`[id^="${this.settings.idPrefix}"]`);e&&this.settings.parent.removeChild(e)}}const l=({delay:e,idPrefix:s,level:a,parent:l}={})=>{const i=(0,t.useMemo)((()=>new n({delay:e,idPrefix:s,level:a,parent:l})),[e,s,a,l]);return(0,t.useEffect)((()=>()=>{i.clearNode()}),[i]),i}},622:(e,s,a)=>{a.d(s,{Z:()=>n});var t=a(30758);function n(e){const s=(0,t.useRef)();return(0,t.useEffect)((()=>{s.current=e}),[e]),s.current}}}]);