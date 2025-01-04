function toggleMenu() {
    const navMenu = document.querySelector('nav ul');
    navMenu.classList.toggle('active');
    console.log("Menu toggled"); // Тествайте дали функцията се изпълнява

}


// Автоматично затваряне на менюто при избор на линк
document.querySelectorAll('nav ul li a').forEach(link => {
link.addEventListener('click', () => {
    const navMenu = document.querySelector('nav ul');
    const toggleButton = document.querySelector('.nav-toggle');
    navMenu.classList.remove('active');
    toggleButton.classList.remove('active');
    });
});

document.addEventListener('DOMContentLoaded', () => {
    const divs = document.querySelectorAll('.icon-grid div');
    const popup = document.createElement('div');
    const overlay = document.createElement('div');
    
    popup.classList.add('popup');
    overlay.classList.add('popup-overlay');
    document.body.appendChild(popup);
    document.body.appendChild(overlay);

    const data = {
        'Десктоп приложения': 'Десктоп приложенията са софтуерни програми, създадени за работа на компютри и лаптопи с операционни системи като Windows, macOS или Linux. Те могат да бъдат текстови редактори, мултимедийни плейъри или сложни бизнес софтуери. Ще научите как да създавате стабилни и ефективни приложения с помощта на технологии като C#, .NET и WPF, които улесняват ежедневието на милиони хора.',
        'Уеб приложения': 'Уеб приложенията са динамични уебсайтове, които предоставят на потребителите интерактивни функционалности директно през браузъра. От социални мрежи до онлайн магазини – ще се научите да създавате модерни и визуално привлекателни платформи, използвайки технологии като HTML, CSS, JavaScript и сървърни среди като Node.js, Python или PHP. Ще създавате решения, които свързват хората и преобразяват начина, по който те взаимодействат с дигиталния свят!',
        'Мобилни приложения': 'Мобилните приложения са сърцето на смартфоните, предоставяйки удобство и персонализирани услуги навсякъде, където се намирате. Ще се потопите в света на Android и iOS разработката, използвайки платформи като Kotlin, Swift и Flutter. Създавайте иновативни и бързи приложения, които завладяват потребителите и променят начина, по който те взаимодействат със света около тях.',
        'Бази данни': 'ПроектиБазите данни са гръбнакът на съвременния софтуер, осигуряващ надеждно съхранение и управление на информация. Ще научите как да проектирате и управлявате бази данни, използвайки SQL и системи като MySQL и PostgreSQL. Създавайте структури, които гарантират бърз достъп, сигурност и ефективност – ключът към успеха на всяко приложение!ране и работа с бази данни.',
        'Изкуствен интелект': 'Изкуственият интелект (AI) е бъдещето на технологиите, позволявайки на машините да мислят, учат и взимат решения. Ще се запознаете с машинното обучение, невронните мрежи и обработката на големи данни чрез инструменти като Python и TensorFlow. Преобразувайте вашите идеи в интелигентни системи, които анализират, предвиждат и автоматизират задачи – от чатботове до автономни автомобили!'
    };

    divs.forEach(div => {
        div.addEventListener('click', () => {
            const title = div.querySelector('p').innerText;
            const imgSrc = div.querySelector('img').src;

            popup.innerHTML = `
                <img src="${imgSrc}" alt="${title}">
                <h3>${title}</h3>
                <p>${data[title]}</p>
            `;

            popup.style.display = 'block';
            overlay.style.display = 'block';
        });
    });

    overlay.addEventListener('click', () => {
        popup.style.display = 'none';
        overlay.style.display = 'none';
    });

    const dropdownToggle = document.querySelector('nav ul li a[href="#program"]');
    const dropdownMenu = dropdownToggle.nextElementSibling;

    dropdownToggle.addEventListener('click', (e) => {
        e.preventDefault();
        const parentLi = dropdownToggle.parentElement;
        parentLi.classList.toggle('open');
    });

    document.addEventListener('click', (e) => {
        if (!dropdownToggle.contains(e.target) && !dropdownMenu.contains(e.target)) {
            const parentLi = dropdownToggle.parentElement;
            parentLi.classList.remove('open');
        }
    });

    // Show divs one by one
    divs.forEach((div, index) => {
        setTimeout(() => {
            div.classList.add('show');
        }, index * 300); // 300ms delay for each div
    });
});
