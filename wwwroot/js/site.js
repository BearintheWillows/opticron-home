// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const editable = document.querySelectorAll('.editable');

editable.forEach((item) => {
    item.addEventListener('blur', () => {
        const editedContent = item.innerHTML;
        const id = item.id;
        console.log(editedContent, id)
        const idParts = id.split(/\.|-/);
        
        for (let i = 0; i < idParts.length; i++) {
            console.log(idParts[i]);
        }
        const pageAreaType = idParts[0];
        const pageAreaPart = idParts[1];
        const pageAreaId = idParts[2];
        
        console.log(pageAreaType, pageAreaPart, pageAreaId);
        switch (pageAreaType) {
            case 'mo':
                UpdateMediaObject(editedContent, pageAreaPart, pageAreaId);
                break;
            case 'pc':
                UpdateProductCategories(editedContent, pageAreaPart, pageAreaId);
                break;
            case 'so':
                UpdateSpecialOffers(editedContent, pageAreaPart, pageAreaId);
                break;}
    })
})

function UpdateMediaObject(content, part, id) {
    const url = `/api/homecontent/mediaobjects/${id}`;
    const params = {
        id: id,
        title: part === 'title' ? content : null,
        text: part === 'text' ? content : null,
        buttonTest: part === 'buttonText' ? content : null,
    };
    
    sendRequest(url, 'PUT', params);
};

function UpdateProductCategories(content, part, id) {
    const url = `/api/homecontent/productcategories/${id}`;
    const params = {
        id: id,
        categoryTitle : part === 'categoryTitle' ? content : null
    };
    
    sendRequest(url, 'PUT', params);
};

function UpdateSpecialOffers(content, part, id) {
    const url = `/api/homecontent/specialOffers/${id}`;
    const params = {
        id: id,
        itemTitle : part === 'itemTitle' ? content : null,
        itemText : part === 'itemText' ? content : null
    };
    
    sendRequest(url, 'PUT', params);
};
        
function sendRequest(url, method, params) {
    const xhr = new XMLHttpRequest();
    xhr.open(method, url, true);
    xhr.setRequestHeader('Content-type', 'application/json');
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            console.log(xhr.responseText);
        } else {
            console.log('error');
        }
    };
    console.log(JSON.stringify(params));
    xhr.send(JSON.stringify(params));
}
        
        
        
$(document).ready(function () {
    $('.product-slider').slick({
        dots: false,
        infinite: true,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 2,
        adaptiveHeight: true,
        prevArrow: '<button type="button" class="slick-prev"><img src="./images/left_slider_arrow.png" alt=""></i></button>',
        nextArrow: '<button type="button" class="slick-next"><img src="./images/right_slider_arrow.png" alt=""></button>',
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 4,
                    slidesToScroll: 2,
                    infinite: true,
                    dots: false
                }
            },
            {
                breakpoint: 900,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
                    
        
    })
    ;
});