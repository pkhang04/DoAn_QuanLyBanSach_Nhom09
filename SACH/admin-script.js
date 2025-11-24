// Navigation handling disabled for multi‑page setup
// The original script that hides/shows content areas has been removed.
// Each module now loads as a separate HTML page, so default link navigation works.


// Mobile menu toggle
const menuToggle = document.querySelector('.menu-toggle');
const sidebar = document.querySelector('.sidebar');

if (menuToggle) {
    menuToggle.addEventListener('click', () => {
        sidebar.classList.toggle('active');
    });
}

// Close sidebar when clicking outside on mobile
document.addEventListener('click', (e) => {
    if (window.innerWidth <= 768) {
        if (!sidebar.contains(e.target) && !menuToggle.contains(e.target)) {
            sidebar.classList.remove('active');
        }
    }
});

// Modal functions
function showAddModal(type) {
    const modal = document.getElementById('addModal');
    modal.classList.add('active');

    // Update modal title based on type
    const modalTitle = modal.querySelector('.modal-header h3');
    const titles = {
        'employee': 'Thêm nhân viên mới',
        'customer': 'Thêm khách hàng mới',
        'book': 'Thêm sách mới',
        'author': 'Thêm tác giả mới',
        'publisher': 'Thêm nhà xuất bản mới',
        'category': 'Thêm thể loại mới',
        'invoice': 'Tạo hóa đơn mới'
    };
    modalTitle.textContent = titles[type] || 'Thêm mới';
}

function closeModal() {
    const modal = document.getElementById('addModal');
    modal.classList.remove('active');
}

// Close modal when clicking outside
document.getElementById('addModal')?.addEventListener('click', function (e) {
    if (e.target === this) {
        closeModal();
    }
});

// Edit button handlers
document.querySelectorAll('.btn-icon.edit').forEach(btn => {
    btn.addEventListener('click', function () {
        alert('Chức năng sửa sẽ được triển khai');
    });
});

// Delete button handlers
document.querySelectorAll('.btn-icon.delete').forEach(btn => {
    btn.addEventListener('click', function () {
        if (confirm('Bạn có chắc chắn muốn xóa?')) {
            alert('Đã xóa thành công!');
        }
    });
});

// Logout handler
document.querySelector('.logout-btn')?.addEventListener('click', function () {
    if (confirm('Bạn có chắc chắn muốn đăng xuất?')) {
        alert('Đã đăng xuất!');
        // Redirect to login page
        // window.location.href = 'login.html';
    }
});

// Search functionality
const searchInput = document.querySelector('.search-box input');
if (searchInput) {
    searchInput.addEventListener('input', function (e) {
        const searchTerm = e.target.value.toLowerCase();
        console.log('Searching for:', searchTerm);
        // Implement search logic here
    });
}

// Notification button
document.querySelector('.notification-btn')?.addEventListener('click', function () {
    alert('Bạn có 3 thông báo mới!');
});

// Animate stats on page load
window.addEventListener('load', () => {
    const statCards = document.querySelectorAll('.stat-card');
    statCards.forEach((card, index) => {
        setTimeout(() => {
            card.style.opacity = '0';
            card.style.transform = 'translateY(20px)';
            card.style.transition = 'all 0.5s ease';

            setTimeout(() => {
                card.style.opacity = '1';
                card.style.transform = 'translateY(0)';
            }, 50);
        }, index * 100);
    });
});

// Bar chart hover effect
document.querySelectorAll('.bar').forEach(bar => {
    bar.addEventListener('mouseenter', function () {
        const month = this.querySelector('span').textContent;
        const height = this.style.height;
        console.log(`${month}: ${height}`);
    });
});

// Table row hover effect
document.querySelectorAll('.data-table tbody tr').forEach(row => {
    row.addEventListener('mouseenter', function () {
        this.style.backgroundColor = '#f9fafb';
    });

    row.addEventListener('mouseleave', function () {
        this.style.backgroundColor = '';
    });
});

// Pagination
document.querySelectorAll('.page-btn').forEach(btn => {
    btn.addEventListener('click', function () {
        if (!this.classList.contains('active')) {
            document.querySelectorAll('.page-btn').forEach(b => b.classList.remove('active'));
            this.classList.add('active');
            console.log('Loading page:', this.textContent);
        }
    });
});

// Filter select
document.querySelectorAll('.search-filter select').forEach(select => {
    select.addEventListener('change', function () {
        console.log('Filter changed:', this.value);
        // Implement filter logic here
    });
});

// Year select for chart
document.querySelector('.year-select')?.addEventListener('change', function () {
    console.log('Year changed:', this.value);
    // Update chart data here
});

// Auto-hide notifications
setTimeout(() => {
    const badge = document.querySelector('.notification-btn .badge');
    if (badge && parseInt(badge.textContent) > 0) {
        // Animate badge
        setInterval(() => {
            badge.style.transform = 'scale(1.2)';
            setTimeout(() => {
                badge.style.transform = 'scale(1)';
            }, 200);
        }, 3000);
    }
}, 1000);

// Console log for debugging
console.log('📊 Admin Dashboard loaded successfully!');
console.log('🎨 Theme: BookStore Management System');
console.log('✅ All modules initialized');
