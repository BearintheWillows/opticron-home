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
        
        if (pageAreaType === 'mo'){
            UpdateMediaObject(editedContent, pageAreaPart, pageAreaId);
        }
    })
})

function UpdateMediaObject(content, part, id) {
    const xhr = new XMLHttpRequest();
    const url = `/api/homecontent/mediaobjects/${id}`;
    const params = {
        id: id,
        title: part === 'title' ? content : null,
        text: part === 'text' ? content : null,
        buttonTest: part === 'buttonText' ? content : null,
    };
    
    
    console.log(params);
    
    xhr.open('PUT', url, true);
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
};
        
        
        
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
                breakpoint: 600,
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