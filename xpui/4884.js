"use strict";(("undefined"!=typeof self?self:global).webpackChunkclient_web=("undefined"!=typeof self?self:global).webpackChunkclient_web||[]).push([[4884],{64884:(e,a,t)=>{t.d(a,{DsaModal:()=>ee});var s=t(30758),i=t(62411),n=t(422),d=t(92415),l=t(45415),r=t(56769),o=t(31417),c=t(98293),m=t(33625),u=t(22984),g=t(75497),E=t(82935);const N="vkMQw77rXE4cp8xsAdzl",h="emw6kR941D2wReukhCAJ";var x=t(86070);const f=({advertiser:e,legalEntityName:a})=>{const{item:t}=(0,m.L)()||{item:null},s=t&&(0,g.N)(t)?t?.images:void 0,i=(0,E.h)(s);return(0,x.jsxs)("div",{className:N,children:[i&&(0,x.jsx)(u._,{className:h,src:i,loading:"lazy"}),(0,x.jsx)(n.E,{variant:"bodyMediumBold","aria-label":e,children:e}),a&&(0,x.jsx)(n.E,{variant:"bodySmall",semanticColor:"textSubdued","aria-label":a,children:a})]})};var v=t(40938),T=t(45168),R=t(38107);const y="khENZvA4G9EjpLQiINss",b="Fu87PEr0tL6oDjmw_X2H",j=({title:e,showTitle:a,children:t})=>(0,x.jsxs)("section",{className:y,children:[a&&(0,x.jsx)(n.E,{className:b,variant:"bodyMediumBold",as:"h3","aria-label":e,children:e}),t]});var p=t(286);const A="P9gpV_sgryfUERYOdfor",_=({text:e,icon:a})=>(0,x.jsxs)(p.K,{className:A,condensed:!0,children:[a,(0,x.jsx)(n.E,{variant:"bodyMedium","aria-label":e,as:"h4",children:e})]});let w=function(e){return e[e.UNKNOWN=0]="UNKNOWN",e[e.AGE=1]="AGE",e[e.GEO=2]="GEO",e[e.GENDER=3]="GENDER",e[e.INTEREST=4]="INTEREST",e[e.UNRECOGNIZED=-1]="UNRECOGNIZED",e}({});const G={fromJSON:e=>({targetingTypes:globalThis.Array.isArray(e?.targetingTypes)?e.targetingTypes.map((e=>function(e){switch(e){case 0:case"UNKNOWN":return w.UNKNOWN;case 1:case"AGE":return w.AGE;case 2:case"GEO":return w.GEO;case 3:case"GENDER":return w.GENDER;case 4:case"INTEREST":return w.INTEREST;default:return w.UNRECOGNIZED}}(e))):[],legalEntityName:S(e.legalEntityName)?globalThis.String(e.legalEntityName):"",showTailoredAdsSection:S(e.showTailoredAdsSection)?Boolean(e.showTailoredAdsSection):void 0}),toJSON(e){const a={};return e.targetingTypes?.length&&(a.targetingTypes=e.targetingTypes.map((e=>function(e){switch(e){case w.UNKNOWN:return"UNKNOWN";case w.AGE:return"AGE";case w.GEO:return"GEO";case w.GENDER:return"GENDER";case w.INTEREST:return"INTEREST";case w.UNRECOGNIZED:default:return"UNRECOGNIZED"}}(e)))),""!==e.legalEntityName&&(a.legalEntityName=e.legalEntityName),void 0!==e.showTailoredAdsSection&&(a.showTailoredAdsSection=e.showTailoredAdsSection),a},create:e=>G.fromPartial(e??{}),fromPartial(e){const a={targetingTypes:[],legalEntityName:"",showTailoredAdsSection:void 0};return a.targetingTypes=e.targetingTypes?.map((e=>e))||[],a.legalEntityName=e.legalEntityName??"",a.showTailoredAdsSection=e.showTailoredAdsSection??void 0,a}};function S(e){return null!=e}const O="FB2PxTNhkGbwFwYI2ufG",I="gZYgXNWbFSAAjLzGhOI9",C="eYxzC4s3Nw68RcbK7xzl",k="QrelMvam4WOTMVaO28Rl",B="_EaBFRLKy0nZJXkiRwlx",D="N77hKGzNc_lKQ5OG1EBN",U="JceC3xibcl3MHVULIK0b",M="Uk72m6OFBBdTZ3RJb0K_",K="IFqCps3krPbH25azco3F";const F=({activeTargetingTypes:e})=>{const a=[w.GEO,w.INTEREST].some((a=>e.includes(a)));if(!a)return null;const t=a&&e.some((e=>e===w.AGE||e===w.GENDER));return(0,x.jsx)(j,{title:o.Ru.get("ad-formats.dsa.modal.otherInfo"),showTitle:t,children:(0,x.jsx)(R.b,{className:K,condensedAll:!0,children:e.map((e=>{const a=function(e){switch(e){case w.GEO:return{icon:(0,x.jsx)(v.t,{}),text:o.Ru.get("ad-formats.dsa.modal.targeting.location")};case w.INTEREST:return{icon:(0,x.jsx)(T.T,{}),text:o.Ru.get("ad-formats.dsa.modal.targeting.interests")};default:return null}}(e);return a?(0,x.jsx)(_,{icon:a.icon,text:a.text},e):null}))})})};var L=t(88219),W=t(26758),Z=t(22530),z=t(99410),J=t(29195),P=t(19862),Y=t(27301),q=t(19329);const Q=({activeTargetingTypes:e,item:a})=>{const t=(0,J.vh)(),{openURLWithSessionTransfer:s}=(0,q.L)();return[w.AGE,w.GENDER].some((a=>e.includes(a)))?(0,x.jsxs)(j,{title:o.Ru.get("ad-formats.dsa.modal.profileInfo"),showTitle:!0,children:[(0,x.jsx)(R.b,{className:K,condensedAll:!0,style:{marginBlockEnd:(0,Z.po)("base")},children:e.map((e=>{const a=function(e){switch(e){case w.AGE:return{icon:(0,x.jsx)(L.w,{}),text:o.Ru.get("ad-formats.dsa.modal.targeting.age")};case w.GENDER:return{icon:(0,x.jsx)(W.v,{}),text:o.Ru.get("ad-formats.dsa.modal.targeting.gender")};default:return null}}(e);return a?(0,x.jsx)(_,{icon:a.icon,text:a.text},e):null}))}),(0,x.jsx)(n.E,{variant:"bodyMedium",semanticColor:"textSubdued","aria-label":o.Ru.get("ad-formats.dsa.modal.adRelevancyAction"),children:o.Ru.get("ad-formats.dsa.modal.adRelevancyAction")}),(0,x.jsxs)(z.Y,{component:"button","aria-label":"Edit your Spotify profile, link",className:D,semanticColor:"textBrightAccent",onClick:()=>{s(Y.vE),t.send((0,r.m)({ad_id:a.adId,lineitem_id:a.metadata?.lineitem_id,creative_id:a.metadata?.creative_id,slot:a.slot,event:"event_clicked",reason:"edit_profile",surface:"ad_dsa_view"}))},standalone:!0,children:[(0,x.jsx)(n.E,{variant:"bodyMediumBold",as:"h2",children:o.Ru.get("ad-formats.dsa.modal.editProfile")}),(0,x.jsx)(P.p,{semanticColor:"textBrightAccent"})]})]}):null},V=({item:e})=>{const a=(0,J.vh)(),{openURLWithSessionTransfer:t}=(0,q.L)();return(0,x.jsxs)(x.Fragment,{children:[(0,x.jsx)("hr",{className:U}),(0,x.jsx)(n.E,{className:M,variant:"titleSmall","aria-label":o.Ru.get("ad-formats.dsa.modal.aboutTailoredAds"),as:"h2",children:o.Ru.get("ad-formats.dsa.modal.aboutTailoredAds")}),(0,x.jsx)(n.E,{variant:"bodyMedium",semanticColor:"textSubdued","aria-label":o.Ru.get("ad-formats.dsa.modal.tailoredAds"),children:o.Ru.get("ad-formats.dsa.modal.tailoredAds")}),(0,x.jsxs)(z.Y,{component:"button","aria-label":"Visit your privacy settings, link",className:D,semanticColor:"textBrightAccent",onClick:()=>{t(`${Y.k$}/#tailored-ads`),a.send((0,r.m)({ad_id:e.adId,creative_id:e.metadata?.creative_id,event:"event_clicked",lineitem_id:e.metadata?.lineitem_id,reason:"change_preferences",request_id:e.requestId,slot:e.slot,surface:"ad_dsa_view"}))},standalone:!0,children:[(0,x.jsx)(n.E,{variant:"bodyMediumBold",as:"h2",children:o.Ru.get("ad-formats.dsa.modal.privacySetting")}),(0,x.jsx)(P.p,{semanticColor:"textBrightAccent"})]})]})};var X=t(17429);const H=e=>{const[a,t]=(0,s.useState)(null),[i,n]=(0,s.useState)(!1);return(0,s.useEffect)((()=>{e?.metadata?.lineitem_id&&e.adId&&(async e=>{try{n(!0);const a=await X.ZY(e);t(G.fromJSON(a)),n(!1)}catch(e){n(!1)}})({lineitemId:e.metadata.lineitem_id,adId:e.adId})}),[e]),{data:a,loading:i}};var $=t(44971);const ee=({item:e})=>{const a=(0,J.vh)(),t=(0,i.wA)(),{isOpen:m}=(0,i.d4)((e=>e.ui.dsaDialog)),{data:u,loading:g}=H(e);return(0,s.useEffect)((()=>{a.send((0,r.m)({ad_id:e.adId,creative_id:e.metadata?.creative_id,event:"event_viewed",lineitem_id:e.metadata?.lineitem_id,reason:"ad_dsa_view",request_id:e.requestId,slot:e.slot,surface:"ad_dsa_view"}))}),[]),(0,x.jsxs)($.A,{className:O,isOpen:m,shouldCloseOnEsc:!0,shouldCloseOnOverlayClick:!0,contentLabel:o.Ru.get("ad-formats.dsa.aboutThisAd"),children:[(0,x.jsx)("div",{className:C,children:(0,x.jsx)(n.E,{"aria-label":o.Ru.get("ad-formats.dsa.aboutThisAd"),variant:"titleMedium",as:"h1",children:o.Ru.get("ad-formats.dsa.aboutThisAd")})}),(0,x.jsx)("hr",{className:U}),(0,x.jsx)("div",{className:I,children:g?(0,x.jsx)("div",{className:k,"data-testid":"loading-indicator",children:(0,x.jsx)(d.U,{size:"large"})}):(0,x.jsxs)(x.Fragment,{children:[(0,x.jsx)(f,{advertiser:e.metadata.advertiser,legalEntityName:u?.legalEntityName}),u?.targetingTypes.length?(0,x.jsxs)(x.Fragment,{children:[(0,x.jsx)(n.E,{className:M,variant:"titleSmall",as:"h2","aria-label":o.Ru.get("ad-formats.dsa.modal.adBasedInfoExplanation"),children:o.Ru.get("ad-formats.dsa.modal.adBasedInfoExplanation")}),(0,x.jsx)(Q,{item:e,activeTargetingTypes:u?.targetingTypes}),(0,x.jsx)(F,{item:e,activeTargetingTypes:u?.targetingTypes})]}):(0,x.jsx)(n.E,{className:M,as:"h2","aria-label":o.Ru.get("ad-formats.dsa.modal.targeting.unknown"),tabIndex:0,children:o.Ru.get("ad-formats.dsa.modal.targeting.unknown")}),u?.showTailoredAdsSection&&(0,x.jsx)(V,{item:e})]})}),(0,x.jsx)("button",{"aria-label":o.Ru.get("close_button_action"),className:B,onClick:()=>{t((0,c.ft)())},children:(0,x.jsx)(l.M,{size:"medium",semanticColor:"textBase"})})]})}}}]);