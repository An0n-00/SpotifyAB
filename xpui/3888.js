"use strict";(("undefined"!=typeof self?self:global).webpackChunkclient_web=("undefined"!=typeof self?self:global).webpackChunkclient_web||[]).push([[3888],{43888:(e,n,t)=>{t.d(n,{X:()=>d,A:()=>V});var r=t(30758),i=t(12072),a=t(25060),o=t(92107),l=t(84187),c=t(35322);const s="KsnGjjEeMb2miriJrkjW";var u=t(86070),d=function(){var e,n=o.Ru.getLocaleForTranslation(),t=null!==(e=c.IB[n])&&void 0!==e?e:c.IB.en,d=(0,l.ZZ)(),f=(0,r.useCallback)((function(){d({type:"OPEN"})}),[d]);return(0,u.jsx)("div",{className:s,children:(0,u.jsx)(i.n,{iconLeading:a.d,size:"small",onClick:f,"data-testid":"language-selection-button",children:t.displayName})})},f=t(52542),p=t(12341),b=(t(7651),t(30456),t(26701),t(25550),t(37417),t(11737),t(51691),t(702),t(5672),t(43379),t(34192),t(88856),t(51565),t(15342),t(18316),t(8143)),h=t(88677),v=t(13534),g=t(38195),y=(t(83234),t(78551),t(79024),t(70750),t(9657),t(82467),t(97460),t(93577),t(5728),t(24136),t(54520),t(91531),t(93678),t(34145),t(80366)),j=t(83753),O=t(81419),m=t(16920),w=t(85610),x=t(83879);const k="ZpqHX3kvsJIsR1QIc4kf";function C(e,n){var t=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);n&&(r=r.filter((function(n){return Object.getOwnPropertyDescriptor(e,n).enumerable}))),t.push.apply(t,r)}return t}function P(e){for(var n=1;n<arguments.length;n++){var t=null!=arguments[n]?arguments[n]:{};n%2?C(Object(t),!0).forEach((function(n){(0,f.A)(e,n,t[n])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(t)):C(Object(t)).forEach((function(n){Object.defineProperty(e,n,Object.getOwnPropertyDescriptor(t,n))}))}return e}var E=function(e){var n=e.children,t=e.locale,r=e.onClick,i=e.type,a=void 0===i?"button":i,l=t===O.Xn,c=(0,x.vf)(window.location.pathname),s=(0,y.o_)(window.location.pathname),d=(0,j.W)({type:"route",uri:c?m.c.HOME:null==s?void 0:s.toURI()}),f=function(e){if("button"===a){e.preventDefault();var n=new URL(window.location.href);window.location.href.includes("locale")&&n.searchParams.delete("locale"),window.location.href=n.href}r(t)},p={className:k,id:t,onClick:function(e){return f(e)},"data-testid":"language-option-".concat(t)};if("link"===a){var b=(0,w.ll)(window.location.pathname,!l),h=(0,w.hF)(b,(0,o.a7)(t).baseName),v=d?h:window.location.pathname,g=function(e){return e.endsWith("/")?e.slice(0,-1):e}("".concat(window.location.origin).concat(v));return(0,u.jsx)("a",P(P({href:g},p),{},{children:n}))}return(0,u.jsx)("button",P(P({},p),{},{children:n}))};const N="eYLSfS4EKfwsdTsItWkY";var B=function(e){var n=e.style,t=e.children;return(0,u.jsx)("div",{className:N,style:n,children:t})},D=t(97500),L=t.n(D);const R="KPuW9eE4auKgVgMtPZoH",S="zCedVxWmwaJhPIGzJixP",I="qzuG9AHNXHQrOGF06r9A",A="ZgjCz5A7qOyprtvcLK8y",z="BSwvSvqHiQUVuim4Eidv",M="TpluDuF12UKv3IIq_VDu";var Z=function(e){var n=e.onClose,t=e.children,i=(0,r.useRef)(null),a=(0,l.iL)().isOpen;return(0,u.jsx)("div",{"data-testid":"language-selection-modal",className:L()(R,(0,f.A)({},S,a)),onClick:function(e){e.target===i.current&&n()},role:"presentation",ref:i,children:t})},F=function(e){var n=e.ariaDescribedBy,t=e.ariaLabelledBy,r=e.children,i=(0,l.iL)().isOpen;return(0,u.jsx)("div",{className:I,role:"dialog",hidden:!i,"aria-modal":!0,"aria-labelledby":t,"aria-describedby":n,children:r})},H=t(64399),K=function(e){var n=e.onClose;return(0,u.jsx)("button",{"data-testid":"close-button",className:M,onClick:function(){n()},children:(0,u.jsx)(H.M,{size:"small","aria-label":o.Ru.get("close")})})},W=t(9003),q=t(25314),U=t(96324),_=t(5280);t(53276);function G(e,n){var t=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);n&&(r=r.filter((function(n){return Object.getOwnPropertyDescriptor(e,n).enumerable}))),t.push.apply(t,r)}return t}function J(e){for(var n=1;n<arguments.length;n++){var t=null!=arguments[n]?arguments[n]:{};n%2?G(Object(t),!0).forEach((function(n){(0,f.A)(e,n,t[n])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(t)):G(Object(t)).forEach((function(n){Object.defineProperty(e,n,Object.getOwnPropertyDescriptor(t,n))}))}return e}var V=function(e){var n,t=e.languageSelectionModalRef,i=(0,r.useRef)(null),a=(0,r.useState)("0"),s=(0,p.A)(a,2),d=s[0],f=s[1],y=(0,l.ZZ)(),j=(0,h.d4)(W.MU),O=(0,r.useCallback)((function(){y({type:"CLOSE"})}),[y]),m=(0,l.iL)().isOpen,w=(0,r.useCallback)((function(){var e;f("".concat(null===(e=i.current)||void 0===e?void 0:e.getBoundingClientRect().height,"px"))}),[f]),k=function(e){var n;(0,_.n0)({name:"sp_locale",value:e,domain:(n="open.spotify.com",n.substring(n.indexOf("."))),days:365}),O()};if(n=O,(0,r.useEffect)((function(){var e=function(e){"Escape"===e.key&&n()};return window.addEventListener("keyup",e,!1),function(){return window.removeEventListener("keyup",e)}})),(0,U.w)({refOrElement:i,observeOnly:"height",onResize:w}),(0,r.useEffect)((function(){w()}),[w]),!t.current)return null;var C="language-selection-title",P="language-selection-subtitle",N={"--header-height":d};return(0,b.createPortal)((0,u.jsx)(q.s,{active:m,children:(0,u.jsx)("div",{children:(0,u.jsx)(Z,{onClose:O,children:(0,u.jsxs)(F,{ariaLabelledBy:C,ariaDescribedBy:P,children:[(0,u.jsxs)("div",{className:A,ref:i,children:[(0,u.jsxs)("div",{className:z,children:[(0,u.jsx)(v.E,{as:"h1",variant:"titleSmall",semanticColor:"textBase",id:C,paddingBottom:g.v4,children:o.Ru.get("i18n.language-selection.title")}),(0,u.jsx)(v.E,{as:"p",variant:"bodyMedium",semanticColor:"textBase",id:P,paddingBottom:g.CD,children:o.Ru.get("i18n.language-selection.subtitle")})]}),(0,u.jsx)(K,{onClose:O})]}),(0,u.jsx)(B,{style:J({},N),children:c.Np.map((function(e){var n=(0,o.a7)(e).baseName,t=(0,x.p)({localeFeatureFlag:j,urlLocale:n,type:"locale"});return(0,u.jsxs)(E,{onClick:k,locale:e,type:t?"link":"button",children:[(0,u.jsx)(v.E,{semanticColor:"textBase",children:c.IB[e].displayName}),(0,u.jsx)(v.E,{children:c.IB[e].displayNameEn})]},e)}))})]})})})}),t.current)}}}]);