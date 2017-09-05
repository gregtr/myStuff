var jeElementProto = Object.create(HTMLElement.prototype); /* used to inherit prototype of some other element/object into our element */

/*polimorphism - extending our element*/
jeElementProto.createdCallback = function() {// called when we're using our element
//	var shadow = this.createShadowRoot(); // shadowDom method- it's depriciated - so we can use attachShadow 
  //shadow.innerHTML = '<h1>Welcome to hello.html</h1>'; // inner to shadow

  var tpl = document.querySelector('#je-elem-tpl');

  var htmlClone = document.importNode(tpl.content, true);// if we want to copy deeply or not ( true= deeply) // importing html node of tpl element to our node // btw we can load template from the external url
  
  this.attachShadow({node: 'closed'}).appendChild(htmlClone); // attachShadow requires a element property called node
};
var jeElem = document.registerElement('je-element', {prototype: jeElementProto}); /* custom element neeeds hyphen (-) so javascript knows its custom element */


// shadowDOM - encapsulation - global styles are affecting our components- if anything is affecting our component from outside - this component is not good
document.body.appendChild(new jeElem());


/* links useful for creating shadowDOM
https://developer.mozilla.org/en/docs/Web/HTMLElement/template
https://developer.mozilla.org/en-US/docs/Web/API/Document/importNode
https://developer.mozilla.org/en-US/docs/Web/API/Element/attachShadow
*/