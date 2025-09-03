// --- SITE.JS ---

document.addEventListener("DOMContentLoaded", function () {
    // Dropdown hover on desktop
    const dropdowns = document.querySelectorAll('.navbar .dropdown');
    dropdowns.forEach(dropdown => {
        dropdown.addEventListener('mouseenter', function () {
            if (window.innerWidth > 992) {
                this.querySelector('.dropdown-menu').classList.add('show');
            }
        });
        dropdown.addEventListener('mouseleave', function () {
            if (window.innerWidth > 992) {
                this.querySelector('.dropdown-menu').classList.remove('show');
            }
        });
    });

    // Search input highlight
    const searchInput = document.querySelector('.search-block input');
    if (searchInput) {
        searchInput.addEventListener('focus', () => {
            searchInput.style.borderColor = '#007bff';
            searchInput.style.boxShadow = '0 0 5px rgba(0, 123, 255, 0.5)';
        });
        searchInput.addEventListener('blur', () => {
            searchInput.style.borderColor = '#ccc';
            searchInput.style.boxShadow = 'none';
        });
    }

    // Auto-update date (every minute)
    function updateDate() {
        const dateElement = document.querySelector('.today-date');
        if (dateElement) {
            const now = new Date();
            const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
            dateElement.textContent = now.toLocaleDateString('fr-FR', options);
        }
    }

    updateDate();
    setInterval(updateDate, 60000);
});
