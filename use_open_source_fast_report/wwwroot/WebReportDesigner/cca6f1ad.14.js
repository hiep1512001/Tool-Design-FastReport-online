(window.webpackJsonp=window.webpackJsonp||[]).push([[14],{607:function(n,e,t){},618:function(n,e,t){"use strict";function i(p){Object(r.a)().then(function(n){var e=p.prop("TextOutline.Enabled"),t=new c.a("OutlineEditor"),i=s()(f(e)),o=i.find(".fr-outline-editor-enabled"),r=i.find(".fr-outline-editor-style"),l=i.find(".fr-outline-editor-width"),d=i.find(".fr-outline-editor-color"),a=i.find(".fr-outline-editor-drawbehind"),u=i.find(".fr-outline-group");o.on("change",function(){u.toggleClass("fr-hidden",!o.is(":checked"))}),u.toggleClass("fr-hidden",!e),r.val(p.prop("TextOutline.Style")||"Solid"),l.val(p.prop("TextOutline.Width")||1),d.val(p.prop("TextOutline.Color")||"#000"),a.prop("checked",!!p.prop("TextOutline.DrawBehind")),s()(".fr-outline-editor-save-btn",i).on("click",function(){o.is(":checked")?p.prop({"TextOutline.Enabled":!0,"TextOutline.Style":r.val(),"TextOutline.Width":l.val(),"TextOutline.Color":d.val(),"TextOutline.DrawBehind":a.is(":checked")}):(p.deleteProp("TextOutline.Enabled"),p.deleteProp("TextOutline.Style"),p.deleteProp("TextOutline.Width"),p.deleteProp("TextOutline.Color"),p.deleteProp("TextOutline.DrawBehind")),p.render(),t.close()}),t.find(".fr-modal-content").html(i),n.append(t),window.DSG.head.put(n)})}var o,s,r,c,l,d,f;t.r(e),t(607),o=t(0),s=t.n(o),r=t(175),c=t(247),l=t(2),d=t(4),f=function(n){return'\n        <div>\n            <div class="fr-modal-body fr-outline-editor">\n                <label for="outline-enabled">\n                    <span>'+l.a.tr("OutlineEditor Enabled")+'</span>\n                    <input type="checkbox" id="outline-enabled" class="fr-outline-editor-enabled" '+(n?"checked":"")+'/>\n                </label>\n                <div class="fr-outline-group fr-hidden">\n                    <hr>\n                    <div>\n                        <span>'+l.a.tr("OutlineEditor Style")+'</span>\n                        <select class="fr-outline-editor-style">\n                            '+function(){var e="";return Object.keys(d.a.get("dasharrays")).forEach(function(n){e+='<option value="'+n+'">'+n+"</option>"}),e}()+"\n                        </select>\n                    </div>\n                    <hr>\n                    <div>\n                        <span>"+l.a.tr("OutlineEditor Width")+'</span>\n                        <input type="number" class="fr-outline-editor-width" step="0.5"/>\n                    </div>\n                    <hr>\n                    <div>\n                        <span>'+l.a.tr("OutlineEditor Color")+'</span>\n                        <input type="color" class="fr-outline-editor-color"/>\n                    </div>\n                    <hr>\n                    <div>\n                        <label for="outline-drawbehind">\n                            <span>'+l.a.tr("OutlineEditor DrawBehind")+'</span>\n                            <input type="checkbox" id="outline-drawbehind" class="fr-outline-editor-drawbehind"/>\n                        </label>\n                    </div>\n                </div>\n            </div>\n            <div class="fr-modal-footer content-right">\n                <button type="button" class="fr-btn fr-btn-primary fr-outline-editor-save-btn">\n                    '+l.a.tr("Buttons Ok")+"\n                </button>\n            </div>\n        </div>\n    "},t.d(e,"create",function(){return i})}}]);