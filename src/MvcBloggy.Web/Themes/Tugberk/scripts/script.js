(function() { 
    $(function() { 
                
        var _designatedWindowWidthForRedisgn = 1098;
        var _designatedWindowWidthForNav = 673;
        var $_windowWidth = $(window).width();
                    
        if($_windowWidth <= _designatedWindowWidthForRedisgn) { 
            appendSeperatorsForArchiveList();
        }
                    
        if($_windowWidth <= _designatedWindowWidthForNav) { 
            buildNavSelectListFromUlList();
        }
                    
        $(window).resize(function() { 
                    
            var _windowWidth = $(window).width();
            if(_windowWidth <= _designatedWindowWidthForRedisgn && 
                $_windowWidth > _designatedWindowWidthForRedisgn && 
                getLengthSeperatorForArchiveList() <= 0) { 
                            
                appendSeperatorsForArchiveList();
            }
                        
            if(_windowWidth >= _designatedWindowWidthForRedisgn &&
                getLengthSeperatorForArchiveList() >= 1) { 
                            
                removeSeperatorsForArchiveList();
            }
                        
            if(_windowWidth <= _designatedWindowWidthForNav && 
                $_windowWidth > _designatedWindowWidthForNav && 
                !isNavSelectListExists()) { 
                            
                buildNavSelectListFromUlList();
            }
                        
            if(_windowWidth >= _designatedWindowWidthForNav &&
                $("nav:hidden").length === 1) { 
                            
                reverseNavSelectListFromUlList();
            }
                        
            $_windowWidth = $(window).width();
        });
                    
        function appendSeperatorsForArchiveList() { 
            $("#mvcbloggy-monthlyarchive li a").
                after('<span class="mvcbloggy-monthlyarchiveseperator"> | </span>');
            $("#mvcbloggy-monthlyarchive span.mvcbloggy-monthlyarchiveseperator").last().remove();
        }
                    
        function removeSeperatorsForArchiveList() { 
            $("#mvcbloggy-monthlyarchive span.mvcbloggy-monthlyarchiveseperator").remove();
        }
                    
        function getLengthSeperatorForArchiveList() { 
            return $("#mvcbloggy-monthlyarchive span.mvcbloggy-monthlyarchiveseperator").length;
        }
                    
        function buildNavSelectListFromUlList() { 
                        
            var markUp = ["<select id='mvcbloggy-navselect'>"], $nav = $("nav"), $li, $a;
            markUp.push("<option value='' selected='selected'>Go to...</option>");
                        
            $("nav ul li").each(function() { 
                $li = $(this);
                $a = $li.find("a");
                markUp.push("<option value='"+$a.attr("href")+"'>"+$a.text()+"</option>");
            });
                        
            markUp.push("</select>");
                        
            $nav.after(markUp.join(''));
            $("#mvcbloggy-navselect").css("margin-left", "1%");
            $("#mvcbloggy-navselect").change(function() { 
                window.location = $(this).val();
            });
                        
            $nav.hide();
        }
                    
        function  reverseNavSelectListFromUlList() { 
                        
            $("#mvcbloggy-navselect").hide();
            $("nav").show();
        }
                    
        function isNavSelectListExists() { 
                    
            return ( 
                $("#mvcbloggy-navselect").length && 
                $("#mvcbloggy-navselect:hidden").length === 0
            ) ? true : false;
        }
                    
        //buildNavSelectListFromUlList();
                    
    });
})();